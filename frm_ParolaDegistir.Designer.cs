namespace MikroAnaliz
{
    partial class frm_ParolaDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ParolaDegistir));
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkuladi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUyeSifreDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.txtyeniParolaTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidsi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(112, 38);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(100, 20);
            this.txtsifre.TabIndex = 1;
            // 
            // txtkuladi
            // 
            this.txtkuladi.Enabled = false;
            this.txtkuladi.Location = new System.Drawing.Point(112, 15);
            this.txtkuladi.Name = "txtkuladi";
            this.txtkuladi.Size = new System.Drawing.Size(100, 20);
            this.txtkuladi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni Parola";
            // 
            // btnUyeSifreDegistir
            // 
            this.btnUyeSifreDegistir.Location = new System.Drawing.Point(112, 90);
            this.btnUyeSifreDegistir.Name = "btnUyeSifreDegistir";
            this.btnUyeSifreDegistir.Size = new System.Drawing.Size(99, 23);
            this.btnUyeSifreDegistir.TabIndex = 3;
            this.btnUyeSifreDegistir.Text = "Değiştir";
            this.btnUyeSifreDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // txtyeniParolaTekrar
            // 
            this.txtyeniParolaTekrar.Location = new System.Drawing.Point(112, 60);
            this.txtyeniParolaTekrar.Name = "txtyeniParolaTekrar";
            this.txtyeniParolaTekrar.PasswordChar = '*';
            this.txtyeniParolaTekrar.Size = new System.Drawing.Size(100, 20);
            this.txtyeniParolaTekrar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yeni Parola Tekrar";
            // 
            // txtidsi
            // 
            this.txtidsi.Location = new System.Drawing.Point(12, 93);
            this.txtidsi.Name = "txtidsi";
            this.txtidsi.Size = new System.Drawing.Size(100, 20);
            this.txtidsi.TabIndex = 2;
            // 
            // frm_ParolaDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 127);
            this.Controls.Add(this.btnUyeSifreDegistir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkuladi);
            this.Controls.Add(this.txtidsi);
            this.Controls.Add(this.txtyeniParolaTekrar);
            this.Controls.Add(this.txtsifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ParolaDegistir";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştir";
            this.Load += new System.EventHandler(this.sifredegistir_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ParolaDegistir_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkuladi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnUyeSifreDegistir;
        private System.Windows.Forms.TextBox txtyeniParolaTekrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidsi;
    }
}