namespace MikroAnaliz.VeritabaniIslemler
{
    partial class frmVeritabaniGuncelleme
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
            this.btnVeritabaniGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.lstSpisimleri = new DevExpress.XtraEditors.ListBoxControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lstSpisimleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVeritabaniGuncelle
            // 
            this.btnVeritabaniGuncelle.Location = new System.Drawing.Point(57, 31);
            this.btnVeritabaniGuncelle.Name = "btnVeritabaniGuncelle";
            this.btnVeritabaniGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnVeritabaniGuncelle.TabIndex = 0;
            this.btnVeritabaniGuncelle.Text = "Konrol Et";
            this.btnVeritabaniGuncelle.Click += new System.EventHandler(this.btnVeritabaniGuncelle_Click);
            // 
            // lstSpisimleri
            // 
            this.lstSpisimleri.Location = new System.Drawing.Point(12, 257);
            this.lstSpisimleri.Name = "lstSpisimleri";
            this.lstSpisimleri.Size = new System.Drawing.Size(120, 95);
            this.lstSpisimleri.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(709, 367);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Konrol Et";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(594, 370);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 229);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "SP LIST";
            // 
            // frmVeritabaniGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 458);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.lstSpisimleri);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnVeritabaniGuncelle);
            this.Name = "frmVeritabaniGuncelleme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Güncelleme İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.lstSpisimleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnVeritabaniGuncelle;
        private DevExpress.XtraEditors.ListBoxControl lstSpisimleri;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}