namespace SafeLess
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMasterPassword = new System.Windows.Forms.Label();
            this.txtMasterPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.chkDigit = new System.Windows.Forms.CheckBox();
            this.chkSpeci = new System.Windows.Forms.CheckBox();
            this.numSite = new System.Windows.Forms.NumericUpDown();
            this.chkHideMaster = new System.Windows.Forms.CheckBox();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSitePrev = new System.Windows.Forms.Button();
            this.btnSiteNext = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkHidePassword = new System.Windows.Forms.CheckBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.chkCtrlUP = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.grpSite = new System.Windows.Forms.GroupBox();
            this.lblSiteCompleter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.grpUser.SuspendLayout();
            this.grpSite.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMasterPassword
            // 
            this.lblMasterPassword.AutoSize = true;
            this.lblMasterPassword.Location = new System.Drawing.Point(7, 42);
            this.lblMasterPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMasterPassword.Name = "lblMasterPassword";
            this.lblMasterPassword.Size = new System.Drawing.Size(88, 13);
            this.lblMasterPassword.TabIndex = 0;
            this.lblMasterPassword.Text = "Master Password";
            // 
            // txtMasterPassword
            // 
            this.txtMasterPassword.Location = new System.Drawing.Point(7, 57);
            this.txtMasterPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtMasterPassword.Name = "txtMasterPassword";
            this.txtMasterPassword.Size = new System.Drawing.Size(192, 20);
            this.txtMasterPassword.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtMasterPassword, "master password\r\n4 chars min");
            this.txtMasterPassword.TextChanged += new System.EventHandler(this.txtMasterPassword_TextChanged);
            this.txtMasterPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMasterPassword_KeyPress);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(7, 103);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(192, 20);
            this.txtUsername.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtUsername, "site username\r\noptional");
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(7, 88);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Location = new System.Drawing.Point(97, 181);
            this.chkUpper.Margin = new System.Windows.Forms.Padding(2);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(47, 17);
            this.chkUpper.TabIndex = 0;
            this.chkUpper.TabStop = false;
            this.chkUpper.Text = "ABC";
            this.toolTip1.SetToolTip(this.chkUpper, "password contains uppercase letters");
            this.chkUpper.UseVisualStyleBackColor = true;
            this.chkUpper.CheckedChanged += new System.EventHandler(this.chkUpper_CheckedChanged);
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Location = new System.Drawing.Point(7, 181);
            this.chkLower.Margin = new System.Windows.Forms.Padding(2);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(44, 17);
            this.chkLower.TabIndex = 0;
            this.chkLower.TabStop = false;
            this.chkLower.Text = "abc";
            this.toolTip1.SetToolTip(this.chkLower, "password contains lowercase letters");
            this.chkLower.UseVisualStyleBackColor = true;
            this.chkLower.CheckedChanged += new System.EventHandler(this.chkLower_CheckedChanged);
            // 
            // chkDigit
            // 
            this.chkDigit.AutoSize = true;
            this.chkDigit.Location = new System.Drawing.Point(51, 181);
            this.chkDigit.Margin = new System.Windows.Forms.Padding(2);
            this.chkDigit.Name = "chkDigit";
            this.chkDigit.Size = new System.Drawing.Size(44, 17);
            this.chkDigit.TabIndex = 0;
            this.chkDigit.TabStop = false;
            this.chkDigit.Text = "123";
            this.toolTip1.SetToolTip(this.chkDigit, "password contains digits");
            this.chkDigit.UseVisualStyleBackColor = true;
            this.chkDigit.CheckedChanged += new System.EventHandler(this.chkDigit_CheckedChanged);
            // 
            // chkSpeci
            // 
            this.chkSpeci.AutoSize = true;
            this.chkSpeci.Location = new System.Drawing.Point(146, 181);
            this.chkSpeci.Margin = new System.Windows.Forms.Padding(2);
            this.chkSpeci.Name = "chkSpeci";
            this.chkSpeci.Size = new System.Drawing.Size(51, 17);
            this.chkSpeci.TabIndex = 0;
            this.chkSpeci.TabStop = false;
            this.chkSpeci.Text = "@&&%";
            this.toolTip1.SetToolTip(this.chkSpeci, "password contains special characters");
            this.chkSpeci.UseVisualStyleBackColor = true;
            this.chkSpeci.CheckedChanged += new System.EventHandler(this.chkSpeci_CheckedChanged);
            // 
            // numSite
            // 
            this.numSite.Location = new System.Drawing.Point(203, 16);
            this.numSite.Margin = new System.Windows.Forms.Padding(2);
            this.numSite.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSite.Name = "numSite";
            this.numSite.Size = new System.Drawing.Size(68, 20);
            this.numSite.TabIndex = 0;
            this.numSite.TabStop = false;
            this.toolTip1.SetToolTip(this.numSite, "password version");
            this.numSite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSite.ValueChanged += new System.EventHandler(this.numSite_ValueChanged);
            this.numSite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numSite_KeyDown);
            // 
            // chkHideMaster
            // 
            this.chkHideMaster.AutoSize = true;
            this.chkHideMaster.Location = new System.Drawing.Point(203, 57);
            this.chkHideMaster.Margin = new System.Windows.Forms.Padding(2);
            this.chkHideMaster.Name = "chkHideMaster";
            this.chkHideMaster.Size = new System.Drawing.Size(48, 17);
            this.chkHideMaster.TabIndex = 0;
            this.chkHideMaster.TabStop = false;
            this.chkHideMaster.Text = "Hide";
            this.toolTip1.SetToolTip(this.chkHideMaster, "hide master password");
            this.chkHideMaster.UseVisualStyleBackColor = true;
            this.chkHideMaster.CheckedChanged += new System.EventHandler(this.chkHideMaster_CheckedChanged);
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(203, 178);
            this.numLength.Margin = new System.Windows.Forms.Padding(2);
            this.numLength.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(67, 20);
            this.numLength.TabIndex = 0;
            this.numLength.TabStop = false;
            this.toolTip1.SetToolTip(this.numLength, "password length");
            this.numLength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numLength.ValueChanged += new System.EventHandler(this.numLength_ValueChanged);
            this.numLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numLength_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtPassword.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtPassword.Location = new System.Drawing.Point(7, 148);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(192, 26);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            this.toolTip1.SetToolTip(this.txtPassword, "site password");
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 133);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(7, 16);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(192, 20);
            this.txtUser.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtUser, "user name\r\n4 chars min\r\n");
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(203, 45);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "save site");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSitePrev
            // 
            this.btnSitePrev.Location = new System.Drawing.Point(131, 45);
            this.btnSitePrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnSitePrev.Name = "btnSitePrev";
            this.btnSitePrev.Size = new System.Drawing.Size(32, 23);
            this.btnSitePrev.TabIndex = 0;
            this.btnSitePrev.TabStop = false;
            this.btnSitePrev.Text = "<";
            this.toolTip1.SetToolTip(this.btnSitePrev, "previous site");
            this.btnSitePrev.UseVisualStyleBackColor = true;
            this.btnSitePrev.Click += new System.EventHandler(this.btnSitePrev_Click);
            // 
            // btnSiteNext
            // 
            this.btnSiteNext.Location = new System.Drawing.Point(167, 45);
            this.btnSiteNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiteNext.Name = "btnSiteNext";
            this.btnSiteNext.Size = new System.Drawing.Size(32, 23);
            this.btnSiteNext.TabIndex = 0;
            this.btnSiteNext.TabStop = false;
            this.btnSiteNext.Text = ">";
            this.toolTip1.SetToolTip(this.btnSiteNext, "next site");
            this.btnSiteNext.UseVisualStyleBackColor = true;
            this.btnSiteNext.Click += new System.EventHandler(this.btnSiteNext_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 45);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnDelete, "delete site");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkHidePassword
            // 
            this.chkHidePassword.AutoSize = true;
            this.chkHidePassword.Location = new System.Drawing.Point(203, 148);
            this.chkHidePassword.Margin = new System.Windows.Forms.Padding(2);
            this.chkHidePassword.Name = "chkHidePassword";
            this.chkHidePassword.Size = new System.Drawing.Size(48, 17);
            this.chkHidePassword.TabIndex = 0;
            this.chkHidePassword.TabStop = false;
            this.chkHidePassword.Text = "Hide";
            this.toolTip1.SetToolTip(this.chkHidePassword, "hide site password");
            this.chkHidePassword.UseVisualStyleBackColor = true;
            this.chkHidePassword.CheckedChanged += new System.EventHandler(this.chkHidePassword_CheckedChanged);
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(7, 16);
            this.txtSite.Margin = new System.Windows.Forms.Padding(2);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(192, 20);
            this.txtSite.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtSite, "site name\r\n4 chars min");
            this.txtSite.TextChanged += new System.EventHandler(this.txtSite_TextChanged);
            this.txtSite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSite_KeyDown);
            this.txtSite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSite_KeyPress);
            this.txtSite.Leave += new System.EventHandler(this.txtSite_Leave);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(151, 308);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(68, 23);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "Help";
            this.toolTip1.SetToolTip(this.btnHelp, "about, donate, instructions");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // chkCtrlUP
            // 
            this.chkCtrlUP.AutoSize = true;
            this.chkCtrlUP.Location = new System.Drawing.Point(203, 103);
            this.chkCtrlUP.Margin = new System.Windows.Forms.Padding(2);
            this.chkCtrlUP.Name = "chkCtrlUP";
            this.chkCtrlUP.Size = new System.Drawing.Size(77, 17);
            this.chkCtrlUP.TabIndex = 18;
            this.chkCtrlUP.TabStop = false;
            this.chkCtrlUP.Text = "CTRL-U/P";
            this.toolTip1.SetToolTip(this.chkCtrlUP, "CTRL-U and CTRL-P\r\nenters username and password\r\nto site authentification request" +
        "er");
            this.chkCtrlUP.UseVisualStyleBackColor = true;
            this.chkCtrlUP.CheckedChanged += new System.EventHandler(this.chkCtrlUP_CheckedChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(223, 308);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(68, 23);
            this.btnQuit.TabIndex = 20;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "Quit";
            this.toolTip1.SetToolTip(this.btnQuit, "save site");
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.txtUser);
            this.grpUser.Controls.Add(this.lblMasterPassword);
            this.grpUser.Controls.Add(this.txtMasterPassword);
            this.grpUser.Controls.Add(this.chkHideMaster);
            this.grpUser.Location = new System.Drawing.Point(8, 8);
            this.grpUser.Margin = new System.Windows.Forms.Padding(2);
            this.grpUser.Name = "grpUser";
            this.grpUser.Padding = new System.Windows.Forms.Padding(2);
            this.grpUser.Size = new System.Drawing.Size(283, 86);
            this.grpUser.TabIndex = 19;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "User";
            // 
            // grpSite
            // 
            this.grpSite.Controls.Add(this.chkCtrlUP);
            this.grpSite.Controls.Add(this.lblSiteCompleter);
            this.grpSite.Controls.Add(this.txtSite);
            this.grpSite.Controls.Add(this.chkHidePassword);
            this.grpSite.Controls.Add(this.btnDelete);
            this.grpSite.Controls.Add(this.txtUsername);
            this.grpSite.Controls.Add(this.btnSiteNext);
            this.grpSite.Controls.Add(this.btnSitePrev);
            this.grpSite.Controls.Add(this.lblUsername);
            this.grpSite.Controls.Add(this.btnSave);
            this.grpSite.Controls.Add(this.txtPassword);
            this.grpSite.Controls.Add(this.lblPassword);
            this.grpSite.Controls.Add(this.chkUpper);
            this.grpSite.Controls.Add(this.numLength);
            this.grpSite.Controls.Add(this.chkLower);
            this.grpSite.Controls.Add(this.numSite);
            this.grpSite.Controls.Add(this.chkDigit);
            this.grpSite.Controls.Add(this.chkSpeci);
            this.grpSite.Location = new System.Drawing.Point(8, 98);
            this.grpSite.Margin = new System.Windows.Forms.Padding(2);
            this.grpSite.Name = "grpSite";
            this.grpSite.Padding = new System.Windows.Forms.Padding(2);
            this.grpSite.Size = new System.Drawing.Size(283, 206);
            this.grpSite.TabIndex = 20;
            this.grpSite.TabStop = false;
            this.grpSite.Text = "Site";
            // 
            // lblSiteCompleter
            // 
            this.lblSiteCompleter.AutoSize = true;
            this.lblSiteCompleter.BackColor = System.Drawing.SystemColors.Window;
            this.lblSiteCompleter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteCompleter.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSiteCompleter.Location = new System.Drawing.Point(143, 20);
            this.lblSiteCompleter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiteCompleter.Name = "lblSiteCompleter";
            this.lblSiteCompleter.Size = new System.Drawing.Size(53, 13);
            this.lblSiteCompleter.TabIndex = 0;
            this.lblSiteCompleter.Text = "completer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 336);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.grpSite);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.grpUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "SafeLess V1.0b";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.grpSite.ResumeLayout(false);
            this.grpSite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMasterPassword;
        private System.Windows.Forms.TextBox txtMasterPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkDigit;
        private System.Windows.Forms.CheckBox chkSpeci;
        private System.Windows.Forms.NumericUpDown numSite;
        private System.Windows.Forms.CheckBox chkHideMaster;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSitePrev;
        private System.Windows.Forms.Button btnSiteNext;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.GroupBox grpSite;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkHidePassword;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label lblSiteCompleter;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckBox chkCtrlUP;
        private System.Windows.Forms.Button btnQuit;
    }
}

