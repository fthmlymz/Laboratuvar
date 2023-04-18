namespace MikroAnaliz
{
    partial class Usr_Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OdaKodu = new DevExpress.XtraEditors.TextEdit();
            this.KullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.KullaniciSifresi = new DevExpress.XtraEditors.TextEdit();
            this.Hatirla = new DevExpress.XtraEditors.CheckEdit();
            this.loginerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.OdaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciSifresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hatirla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginerror)).BeginInit();
            this.SuspendLayout();
            // 
            // OdaKodu
            // 
            this.OdaKodu.EditValue = "";
            this.OdaKodu.EnterMoveNextControl = true;
            this.OdaKodu.Location = new System.Drawing.Point(195, 188);
            this.OdaKodu.Name = "OdaKodu";
            this.OdaKodu.Size = new System.Drawing.Size(168, 20);
            this.OdaKodu.TabIndex = 0;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.EditValue = "";
            this.KullaniciAdi.EnterMoveNextControl = true;
            this.KullaniciAdi.Location = new System.Drawing.Point(195, 218);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(168, 20);
            this.KullaniciAdi.TabIndex = 1;
            // 
            // KullaniciSifresi
            // 
            this.KullaniciSifresi.EditValue = "";
            this.KullaniciSifresi.EnterMoveNextControl = true;
            this.KullaniciSifresi.Location = new System.Drawing.Point(195, 249);
            this.KullaniciSifresi.Name = "KullaniciSifresi";
            this.KullaniciSifresi.Properties.PasswordChar = '*';
            this.KullaniciSifresi.Size = new System.Drawing.Size(168, 20);
            this.KullaniciSifresi.TabIndex = 2;
            // 
            // Hatirla
            // 
            this.Hatirla.Location = new System.Drawing.Point(193, 275);
            this.Hatirla.Name = "Hatirla";
            this.Hatirla.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Hatirla.Properties.Appearance.Options.UseForeColor = true;
            this.Hatirla.Properties.Caption = "Beni anýmsa";
            this.Hatirla.Size = new System.Drawing.Size(170, 19);
            this.Hatirla.TabIndex = 4;
            // 
            // loginerror
            // 
            this.loginerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.loginerror.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            this.label4.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnKapat.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.btnKapat.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnKapat.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKapat.Appearance.Options.UseBackColor = true;
            this.btnKapat.Appearance.Options.UseBorderColor = true;
            this.btnKapat.Appearance.Options.UseForeColor = true;
            this.btnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnKapat.Location = new System.Drawing.Point(528, -1);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(21, 19);
            this.btnKapat.TabIndex = 29;
            this.btnKapat.Text = "X";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGir
            // 
            this.btnGir.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGir.Appearance.Options.UseFont = true;
            this.btnGir.Location = new System.Drawing.Point(383, 232);
            this.btnGir.Name = "btnGir";
            this.btnGir.Size = new System.Drawing.Size(96, 37);
            this.btnGir.TabIndex = 3;
            this.btnGir.Text = "Giriþ";
            this.btnGir.Click += new System.EventHandler(this.btnGir_Click);
            // 
            // Usr_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::MikroAnaliz.Properties.Resources.loginmode;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGir);
            this.Controls.Add(this.Hatirla);
            this.Controls.Add(this.OdaKodu);
            this.Controls.Add(this.KullaniciAdi);
            this.Controls.Add(this.KullaniciSifresi);
            this.Name = "Usr_Login";
            this.Size = new System.Drawing.Size(549, 396);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OdaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciSifresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hatirla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginerror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider loginerror;
        private DevExpress.XtraEditors.TextEdit OdaKodu;
        private DevExpress.XtraEditors.TextEdit KullaniciSifresi;
        private DevExpress.XtraEditors.TextEdit KullaniciAdi;
        private DevExpress.XtraEditors.CheckEdit Hatirla;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGir;
        private System.Windows.Forms.Label label4;
    }
}
