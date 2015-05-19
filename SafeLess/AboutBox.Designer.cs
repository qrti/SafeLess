namespace SafeLess
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.rtbHelp = new SafeLess.MyRichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lnkHome = new System.Windows.Forms.LinkLabel();
            this.lnkDonate = new System.Windows.Forms.LinkLabel();
            this.pibPayPal = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibPayPal)).BeginInit();
            this.SuspendLayout();
            // 
            // pibLogo
            // 
            this.pibLogo.Image = ((System.Drawing.Image)(resources.GetObject("pibLogo.Image")));
            this.pibLogo.Location = new System.Drawing.Point(3, 12);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(127, 331);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibLogo.TabIndex = 13;
            this.pibLogo.TabStop = false;
            this.pibLogo.Click += new System.EventHandler(this.pibLogo_Click);
            // 
            // rtbHelp
            // 
            this.rtbHelp.Location = new System.Drawing.Point(142, 128);
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.Size = new System.Drawing.Size(452, 215);
            this.rtbHelp.TabIndex = 14;
            this.rtbHelp.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(139, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblTitle.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 17);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "SafeLess V1.0b";
            // 
            // lnkHome
            // 
            this.lnkHome.AutoSize = true;
            this.lnkHome.Location = new System.Drawing.Point(139, 52);
            this.lnkHome.Margin = new System.Windows.Forms.Padding(6, 0, 2, 0);
            this.lnkHome.Name = "lnkHome";
            this.lnkHome.Size = new System.Drawing.Size(54, 13);
            this.lnkHome.TabIndex = 30;
            this.lnkHome.TabStop = true;
            this.lnkHome.Text = "QLand.de";
            this.lnkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHome_LinkClicked);
            // 
            // lnkDonate
            // 
            this.lnkDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDonate.Location = new System.Drawing.Point(139, 76);
            this.lnkDonate.Margin = new System.Windows.Forms.Padding(6, 0, 2, 0);
            this.lnkDonate.Name = "lnkDonate";
            this.lnkDonate.Size = new System.Drawing.Size(171, 26);
            this.lnkDonate.TabIndex = 31;
            this.lnkDonate.TabStop = true;
            this.lnkDonate.Text = "Donate via PayPal";
            this.lnkDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDonate_LinkClicked);
            // 
            // pibPayPal
            // 
            this.pibPayPal.Image = ((System.Drawing.Image)(resources.GetObject("pibPayPal.Image")));
            this.pibPayPal.Location = new System.Drawing.Point(315, 61);
            this.pibPayPal.Name = "pibPayPal";
            this.pibPayPal.Size = new System.Drawing.Size(110, 41);
            this.pibPayPal.TabIndex = 32;
            this.pibPayPal.TabStop = false;
            this.pibPayPal.Click += new System.EventHandler(this.pibPayPal_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(517, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(77, 22);
            this.btnOk.TabIndex = 33;
            this.btnOk.Text = "&OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(139, 29);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblSubtitle.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(145, 13);
            this.lblSubtitle.TabIndex = 35;
            this.lblSubtitle.Text = "Safe Passwords without Safe";
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 349);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pibPayPal);
            this.Controls.Add(this.lnkDonate);
            this.Controls.Add(this.lnkHome);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtbHelp);
            this.Controls.Add(this.pibLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibPayPal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private MyRichTextBox rtbHelp;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel lnkHome;
        private System.Windows.Forms.LinkLabel lnkDonate;
        private System.Windows.Forms.PictureBox pibPayPal;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSubtitle;

    }
}
