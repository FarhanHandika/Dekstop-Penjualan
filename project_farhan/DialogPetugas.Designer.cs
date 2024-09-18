
namespace project_farhan
{
    partial class DialogPetugas
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnama = new System.Windows.Forms.Label();
            this.lblalamat = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblhak = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.rchtxtalmt = new System.Windows.Forms.RichTextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonsimpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrasi Petugas Baru";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(1, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 2);
            this.panel1.TabIndex = 1;
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnama.Location = new System.Drawing.Point(34, 64);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(39, 15);
            this.lblnama.TabIndex = 2;
            this.lblnama.Text = "Nama";
            // 
            // lblalamat
            // 
            this.lblalamat.AutoSize = true;
            this.lblalamat.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalamat.Location = new System.Drawing.Point(34, 85);
            this.lblalamat.Name = "lblalamat";
            this.lblalamat.Size = new System.Drawing.Size(47, 15);
            this.lblalamat.TabIndex = 3;
            this.lblalamat.Text = "Alamat";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(34, 236);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(62, 15);
            this.lblpass.TabIndex = 4;
            this.lblpass.Text = "Password";
            // 
            // lblhak
            // 
            this.lblhak.AutoSize = true;
            this.lblhak.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhak.Location = new System.Drawing.Point(34, 271);
            this.lblhak.Name = "lblhak";
            this.lblhak.Size = new System.Drawing.Size(31, 15);
            this.lblhak.TabIndex = 5;
            this.lblhak.Text = "Hak";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(107, 59);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(254, 20);
            this.txtnama.TabIndex = 6;
            // 
            // rchtxtalmt
            // 
            this.rchtxtalmt.Location = new System.Drawing.Point(107, 92);
            this.rchtxtalmt.Name = "rchtxtalmt";
            this.rchtxtalmt.Size = new System.Drawing.Size(254, 138);
            this.rchtxtalmt.TabIndex = 7;
            this.rchtxtalmt.Text = "";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(107, 236);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(254, 20);
            this.txtpass.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(37, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsimpan
            // 
            this.buttonsimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.buttonsimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonsimpan.Location = new System.Drawing.Point(341, 341);
            this.buttonsimpan.Name = "buttonsimpan";
            this.buttonsimpan.Size = new System.Drawing.Size(75, 33);
            this.buttonsimpan.TabIndex = 11;
            this.buttonsimpan.Text = "Simpan";
            this.buttonsimpan.UseVisualStyleBackColor = false;
            this.buttonsimpan.Click += new System.EventHandler(this.buttonsimpan_Click);
            // 
            // DialogPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(438, 386);
            this.Controls.Add(this.buttonsimpan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.rchtxtalmt);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.lblhak);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblalamat);
            this.Controls.Add(this.lblnama);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "DialogPetugas";
            this.Text = "DialogPetugas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.Label lblalamat;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblhak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonsimpan;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtnama;
        public System.Windows.Forms.RichTextBox rchtxtalmt;
        public System.Windows.Forms.TextBox txtpass;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}