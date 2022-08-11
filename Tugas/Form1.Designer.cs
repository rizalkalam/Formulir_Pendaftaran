
namespace Tugas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblNoPendaftaran = new System.Windows.Forms.Label();
            this.lblNamaLengkap = new System.Windows.Forms.Label();
            this.lblAlamatLengkap = new System.Windows.Forms.Label();
            this.lblNoHPWA = new System.Windows.Forms.Label();
            this.lblJenisKelamin = new System.Windows.Forms.Label();
            this.lblTempatLahir = new System.Windows.Forms.Label();
            this.lblAlamatEmail = new System.Windows.Forms.Label();
            this.lblTglDaftar = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.checkBoxPerempuan = new System.Windows.Forms.CheckBox();
            this.checkBoxLaki2 = new System.Windows.Forms.CheckBox();
            this.bxThn = new System.Windows.Forms.ComboBox();
            this.bxBln = new System.Windows.Forms.ComboBox();
            this.bxTgl = new System.Windows.Forms.ComboBox();
            this.txtAlamatLengkap = new System.Windows.Forms.TextBox();
            this.txtAlamatEmail = new System.Windows.Forms.TextBox();
            this.txtTempatLahir = new System.Windows.Forms.TextBox();
            this.txtNoHPWA = new System.Windows.Forms.TextBox();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.txtNoPendaftaran = new System.Windows.Forms.TextBox();
            this.lblTglLahir = new System.Windows.Forms.Label();
            this.gBoxDataPendaftar = new System.Windows.Forms.GroupBox();
            this.txtTglDaftar = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gBoxDataPendaftar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            resources.ApplyResources(this.lblJudul, "lblJudul");
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNoPendaftaran
            // 
            resources.ApplyResources(this.lblNoPendaftaran, "lblNoPendaftaran");
            this.lblNoPendaftaran.Name = "lblNoPendaftaran";
            // 
            // lblNamaLengkap
            // 
            resources.ApplyResources(this.lblNamaLengkap, "lblNamaLengkap");
            this.lblNamaLengkap.Name = "lblNamaLengkap";
            this.lblNamaLengkap.Click += new System.EventHandler(this.lblNamaLengkap_Click);
            // 
            // lblAlamatLengkap
            // 
            resources.ApplyResources(this.lblAlamatLengkap, "lblAlamatLengkap");
            this.lblAlamatLengkap.Name = "lblAlamatLengkap";
            this.lblAlamatLengkap.Click += new System.EventHandler(this.lblNamaLengkap_Click);
            // 
            // lblNoHPWA
            // 
            resources.ApplyResources(this.lblNoHPWA, "lblNoHPWA");
            this.lblNoHPWA.Name = "lblNoHPWA";
            this.lblNoHPWA.Click += new System.EventHandler(this.lblNamaLengkap_Click);
            // 
            // lblJenisKelamin
            // 
            resources.ApplyResources(this.lblJenisKelamin, "lblJenisKelamin");
            this.lblJenisKelamin.Name = "lblJenisKelamin";
            this.lblJenisKelamin.Click += new System.EventHandler(this.lblNamaLengkap_Click);
            // 
            // lblTempatLahir
            // 
            resources.ApplyResources(this.lblTempatLahir, "lblTempatLahir");
            this.lblTempatLahir.Name = "lblTempatLahir";
            this.lblTempatLahir.Click += new System.EventHandler(this.lblNamaLengkap_Click);
            // 
            // lblAlamatEmail
            // 
            resources.ApplyResources(this.lblAlamatEmail, "lblAlamatEmail");
            this.lblAlamatEmail.Name = "lblAlamatEmail";
            this.lblAlamatEmail.Click += new System.EventHandler(this.lblNamaLengkap_Click);
            // 
            // lblTglDaftar
            // 
            resources.ApplyResources(this.lblTglDaftar, "lblTglDaftar");
            this.lblTglDaftar.Name = "lblTglDaftar";
            this.lblTglDaftar.Click += new System.EventHandler(this.lblNamaLengkap_Click);
            // 
            // lblData
            // 
            resources.ApplyResources(this.lblData, "lblData");
            this.lblData.Name = "lblData";
            this.lblData.Click += new System.EventHandler(this.lblNamaLengkap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnDaftar);
            this.groupBox1.Controls.Add(this.checkBoxPerempuan);
            this.groupBox1.Controls.Add(this.checkBoxLaki2);
            this.groupBox1.Controls.Add(this.bxThn);
            this.groupBox1.Controls.Add(this.bxBln);
            this.groupBox1.Controls.Add(this.bxTgl);
            this.groupBox1.Controls.Add(this.txtAlamatLengkap);
            this.groupBox1.Controls.Add(this.txtAlamatEmail);
            this.groupBox1.Controls.Add(this.txtTempatLahir);
            this.groupBox1.Controls.Add(this.txtNoHPWA);
            this.groupBox1.Controls.Add(this.txtNamaLengkap);
            this.groupBox1.Controls.Add(this.txtNoPendaftaran);
            this.groupBox1.Controls.Add(this.lblAlamatEmail);
            this.groupBox1.Controls.Add(this.lblTglLahir);
            this.groupBox1.Controls.Add(this.lblTempatLahir);
            this.groupBox1.Controls.Add(this.lblJenisKelamin);
            this.groupBox1.Controls.Add(this.lblNoHPWA);
            this.groupBox1.Controls.Add(this.lblAlamatLengkap);
            this.groupBox1.Controls.Add(this.lblNamaLengkap);
            this.groupBox1.Controls.Add(this.lblNoPendaftaran);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDaftar
            // 
            resources.ApplyResources(this.btnDaftar, "btnDaftar");
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.UseVisualStyleBackColor = true;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // checkBoxPerempuan
            // 
            resources.ApplyResources(this.checkBoxPerempuan, "checkBoxPerempuan");
            this.checkBoxPerempuan.Name = "checkBoxPerempuan";
            this.checkBoxPerempuan.UseVisualStyleBackColor = true;
            // 
            // checkBoxLaki2
            // 
            resources.ApplyResources(this.checkBoxLaki2, "checkBoxLaki2");
            this.checkBoxLaki2.Name = "checkBoxLaki2";
            this.checkBoxLaki2.UseVisualStyleBackColor = true;
            // 
            // bxThn
            // 
            this.bxThn.FormattingEnabled = true;
            resources.ApplyResources(this.bxThn, "bxThn");
            this.bxThn.Name = "bxThn";
            // 
            // bxBln
            // 
            this.bxBln.FormattingEnabled = true;
            resources.ApplyResources(this.bxBln, "bxBln");
            this.bxBln.Name = "bxBln";
            // 
            // bxTgl
            // 
            this.bxTgl.FormattingEnabled = true;
            resources.ApplyResources(this.bxTgl, "bxTgl");
            this.bxTgl.Name = "bxTgl";
            // 
            // txtAlamatLengkap
            // 
            resources.ApplyResources(this.txtAlamatLengkap, "txtAlamatLengkap");
            this.txtAlamatLengkap.Name = "txtAlamatLengkap";
            // 
            // txtAlamatEmail
            // 
            resources.ApplyResources(this.txtAlamatEmail, "txtAlamatEmail");
            this.txtAlamatEmail.Name = "txtAlamatEmail";
            // 
            // txtTempatLahir
            // 
            resources.ApplyResources(this.txtTempatLahir, "txtTempatLahir");
            this.txtTempatLahir.Name = "txtTempatLahir";
            // 
            // txtNoHPWA
            // 
            resources.ApplyResources(this.txtNoHPWA, "txtNoHPWA");
            this.txtNoHPWA.Name = "txtNoHPWA";
            // 
            // txtNamaLengkap
            // 
            resources.ApplyResources(this.txtNamaLengkap, "txtNamaLengkap");
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            // 
            // txtNoPendaftaran
            // 
            resources.ApplyResources(this.txtNoPendaftaran, "txtNoPendaftaran");
            this.txtNoPendaftaran.Name = "txtNoPendaftaran";
            // 
            // lblTglLahir
            // 
            resources.ApplyResources(this.lblTglLahir, "lblTglLahir");
            this.lblTglLahir.Name = "lblTglLahir";
            this.lblTglLahir.Click += new System.EventHandler(this.lblNamaLengkap_Click);
            // 
            // gBoxDataPendaftar
            // 
            this.gBoxDataPendaftar.Controls.Add(this.lblData);
            resources.ApplyResources(this.gBoxDataPendaftar, "gBoxDataPendaftar");
            this.gBoxDataPendaftar.Name = "gBoxDataPendaftar";
            this.gBoxDataPendaftar.TabStop = false;
            this.gBoxDataPendaftar.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtTglDaftar
            // 
            resources.ApplyResources(this.txtTglDaftar, "txtTglDaftar");
            this.txtTglDaftar.Name = "txtTglDaftar";
            // 
            // monthCalendar1
            // 
            resources.ApplyResources(this.monthCalendar1, "monthCalendar1");
            this.monthCalendar1.Name = "monthCalendar1";
            // 
            // btnShow
            // 
            resources.ApplyResources(this.btnShow, "btnShow");
            this.btnShow.Name = "btnShow";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            resources.ApplyResources(this.btnHide, "btnHide");
            this.btnHide.Name = "btnHide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.gBoxDataPendaftar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTglDaftar);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.txtTglDaftar);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxDataPendaftar.ResumeLayout(false);
            this.gBoxDataPendaftar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblNoPendaftaran;
        private System.Windows.Forms.Label lblNamaLengkap;
        private System.Windows.Forms.Label lblAlamatLengkap;
        private System.Windows.Forms.Label lblNoHPWA;
        private System.Windows.Forms.Label lblJenisKelamin;
        private System.Windows.Forms.Label lblTempatLahir;
        private System.Windows.Forms.Label lblAlamatEmail;
        private System.Windows.Forms.Label lblTglDaftar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gBoxDataPendaftar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.CheckBox checkBoxPerempuan;
        private System.Windows.Forms.CheckBox checkBoxLaki2;
        private System.Windows.Forms.ComboBox bxThn;
        private System.Windows.Forms.ComboBox bxBln;
        private System.Windows.Forms.ComboBox bxTgl;
        private System.Windows.Forms.TextBox txtAlamatLengkap;
        private System.Windows.Forms.TextBox txtAlamatEmail;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.TextBox txtNoHPWA;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.TextBox txtNoPendaftaran;
        private System.Windows.Forms.Label lblTglLahir;
        private System.Windows.Forms.TextBox txtTglDaftar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
    }
}

