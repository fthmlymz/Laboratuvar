namespace MikroAnaliz
{
    partial class frm_Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Database));
            this.SunuCular = new DevExpress.XtraEditors.ComboBoxEdit();
            this.VeriTabanlari = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboServer = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textKulAdi = new DevExpress.XtraEditors.TextEdit();
            this.textSifre = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.SunuCular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeriTabanlari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKulAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SunuCular
            // 
            this.SunuCular.Location = new System.Drawing.Point(38, 19);
            this.SunuCular.Name = "SunuCular";
            this.SunuCular.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SunuCular.Size = new System.Drawing.Size(137, 20);
            this.SunuCular.TabIndex = 1;
            this.SunuCular.Visible = false;
            this.SunuCular.Enter += new System.EventHandler(this.SunuCular_Enter);
            // 
            // VeriTabanlari
            // 
            this.VeriTabanlari.Location = new System.Drawing.Point(66, 29);
            this.VeriTabanlari.Name = "VeriTabanlari";
            this.VeriTabanlari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VeriTabanlari.Size = new System.Drawing.Size(113, 20);
            this.VeriTabanlari.TabIndex = 4;
            this.VeriTabanlari.Enter += new System.EventHandler(this.VeriTabanlari_Enter);
            // 
            // comboServer
            // 
            this.comboServer.FormattingEnabled = true;
            this.comboServer.Location = new System.Drawing.Point(38, 18);
            this.comboServer.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.comboServer.Name = "comboServer";
            this.comboServer.Size = new System.Drawing.Size(189, 21);
            this.comboServer.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "IP";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Database";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkEdit2);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Location = new System.Drawing.Point(18, 45);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(209, 67);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Şifreleme Sistemi";
            // 
            // checkEdit2
            // 
            this.checkEdit2.EditValue = null;
            this.checkEdit2.Location = new System.Drawing.Point(18, 43);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "SQL şifresi ile doğrulama";
            this.checkEdit2.Properties.RadioGroupIndex = 1;
            this.checkEdit2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkEdit2.Size = new System.Drawing.Size(139, 19);
            this.checkEdit2.TabIndex = 1;
            this.checkEdit2.TabStop = false;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(18, 24);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Windows doğrulama";
            this.checkEdit1.Properties.RadioGroupIndex = 1;
            this.checkEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkEdit1.Size = new System.Drawing.Size(118, 19);
            this.checkEdit1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Enabled = false;
            this.labelControl4.Location = new System.Drawing.Point(10, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Şifresi";
            // 
            // labelControl3
            // 
            this.labelControl3.Enabled = false;
            this.labelControl3.Location = new System.Drawing.Point(10, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Kullanıcı Adı";
            // 
            // textKulAdi
            // 
            this.textKulAdi.Enabled = false;
            this.textKulAdi.Location = new System.Drawing.Point(71, 26);
            this.textKulAdi.Name = "textKulAdi";
            this.textKulAdi.Size = new System.Drawing.Size(108, 20);
            this.textKulAdi.TabIndex = 10;
            // 
            // textSifre
            // 
            this.textSifre.Enabled = false;
            this.textSifre.Location = new System.Drawing.Point(71, 47);
            this.textSifre.Name = "textSifre";
            this.textSifre.Properties.PasswordChar = '*';
            this.textSifre.Size = new System.Drawing.Size(108, 20);
            this.textSifre.TabIndex = 11;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(18, 264);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(209, 30);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.textKulAdi);
            this.groupControl2.Controls.Add(this.textSifre);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Location = new System.Drawing.Point(18, 118);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(209, 80);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Kullanıcı";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.VeriTabanlari);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Location = new System.Drawing.Point(18, 204);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(209, 54);
            this.groupControl3.TabIndex = 14;
            this.groupControl3.Text = "Veritabanı";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(240, 332);
            this.xtraTabControl1.TabIndex = 15;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Controls.Add(this.groupControl3);
            this.xtraTabPage1.Controls.Add(this.SunuCular);
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.Controls.Add(this.comboServer);
            this.xtraTabPage1.Controls.Add(this.simpleButton1);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(235, 306);
            this.xtraTabPage1.Text = "Bağlantı Bilgileri";
            // 
            // frm_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 332);
            this.Controls.Add(this.xtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Database";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağlantı Yöneticisi";
            this.Load += new System.EventHandler(this.formVeriTabaniTanimalama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SunuCular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeriTabanlari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKulAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit SunuCular;
        private DevExpress.XtraEditors.ComboBoxEdit VeriTabanlari;
        private System.Windows.Forms.ComboBox comboServer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textKulAdi;
        private DevExpress.XtraEditors.TextEdit textSifre;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
    }
}