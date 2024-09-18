
namespace project_farhan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pfarhan = new System.Windows.Forms.Label();
            this.ufarhan = new System.Windows.Forms.Label();
            this.lfarhan1 = new System.Windows.Forms.Label();
            this.textBoxfarhan1 = new System.Windows.Forms.TextBox();
            this.textboxfarhan2 = new System.Windows.Forms.TextBox();
            this.buttonfarhan1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buttonfarhan1);
            this.panel1.Controls.Add(this.textboxfarhan2);
            this.panel1.Controls.Add(this.textBoxfarhan1);
            this.panel1.Controls.Add(this.pfarhan);
            this.panel1.Controls.Add(this.ufarhan);
            this.panel1.Controls.Add(this.lfarhan1);
            this.panel1.Location = new System.Drawing.Point(185, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 321);
            this.panel1.TabIndex = 0;
            // 
            // pfarhan
            // 
            this.pfarhan.AutoSize = true;
            this.pfarhan.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfarhan.Location = new System.Drawing.Point(56, 171);
            this.pfarhan.Name = "pfarhan";
            this.pfarhan.Size = new System.Drawing.Size(93, 16);
            this.pfarhan.TabIndex = 3;
            this.pfarhan.Text = "Password";
            // 
            // ufarhan
            // 
            this.ufarhan.AutoSize = true;
            this.ufarhan.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ufarhan.Location = new System.Drawing.Point(56, 116);
            this.ufarhan.Name = "ufarhan";
            this.ufarhan.Size = new System.Drawing.Size(94, 16);
            this.ufarhan.TabIndex = 2;
            this.ufarhan.Text = "Username";
            // 
            // lfarhan1
            // 
            this.lfarhan1.AutoSize = true;
            this.lfarhan1.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfarhan1.Location = new System.Drawing.Point(133, 18);
            this.lfarhan1.Name = "lfarhan1";
            this.lfarhan1.Size = new System.Drawing.Size(92, 30);
            this.lfarhan1.TabIndex = 1;
            this.lfarhan1.Text = "Login";
            // 
            // textBoxfarhan1
            // 
            this.textBoxfarhan1.Location = new System.Drawing.Point(178, 114);
            this.textBoxfarhan1.Name = "textBoxfarhan1";
            this.textBoxfarhan1.Size = new System.Drawing.Size(144, 20);
            this.textBoxfarhan1.TabIndex = 5;
            // 
            // textboxfarhan2
            // 
            this.textboxfarhan2.Location = new System.Drawing.Point(178, 169);
            this.textboxfarhan2.Name = "textboxfarhan2";
            this.textboxfarhan2.PasswordChar = '*';
            this.textboxfarhan2.Size = new System.Drawing.Size(144, 20);
            this.textboxfarhan2.TabIndex = 6;
            // 
            // buttonfarhan1
            // 
            this.buttonfarhan1.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonfarhan1.Location = new System.Drawing.Point(59, 221);
            this.buttonfarhan1.Name = "buttonfarhan1";
            this.buttonfarhan1.Size = new System.Drawing.Size(263, 38);
            this.buttonfarhan1.TabIndex = 7;
            this.buttonfarhan1.Text = "Masuk";
            this.buttonfarhan1.UseVisualStyleBackColor = false;
            this.buttonfarhan1.Click += new System.EventHandler(this.buttonfarhan1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pfarhan;
        private System.Windows.Forms.Label ufarhan;
        private System.Windows.Forms.Label lfarhan1;
        private System.Windows.Forms.Button buttonfarhan1;
        private System.Windows.Forms.TextBox textboxfarhan2;
        private System.Windows.Forms.TextBox textBoxfarhan1;
    }
}

