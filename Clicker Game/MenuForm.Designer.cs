namespace Clicker_Game
{
    partial class MenuForm
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
            this.rbSulit = new System.Windows.Forms.RadioButton();
            this.rbSedang = new System.Windows.Forms.RadioButton();
            this.rbMudah = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSulit);
            this.panel1.Controls.Add(this.rbSedang);
            this.panel1.Controls.Add(this.rbMudah);
            this.panel1.Location = new System.Drawing.Point(85, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 76);
            this.panel1.TabIndex = 0;
            // 
            // rbSulit
            // 
            this.rbSulit.AutoSize = true;
            this.rbSulit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSulit.Location = new System.Drawing.Point(3, 49);
            this.rbSulit.Name = "rbSulit";
            this.rbSulit.Size = new System.Drawing.Size(58, 24);
            this.rbSulit.TabIndex = 2;
            this.rbSulit.TabStop = true;
            this.rbSulit.Text = "Sulit";
            this.rbSulit.UseVisualStyleBackColor = true;
            // 
            // rbSedang
            // 
            this.rbSedang.AutoSize = true;
            this.rbSedang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSedang.Location = new System.Drawing.Point(3, 26);
            this.rbSedang.Name = "rbSedang";
            this.rbSedang.Size = new System.Drawing.Size(83, 24);
            this.rbSedang.TabIndex = 1;
            this.rbSedang.TabStop = true;
            this.rbSedang.Text = "Sedang";
            this.rbSedang.UseVisualStyleBackColor = true;
            // 
            // rbMudah
            // 
            this.rbMudah.AutoSize = true;
            this.rbMudah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMudah.Location = new System.Drawing.Point(3, 3);
            this.rbMudah.Name = "rbMudah";
            this.rbMudah.Size = new System.Drawing.Size(76, 24);
            this.rbMudah.TabIndex = 0;
            this.rbMudah.TabStop = true;
            this.rbMudah.Text = "Mudah";
            this.rbMudah.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "KELUAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 54);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "CLICKER GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "MULAI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 242);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbSulit;
        private System.Windows.Forms.RadioButton rbSedang;
        private System.Windows.Forms.RadioButton rbMudah;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}