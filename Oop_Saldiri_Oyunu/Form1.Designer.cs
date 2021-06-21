
namespace Oop_Saldiri_Oyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtOyuncuAdi = new DevExpress.XtraEditors.TextEdit();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaldir = new DevExpress.XtraEditors.SimpleButton();
            this.lblDusmanCani = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbOyuncuIrk = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbOyuncuBrans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbOyuncuSilah = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOyuncuAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOyuncuIrk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOyuncuBrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOyuncuSilah.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOyuncuAdi
            // 
            this.txtOyuncuAdi.Location = new System.Drawing.Point(127, 12);
            this.txtOyuncuAdi.Name = "txtOyuncuAdi";
            this.txtOyuncuAdi.Size = new System.Drawing.Size(100, 20);
            this.txtOyuncuAdi.TabIndex = 0;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(279, 25);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 23);
            this.btnSec.TabIndex = 4;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnSaldir
            // 
            this.btnSaldir.Location = new System.Drawing.Point(152, 137);
            this.btnSaldir.Name = "btnSaldir";
            this.btnSaldir.Size = new System.Drawing.Size(75, 23);
            this.btnSaldir.TabIndex = 5;
            this.btnSaldir.Text = "Saldır";
            this.btnSaldir.Click += new System.EventHandler(this.btnSaldir_Click);
            // 
            // lblDusmanCani
            // 
            this.lblDusmanCani.Appearance.BackColor = System.Drawing.Color.DarkRed;
            this.lblDusmanCani.Appearance.Options.UseBackColor = true;
            this.lblDusmanCani.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDusmanCani.Location = new System.Drawing.Point(469, 25);
            this.lblDusmanCani.Name = "lblDusmanCani";
            this.lblDusmanCani.Size = new System.Drawing.Size(300, 30);
            this.lblDusmanCani.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(469, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Oyuncu İsmi:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Irk:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Brans:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(31, 93);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Silah:";
            // 
            // cmbOyuncuIrk
            // 
            this.cmbOyuncuIrk.Location = new System.Drawing.Point(127, 38);
            this.cmbOyuncuIrk.Name = "cmbOyuncuIrk";
            this.cmbOyuncuIrk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOyuncuIrk.Size = new System.Drawing.Size(100, 20);
            this.cmbOyuncuIrk.TabIndex = 14;
            // 
            // cmbOyuncuBrans
            // 
            this.cmbOyuncuBrans.Location = new System.Drawing.Point(127, 64);
            this.cmbOyuncuBrans.Name = "cmbOyuncuBrans";
            this.cmbOyuncuBrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOyuncuBrans.Size = new System.Drawing.Size(100, 20);
            this.cmbOyuncuBrans.TabIndex = 15;
            // 
            // cmbOyuncuSilah
            // 
            this.cmbOyuncuSilah.Location = new System.Drawing.Point(127, 90);
            this.cmbOyuncuSilah.Name = "cmbOyuncuSilah";
            this.cmbOyuncuSilah.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOyuncuSilah.Size = new System.Drawing.Size(100, 20);
            this.cmbOyuncuSilah.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 192);
            this.Controls.Add(this.cmbOyuncuSilah);
            this.Controls.Add(this.cmbOyuncuBrans);
            this.Controls.Add(this.cmbOyuncuIrk);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDusmanCani);
            this.Controls.Add(this.btnSaldir);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.txtOyuncuAdi);
            this.Name = "Form1";
            this.Text = "Saldırı Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOyuncuAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOyuncuIrk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOyuncuBrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOyuncuSilah.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtOyuncuAdi;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.SimpleButton btnSaldir;
        private DevExpress.XtraEditors.LabelControl lblDusmanCani;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbOyuncuIrk;
        private DevExpress.XtraEditors.ComboBoxEdit cmbOyuncuBrans;
        private DevExpress.XtraEditors.ComboBoxEdit cmbOyuncuSilah;
    }
}

