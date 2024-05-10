namespace WinFormsApp1
{
    partial class hastakayıt
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
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 136);
            button1.Name = "button1";
            button1.Size = new Size(138, 35);
            button1.TabIndex = 0;
            button1.Text = "görüntüle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(564, 80);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "sıra";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Hasta Adı Soyadı";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Hasta.T.C";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "İlaç Adı";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Adet";
            columnHeader5.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(591, 33);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 2;
            label1.Text = "sıra";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(646, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(646, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 23);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(591, 72);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 4;
            label2.Text = "Hasta Ad Soyad";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(646, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(111, 23);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(591, 120);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Hasta T.C";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(646, 162);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(111, 23);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(591, 165);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 8;
            label4.Text = "İlaç Adı";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(646, 205);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(111, 23);
            textBox5.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(591, 208);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 10;
            label5.Text = "Adet";
            // 
            // button2
            // 
            button2.Location = new Point(619, 263);
            button2.Name = "button2";
            button2.Size = new Size(138, 35);
            button2.TabIndex = 12;
            button2.Text = "kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // hastakayıt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(button1);
            Name = "hastakayıt";
            Text = "Form2";
            Load += hastakayıt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Button button2;
    }
}