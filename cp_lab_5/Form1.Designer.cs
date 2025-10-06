namespace cp_lab_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MethodBox = new System.Windows.Forms.ComboBox();
            this.EquasionBox = new System.Windows.Forms.ComboBox();
            this.solve = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.ABox = new System.Windows.Forms.TextBox();
            this.EpsBox = new System.Windows.Forms.TextBox();
            this.BBox = new System.Windows.Forms.TextBox();
            this.RootBox = new System.Windows.Forms.TextBox();
            this.IterBox = new System.Windows.Forms.TextBox();
            this.KmaxBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оберіть метод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Оберіть рівняння";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вхідні дані";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "а";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "b";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "eps";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "kmax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Результати";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Корінь";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ітерації";
            // 
            // MethodBox
            // 
            this.MethodBox.FormattingEnabled = true;
            this.MethodBox.Items.AddRange(new object[] {
            "Ділення Навпіл",
            "Ньютона"});
            this.MethodBox.Location = new System.Drawing.Point(39, 59);
            this.MethodBox.Name = "MethodBox";
            this.MethodBox.Size = new System.Drawing.Size(121, 21);
            this.MethodBox.TabIndex = 10;
            // 
            // EquasionBox
            // 
            this.EquasionBox.FormattingEnabled = true;
            this.EquasionBox.Items.AddRange(new object[] {
            "x^2 - 4 = 0",
            "3x - 4log(x) -5 =0",
            "e^x - 3x"});
            this.EquasionBox.Location = new System.Drawing.Point(39, 112);
            this.EquasionBox.Name = "EquasionBox";
            this.EquasionBox.Size = new System.Drawing.Size(121, 21);
            this.EquasionBox.TabIndex = 11;
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(341, 187);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 23);
            this.solve.TabIndex = 12;
            this.solve.Text = "Розв\'язати";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(450, 187);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 13;
            this.clear.Text = "Очистити";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(397, 232);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 14;
            this.exit.Text = "Закрити";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ABox
            // 
            this.ABox.Location = new System.Drawing.Point(225, 59);
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(100, 20);
            this.ABox.TabIndex = 15;
            // 
            // EpsBox
            // 
            this.EpsBox.Location = new System.Drawing.Point(225, 111);
            this.EpsBox.Name = "EpsBox";
            this.EpsBox.Size = new System.Drawing.Size(100, 20);
            this.EpsBox.TabIndex = 16;
            // 
            // BBox
            // 
            this.BBox.Location = new System.Drawing.Point(225, 85);
            this.BBox.Name = "BBox";
            this.BBox.Size = new System.Drawing.Size(100, 20);
            this.BBox.TabIndex = 17;
            // 
            // RootBox
            // 
            this.RootBox.Location = new System.Drawing.Point(397, 59);
            this.RootBox.Name = "RootBox";
            this.RootBox.ReadOnly = true;
            this.RootBox.Size = new System.Drawing.Size(100, 20);
            this.RootBox.TabIndex = 20;
            // 
            // IterBox
            // 
            this.IterBox.Location = new System.Drawing.Point(397, 112);
            this.IterBox.Name = "IterBox";
            this.IterBox.ReadOnly = true;
            this.IterBox.Size = new System.Drawing.Size(100, 20);
            this.IterBox.TabIndex = 19;
            // 
            // KmaxBox
            // 
            this.KmaxBox.Location = new System.Drawing.Point(225, 137);
            this.KmaxBox.Name = "KmaxBox";
            this.KmaxBox.Size = new System.Drawing.Size(100, 20);
            this.KmaxBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 282);
            this.Controls.Add(this.RootBox);
            this.Controls.Add(this.IterBox);
            this.Controls.Add(this.KmaxBox);
            this.Controls.Add(this.BBox);
            this.Controls.Add(this.EpsBox);
            this.Controls.Add(this.ABox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.EquasionBox);
            this.Controls.Add(this.MethodBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Розв\'язання нелінійних рівнянь методами МДН та МН";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox MethodBox;
        private System.Windows.Forms.ComboBox EquasionBox;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox ABox;
        private System.Windows.Forms.TextBox EpsBox;
        private System.Windows.Forms.TextBox BBox;
        private System.Windows.Forms.TextBox RootBox;
        private System.Windows.Forms.TextBox IterBox;
        private System.Windows.Forms.TextBox KmaxBox;
    }
}

