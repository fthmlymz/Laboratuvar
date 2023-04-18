namespace MikroAnaliz
{
    partial class frm_Login
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.loginControl1 = new MikroAnaliz.Usr_Login();
            this.SuspendLayout();
            // 
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.Color.LightSlateGray;
            this.loginControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginControl1.BackgroundImage")));
            this.loginControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginControl1.Kul_Id = 0;
            this.loginControl1.Location = new System.Drawing.Point(0, 0);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.odakodu = "";
            this.loginControl1.PassWord = "";
            this.loginControl1.Size = new System.Drawing.Size(549, 396);
            this.loginControl1.TabIndex = 0;
            this.loginControl1.UserName = "";
            this.loginControl1.LoginSuccess += new System.EventHandler(this.loginControl1_LoginSuccess);
            this.loginControl1.LoginFail += new System.EventHandler(this.loginControl1_LoginFail);
            // 
            // GirisKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 396);
            this.Controls.Add(this.loginControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisKontrolu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisKontrolu";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GirisKontrolu_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        public Usr_Login loginControl1;


    }
}