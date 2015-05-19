using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CryptSharp;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace SafeLess
{
    public partial class Form1 : Form
    {
        static int MINLEN = 4;

        static string charLower = "abcdefghijklmonpqrstuvwxyz";
        static string charUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string charDigit = "0123456789";
        static string charSpeci = "@&%?=[]_-+$#!()";

        SortedList<string, SiteData> siteList;                      // sorted list of sites
        IEnumerable<KeyValuePair<string, SiteData>> siteQuery;      // list of queried sites
        int clie;                                                   // current list element
        int cqse;                                                   // current qeried site element

        [Serializable]
        public class SiteData
        {
            public string user { get; set; }
            public string site { get; set; }
            public string username { get; set; }
            public bool hideMaster { get; set; }
            public bool hidePassword { get; set; }
            public bool lower { get; set; }
            public bool upper { get; set; }
            public bool digit { get; set; }
            public bool speci { get; set; }
            public int numSite { get; set; }
            public int length { get; set; }

            public string res_string1 { get; set; }                 // reseved
            public string res_string2 { get; set; }
            public bool res_bool1 { get; set; }
            public bool res_bool2 { get; set; }
            public int res_int1 { get; set; }
            public int res_int2 { get; set; }
        }

        private KeyboardInput keyboardInput;

        public Form1()
        {
            InitializeComponent();
        }

        void keyboard_KeyBoardKeyPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.U){
                clipField(e, txtUsername.Text);
                e.Handled = true;
            }
            else if(e.KeyCode == Keys.P){
                clipField(e, txtPassword.Text);
                e.Handled = true;
            }
            else{
                e.Handled = false;
            }
        }

        private void clipField(KeyEventArgs e, string text)
        {
            if(e.Handled && text!=""){      // handled == true if key up
                string clip = Clipboard.GetText();

                Clipboard.SetText(text);
                SendKeys.Send("^v");

                if(clip != "")
                    Clipboard.SetText(clip);
                else
                    Clipboard.Clear();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if(Settings.Load())             // try to load settings
                Settings.Save();            // if no settings or wrong version, set up one with defaults

            if(Settings.config.formPosX<0 || Settings.config.formPosX>System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width)
                Settings.config.formPosX = 0;
                
            if(Settings.config.formPosY<0 || Settings.config.formPosY>System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height)
                Settings.config.formPosY = 0;

            this.Location = new Point(Settings.config.formPosX, Settings.config.formPosY);

            txtUser.Text = Settings.config.user;
            chkHideMaster.Checked = Settings.config.hideMaster;
            chkHidePassword.Checked = Settings.config.hidePassword;
            chkCtrlUP.Checked = Settings.config.ctrlUP;             // triggers changed event (and instantiates keyboardInput)
            chkLower.Checked = Settings.config.lower;
            chkUpper.Checked = Settings.config.upper;
            chkDigit.Checked = Settings.config.digit;
            chkSpeci.Checked = Settings.config.speci;
            numLength.Value = Settings.config.length;
            siteList = Settings.config.siteList;

            lblSiteCompleter.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(keyboardInput != null)
                keyboardInput.Dispose();

            Settings.config.formPosX = this.Location.X;
            Settings.config.formPosY = this.Location.Y;

            Settings.config.user = txtUser.Text.Trim();
            Settings.config.hideMaster = chkHideMaster.Checked;
            Settings.config.hidePassword = chkHidePassword.Checked;
            Settings.config.ctrlUP = chkCtrlUP.Checked;
            Settings.config.lower = chkLower.Checked;
            Settings.config.upper = chkUpper.Checked;
            Settings.config.digit = chkDigit.Checked;
            Settings.config.speci = chkSpeci.Checked;
            Settings.config.length = (int)numLength.Value;

            Settings.Save();
        }

        private void chkCtrlUP_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCtrlUP.Checked){
                if(keyboardInput == null){
                    keyboardInput = new KeyboardInput();
                    keyboardInput.KeyBoardKeyPressed += keyboard_KeyBoardKeyPressed;
                }
            }
            else{
                if(keyboardInput != null){
                    keyboardInput.Dispose();
                    keyboardInput = null;
                }
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0-9a-zA-Z _\b]"))
                e.Handled = true;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtUser.ForeColor = txtUser.Text.Length>=MINLEN ? Color.Black : Color.SlateBlue;
            calcPassword();
        }

        private void txtMasterPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
                e.Handled = true;
        }

        private void txtMasterPassword_TextChanged(object sender, EventArgs e)
        {
            txtMasterPassword.ForeColor = txtMasterPassword.Text.Length>=MINLEN ? Color.Black : Color.SlateBlue;
            calcPassword();
        }

        private void txtSite_Leave(object sender, EventArgs e)
        {
            lblSiteCompleter.Text = "";
        }

        bool blockCompleter = false;

        private void txtSite_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Up || e.KeyCode==Keys.Down){
                if(siteQuery != null){
                    if(e.KeyCode==Keys.Up && --cqse<0)
                        cqse = 0;
                    else if(e.KeyCode==Keys.Down && ++cqse>=siteQuery.Count())
                        cqse = siteQuery.Count() - 1;

                    lblSiteCompleter.Text = siteQuery.ElementAt(cqse).Value.site.Substring(txtSite.Text.Length);
                }
                else{
                    txtSite_TextChanged(null, null);
                }

                e.Handled = true;
            }
            else if(e.KeyCode == Keys.Return){
                if(lblSiteCompleter.Text != ""){
                    blockCompleter = true;
                    txtSite.AppendText(lblSiteCompleter.Text);
                    showSiteData();
                }
            }
        }

        private void txtSite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)      // block sound
                e.Handled = true;
        }

        private void txtSite_TextChanged(object sender, EventArgs e)
        {
            string text = "";
            bool siteEqual = false;
            siteQuery = null;
            
            if(siteList.Count>0 && txtUser.Text.Length>=MINLEN && txtSite.Text.Length>0){
                string user = txtUser.Text;
                string site = txtSite.Text;
                int len = site.Length;

                siteQuery = siteList.Where(s => s.Value.user.Equals(user) && 
                                                s.Value.site.Length >= len &&
                                                s.Value.site.Substring(0, len).Equals(site));

                if(siteQuery.Count() > 0){
                    cqse = 0;
                    clie = siteList.IndexOfKey(siteQuery.ElementAt(cqse).Key);
                    siteEqual = siteQuery.ElementAt(cqse).Value.site.Equals(site);

                    if(!blockCompleter)
                        text = siteQuery.ElementAt(cqse).Value.site.Substring(txtSite.Text.Length); 
                }
                else{
                    siteQuery = null;
                }
            }

            if(siteEqual){
                txtSite.ForeColor = Color.Black;
            }
            else{
                txtSite.ForeColor = Color.SlateBlue;
                txtUsername.Text = "";
                numSite.Value = 1;
            }
            
            int left = txtSite.Left + TextRenderer.MeasureText(txtSite.Text, txtSite.Font).Width - 3;
            lblSiteCompleter.Left = left;
            lblSiteCompleter.Text = text;
            blockCompleter = false;
            calcPassword();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
                e.Handled = true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            calcPassword();
        }

        private void numSite_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
                e.SuppressKeyPress = true;
        }

        private void numSite_ValueChanged(object sender, EventArgs e)
        {
            calcPassword();
        }

        private void numLength_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
                e.SuppressKeyPress = true;
        }

        private void numLength_ValueChanged(object sender, EventArgs e)
        {
            calcPassword();
        }
 
        private void chkLower_CheckedChanged(object sender, EventArgs e)
        {
            calcPassword();
        }

        private void chkDigit_CheckedChanged(object sender, EventArgs e)
        {
            calcPassword();
        }

        private void chkUpper_CheckedChanged(object sender, EventArgs e)
        {
            calcPassword();
        }

        private void chkSpeci_CheckedChanged(object sender, EventArgs e)
        {
            calcPassword();
        }

        private void chkHideMaster_CheckedChanged(object sender, EventArgs e)
        {
            txtMasterPassword.UseSystemPasswordChar = chkHideMaster.Checked;
        }

        private void chkHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = chkHidePassword.Checked;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(siteList.ContainsKey(txtUser.Text + txtSite.Text)){
                if(MessageBox.Show("Update Site?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    int s = siteList.IndexOfKey(txtUser.Text + txtSite.Text);
                    var value = siteList.ElementAt(s).Value;
                    value.username = txtUsername.Text;
                    value.hideMaster = chkHideMaster.Checked;
                    value.hidePassword = chkHidePassword.Checked;
                    value.lower = chkLower.Checked;
                    value.upper = chkUpper.Checked;
                    value.digit = chkDigit.Checked;
                    value.speci = chkSpeci.Checked;
                    value.numSite = (int)numSite.Value;
                    value.length = (int)numLength.Value;
                }
            }
            else{
                SiteData data = new SiteData();
                data.user = txtUser.Text;
                data.site = txtSite.Text;
                data.username = txtUsername.Text;
                data.hideMaster = chkHideMaster.Checked;
                data.hidePassword = chkHidePassword.Checked;
                data.lower = chkLower.Checked;
                data.upper = chkUpper.Checked;
                data.digit = chkDigit.Checked;
                data.speci = chkSpeci.Checked;
                data.numSite = (int)numSite.Value;
                data.length = (int)numLength.Value;
                siteList.Add(key: txtUser.Text + txtSite.Text, value: data);
                txtSite.ForeColor = Color.Black;
            }
        }

        private void btnSitePrev_Click(object sender, EventArgs es)
        {
            if(--clie < 0) 
                clie = 0;
            
            lblSiteCompleter.Text = "";
            blockCompleter = true;
            showSiteData();
        }
        
        private void btnSiteNext_Click(object sender, EventArgs e)
        {
            if(++clie > siteList.Count - 1)
                clie = siteList.Count - 1;
            
            lblSiteCompleter.Text = "";
            blockCompleter = true;
            showSiteData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(siteList.ContainsKey(txtUser.Text + txtSite.Text)){
                if(MessageBox.Show("Delete Site?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    siteList.Remove(txtUser.Text + txtSite.Text);
                    txtSite.Text = "";
                    clie = 0;
                }
            }
            else{
                MessageBox.Show("User + Site does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms){
                if(f is AboutBox){
                    f.Focus();
                    return;
                }
            }

            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //----------------------------------------------------------------------

        private void showSiteData()
        {
            if(siteList.Count == 0)
                return;

            txtUser.Text = siteList.ElementAt(clie).Value.user;
            txtSite.Text = siteList.ElementAt(clie).Value.site;
            txtUsername.Text = siteList.ElementAt(clie).Value.username;
            chkHideMaster.Checked = siteList.ElementAt(clie).Value.hideMaster;
            chkHidePassword.Checked = siteList.ElementAt(clie).Value.hidePassword;
            chkLower.Checked = siteList.ElementAt(clie).Value.lower;
            chkUpper.Checked = siteList.ElementAt(clie).Value.upper;
            chkDigit.Checked = siteList.ElementAt(clie).Value.digit;
            chkSpeci.Checked = siteList.ElementAt(clie).Value.speci;
            numSite.Value = siteList.ElementAt(clie).Value.numSite;
            numLength.Value = siteList.ElementAt(clie).Value.length;
        }

        private void calcPassword()
        {
            string nameSpace = "qland.de/safeless";     
            string user = txtUser.Text.Trim();
            string masterPassword = txtMasterPassword.Text.Trim();
            string site = txtSite.Text.Trim();
            string username = txtUsername.Text.Trim();            
            string siteCount = numSite.Value.ToString();
            
            btnSave.Enabled = user.Length>=MINLEN && site.Length>=MINLEN;
            string pw = "";

            if(user.Length>=MINLEN && masterPassword.Length>=MINLEN && site.Length>=MINLEN &&
               (chkLower.Checked || chkUpper.Checked || chkDigit.Checked || chkSpeci.Checked)){

                string masterKeySalt = ("$5$" + user.Length.ToString() + user + nameSpace).Replace(' ', '.');   // $algorythm$salt
                string masterKey_ash = Crypter.Sha256.Crypt(masterPassword, masterKeySalt);                     // $algorythm$salt$hash
                string[] parts = masterKey_ash.Split(new[] {'$'}, 4);
                string masterKey = parts[3];
                string sitePasswordInfo = nameSpace + site.Length.ToString() + site + siteCount + 
                                          (chkLower.Checked ? "l" : "L") +
                                          (chkUpper.Checked ? "u" : "U") +
                                          (chkDigit.Checked ? "d" : "D") +
                                          (chkSpeci.Checked ? "s" : "S") +
                                          numLength.Value.ToString();
            
                byte[] sitePasswordInfo_bytes = System.Text.Encoding.UTF8.GetBytes(sitePasswordInfo);
                byte[] masterKey_bytes = System.Text.Encoding.UTF8.GetBytes(masterKey);

                KeyedHashAlgorithm hmacSha256 = new HMACSHA256(masterKey_bytes);
                hmacSha256.ComputeHash(sitePasswordInfo_bytes);

                string pwcom = "";                              // password composition

                if(chkLower.Checked)
                    pwcom += "L";         

                if(chkUpper.Checked)
                    pwcom += "U";         

                if(chkDigit.Checked)
                    pwcom += "D";

                if(chkSpeci.Checked)
                    pwcom += "S";

                string pwpat = "";                              // password pattern

                if(pwcom.Length==1 || pwcom=="LU")
                    pwpat = "*";
                else if(pwcom=="LD" || pwcom=="LS" || pwcom=="LDS")
                    pwpat = "L*";
                else if(pwcom=="UD" || pwcom=="US" || pwcom=="UDS")
                    pwpat = "U*";
                else if(pwcom == "DS")
                    pwpat = "D*";
                else
                    pwpat = "C*";

                int j=0;

                for(int i=0; i<numLength.Value; i++){
                    pw += getChar(hmacSha256.Hash[i], pwpat[j], pwcom, pw);

                    if(j < pwpat.Length-1) 
                        j++;
                }
            }
            
            txtPassword.Text = pw;
        }

        char getChar(byte hashByte, char charKind, string pwcom, string pw)
        {
            string chars = "";

            switch(charKind){
                case 'L':
                    chars = charLower;
                    break;

                case 'U':
                    chars = charUpper;
                    break;

                case 'C':
                    chars = charLower + charUpper;
                    break;

                case 'D':
                    chars = charDigit;
                    break;

                case 'S':
                    chars = charSpeci;
                    break;

                case '*':
                    string misk = "";                                   // missing charKinds
                    if(pwcom.IndexOf('L')!=-1 && !contains(pw, charLower)) misk += "L";
                    if(pwcom.IndexOf('U')!=-1 && !contains(pw, charUpper)) misk += "U";
                    if(pwcom.IndexOf('D')!=-1 && !contains(pw, charDigit)) misk += "D";
                    if(pwcom.IndexOf('S')!=-1 && !contains(pw, charSpeci)) misk += "S";

                    int numiki = misk.Length;                           // number of missing charKinds
                    int nupato = (int)numLength.Value - pw.Length;      // number of password chars to go

                    if(numiki == nupato){
                        if(misk.IndexOf('L')!=-1 && numiki-->0) chars += charLower;
                        if(misk.IndexOf('U')!=-1 && numiki-->0) chars += charUpper;
                        if(misk.IndexOf('D')!=-1 && numiki-->0) chars += charDigit;
                        if(misk.IndexOf('S')!=-1 && numiki-->0) chars += charSpeci;
                    }
                    else{
                        if(pwcom.IndexOf('L') != -1) chars += charLower;
                        if(pwcom.IndexOf('U') != -1) chars += charUpper;
                        if(pwcom.IndexOf('D') != -1) chars += charDigit;
                        if(pwcom.IndexOf('S') != -1) chars += charSpeci;
                    }

                    break;
            }

            return chars[hashByte % chars.Length];
        }

        bool contains(string pw, string chars)
        {
            bool cnt = false;

            foreach(char p in pw){
                if(chars.IndexOf(p) != -1){
                    cnt = true;
                    break;
                }
            }

            return cnt;
        }

    }
}

//IEnumerable<KeyValuePair<string, SiteData>> to SortedList<string, SiteData>
//
//SortedList<string, SiteData> siteQuery;
//siteQuery = new SortedList<string, SiteData>(siteList.Where(site => site.Key.CompareTo(search) > 0).ToDictionary(kvp => kvp.Key, kvp => kvp.Value));         // KeyValuePair<string, SiteData> query

//siteData -> siteQuery
//
//IEnumerable<KeyValuePair<string, SiteData>> siteQuery;      // list of queried sites
//
//private void txtSite_TextChanged(object sender, EventArgs e)
//{
//    string text = "";
//    querySiteList();
//
//    if(txtSite.Text.Length>0 && siteQuery!=null){
//        text = siteQuery.ElementAt(0).Value.site.Substring(txtSite.Text.Length);
//        cuqe = 0;
//    }
//                
//    updateCompleter(text);
//    calcPassword();
//}
//
//private void querySiteList()
//{
//    siteQuery = null;
//
//    if(siteList.Count > 0){
//        string search = txtUser.Text + txtSite.Text;
//        int len = search.Length;
//        var leftMatch = siteList.Where(site => site.Key.Length>=len && site.Key.Substring(0, len).Equals(search));
//
//        if(leftMatch.Count() > 0)
//            siteQuery = siteList.Where(site => site.Key.CompareTo(search) > 0);
//    }
//}
//
//private void updateCompleter(string text)
//{
//    int left = txtSite.Left + TextRenderer.MeasureText(txtSite.Text, txtSite.Font).Width;
//    lblSiteCompleter.Left = left + (txtSite.Text.Length==0 ? 4 : -3);
//    lblSiteCompleter.Text = text;
//}