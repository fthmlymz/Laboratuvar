namespace MikroAnaliz
{
    partial class frm_Borclar
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
            this.BorcBilgileriUser = new MikroAnaliz.Usr_Borclar();
            this.SuspendLayout();
            // 
            // BorcBilgileriUser
            // 
            this.BorcBilgileriUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorcBilgileriUser.Location = new System.Drawing.Point(0, 0);
            this.BorcBilgileriUser.Name = "BorcBilgileriUser";
            this.BorcBilgileriUser.Size = new System.Drawing.Size(615, 385);
            this.BorcBilgileriUser.TabIndex = 0;
            // 
            // frmBorclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 385);
            this.Controls.Add(this.BorcBilgileriUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBorclar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borç Bilgileri";
            this.ResumeLayout(false);

        }

        #endregion

        public Usr_Borclar BorcBilgileriUser;

    }
}