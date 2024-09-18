
namespace project_farhan
{
    partial class Fdetailmenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblnama = new System.Windows.Forms.RichTextBox();
            this.lblketerangan = new System.Windows.Forms.RichTextBox();
            this.lblharga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblnama
            // 
            this.lblnama.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblnama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnama.Location = new System.Drawing.Point(0, 134);
            this.lblnama.Name = "lblnama";
            this.lblnama.ReadOnly = true;
            this.lblnama.Size = new System.Drawing.Size(150, 25);
            this.lblnama.TabIndex = 1;
            this.lblnama.Text = "Nasi Beef Lada Hitam";
            // 
            // lblketerangan
            // 
            this.lblketerangan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblketerangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblketerangan.Location = new System.Drawing.Point(0, 169);
            this.lblketerangan.Name = "lblketerangan";
            this.lblketerangan.ReadOnly = true;
            this.lblketerangan.Size = new System.Drawing.Size(150, 77);
            this.lblketerangan.TabIndex = 2;
            this.lblketerangan.Text = "Nasi Beef Dengan Saus Lada Hitam Yang Enak Dan Meresap";
            // 
            // lblharga
            // 
            this.lblharga.AutoSize = true;
            this.lblharga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblharga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblharga.Location = new System.Drawing.Point(3, 249);
            this.lblharga.Name = "lblharga";
            this.lblharga.Size = new System.Drawing.Size(73, 15);
            this.lblharga.TabIndex = 3;
            this.lblharga.Text = "Rp.45.000";
            // 
            // Fdetailmenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblharga);
            this.Controls.Add(this.lblketerangan);
            this.Controls.Add(this.lblnama);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Fdetailmenu";
            this.Size = new System.Drawing.Size(150, 299);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RichTextBox lblnama;
        public System.Windows.Forms.RichTextBox lblketerangan;
        public System.Windows.Forms.Label lblharga;
    }
}
