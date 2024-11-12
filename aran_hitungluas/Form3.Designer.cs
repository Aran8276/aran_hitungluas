namespace aran_hitungluas
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tPanjang = new TextBox();
            tLebar = new TextBox();
            bHitung = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 71);
            label1.Name = "label1";
            label1.Size = new Size(340, 41);
            label1.TabIndex = 0;
            label1.Text = "LUAS PERSEGI PANJANG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 167);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 1;
            label2.Text = "Panjang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 225);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 2;
            label3.Text = "Lebar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 340);
            label4.Name = "label4";
            label4.Size = new Size(215, 28);
            label4.TabIndex = 3;
            label4.Text = "Luas Persegi Panjang = ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(290, 340);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // tPanjang
            // 
            tPanjang.Location = new Point(178, 171);
            tPanjang.Name = "tPanjang";
            tPanjang.Size = new Size(143, 27);
            tPanjang.TabIndex = 5;
            // 
            // tLebar
            // 
            tLebar.Location = new Point(178, 226);
            tLebar.Name = "tLebar";
            tLebar.Size = new Size(143, 27);
            tLebar.TabIndex = 6;
            // 
            // bHitung
            // 
            bHitung.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bHitung.Location = new Point(146, 276);
            bHitung.Name = "bHitung";
            bHitung.Size = new Size(138, 50);
            bHitung.TabIndex = 7;
            bHitung.Text = "Hitung";
            bHitung.UseVisualStyleBackColor = true;
            bHitung.Click += bHitung_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(483, 450);
            Controls.Add(bHitung);
            Controls.Add(tLebar);
            Controls.Add(tPanjang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tPanjang;
        private TextBox tLebar;
        private Button bHitung;
    }
}