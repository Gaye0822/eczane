namespace WinFormsApp1
{
    partial class depoekle
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(191, 84);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(191, 124);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.Location = new Point(191, 161);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Menu;
            textBox4.Location = new Point(191, 205);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(106, 23);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 86);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 4;
            label1.Text = "İlaç Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 164);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Stok Adeti :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 126);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 6;
            label3.Text = "Barkod NO :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 205);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 7;
            label4.Text = "Eklenecek Stok Adeti :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Location = new Point(111, 263);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 8;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.Location = new Point(290, 263);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 9;
            button2.Text = "Çıkış";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // depoekle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(455, 338);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "depoekle";
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}