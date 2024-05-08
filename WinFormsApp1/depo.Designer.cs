namespace WinFormsApp1
{
    partial class depo
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
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(161, 70);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Menu;
            textBox4.Location = new Point(161, 113);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 3;
            //textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.Location = new Point(-1, 0);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 23);
            textBox5.TabIndex = 4;
            textBox5.Text = "Barkod NO";
            //textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(94, 72);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 5;
            label1.Text = "İlaç Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(78, 116);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "Stok Adeti :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Location = new Point(94, 189);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 9;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = false;
           // button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Menu;
            button3.Location = new Point(265, 189);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 11;
            button3.Text = "Ekle";
            button3.UseVisualStyleBackColor = false;
           // button3.Click += button3_Click;
            // 
            // depo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(424, 338);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "depo";
            Text = "Form6";
            //Load += depo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label3;
        private Button button1;
        private Button button3;
    }
}