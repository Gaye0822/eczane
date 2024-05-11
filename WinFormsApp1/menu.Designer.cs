namespace WinFormsApp1
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Location = new Point(345, 316);
            button1.Name = "button1";
            button1.Size = new Size(95, 36);
            button1.TabIndex = 0;
            button1.Text = "Depo";
            button1.UseVisualStyleBackColor = false;
            //button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(231, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 255);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
           // pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.Location = new Point(479, 316);
            button2.Name = "button2";
            button2.Size = new Size(92, 36);
            button2.TabIndex = 2;
            button2.Text = "Satış Geçmişi";
            button2.UseVisualStyleBackColor = false;
           // button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Menu;
            button3.Location = new Point(210, 316);
            button3.Name = "button3";
            button3.Size = new Size(88, 36);
            button3.TabIndex = 3;
            button3.Text = "İlaç Ara";
            button3.UseVisualStyleBackColor = false;
           // button3.Click += button3_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "menu";
            Text = "menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
    }
}