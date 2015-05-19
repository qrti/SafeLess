using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeLess
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            lnkHome.Links.Add(0, 0, @"http:\\www.qland.de\software\safeless\index.html");
            rtbHelp.Rtf = text;
        }

        private void pibLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lnkHome.Links[0].LinkData.ToString());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pibPayPal_Click(object sender, EventArgs e)
        {
            lnkDonate_LinkClicked(null, null);
        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void lnkDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string business     = "qrt@qland.de";
            string description  = "Donation for SafeLess";
            string country      = "US";                 
            string currency     = "USD";               

            string url = "https://www.paypal.com/cgi-bin/webscr" +
                         "?cmd=" + "_donations" +
                         "&business=" + business +
                         "&lc=" + country +
                         "&item_name=" + description +
                         "&currency_code=" + currency;

            System.Diagnostics.Process.Start(url);
        }

string text = @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1031{\fonttbl{\f0\fnil\fcharset0 Consolas;}{\f1\fnil Consolas;}}
{\colortbl ;\red163\green21\blue21;\red255\green255\blue255;\red0\green0\blue0;\red255\green0\blue0;}
{\*\generator Riched20 6.3.9600}\viewkind4\uc1 
\pard\sa200\sl276\slmult1\cf1\highlight2\b\f0\fs28 Instructions\fs22\par
SafeLess\b0\line\fs19 does not store passwords, they are calculated on the fly. Individually for each site they are derived from a \f1\lang7 master passwor\f0\lang1031 d.\cf3  \cf1\f1\lang7 SHA256 encryption \f0\lang1031 ens\f1\lang7 ures that 'back calculating' \f0\lang1031 the\f1\lang7  master password is not possib\f0\lang1031 le. \f1\lang7 For comfortable usage\f0\lang1031  \f1\lang7 site settings are stored\f0\lang1031  optionally.\par
\cf4 This is a stable working beta release, anyway install it at your own risk and be sure to note down or save your generated access codes to a second place. \cf3 I'm looking forward to your reports and suggestions ...\cf1\par
\b\fs22 Hovering\b0\fs19\line over fields, buttons and check-marks pops up a brief help.\cf3\f1\lang7\par
\cf1\b\fs22 User\b0\fs19\line Enter a username here, so more than one person can use same sites with different logins.\cf3\f0\lang1031  \cf1\f1\lang7 At least \f0\lang1031 four\f1\lang7  letters or digits are required\f0\lang1031 . The font color changes from blue to black if valid.\cf3\f1\lang7\par
\cf1\b\fs22 Master Password\cf3\b0\line\cf1\fs19 From this password \f0\lang1031 all \f1\lang7 passwords for your sites are derived. \f0\lang1031 At least four\f1\lang7  letters, digits or special characters are\f0\lang1031  required. The font color changes from blue to black if valid.\cf3\f1\lang7\par
\cf1\b\fs22 Site\cf3\b0\fs19\line\cf1 Enter a sitename here, for example the sites URL\f0\lang1031  or parts of it\f1\lang7 . At least \f0\lang1031 four\f1\lang7  letters, digits or special characters are required\f0\lang1031 . While typing already saved sites are suggested. Suggestions can be browsed with cursor up/down and taken over by pressing return. The font color changes from blue to black if a site is already stored.\par
- Change the digit to the right to get a fresh password for a site\line - Save-button saves site\line - Delete-button deletes site\line - <-button navigates backwards through saved sites\line - >-button navigates forward through saved sites\par
\b\fs22 Username\b0\fs19\line Enter the username for a site here, mostly an eMail address is used. This field is optional.\cf3\f1\lang7\par
\cf1\b\f0\fs22\lang1031 Password\b0\fs19\line Calculated password for a site.\par
- Below this field you can change the complexity and length of the password\par
\b\fs22 CTRL-U/P\b0\fs19\line If checked and a password is shown, CTRL-U/P fills in a sites username and password.\par
- place the cursor on sites username/password field\line - press CTRL-U on username\line - press CTRL-P on password\par
\b\fs22 Copyright\line\b0\fs19 SafeLess uses ISC license.\line Thanks to 'Zer' for CryptSharp that uses ISC license.\par
\par
Copyright (c) 2014, Kurt Schuster, qrt@qland.de\par
Permission to use, copy, modify, and/or distribute this software for any purpose with or without fee is hereby granted, provided that the above copyright notice and this permission notice appear in all copies.\par
THE SOFTWARE IS PROVIDED 'AS IS' AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.\par
\par
}
";

    }
}
