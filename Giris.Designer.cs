namespace Otomasyon_1
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            kullanicitxt = new TextBox();
            sifretxt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 50);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(56, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 39);
            label1.TabIndex = 2;
            label1.Text = "VERA RESTAURANT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(652, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 32);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(374, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(306, 400);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 4;
            label3.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 5;
            label4.Text = "Şifre :";
            // 
            // kullanicitxt
            // 
            kullanicitxt.Location = new Point(149, 125);
            kullanicitxt.Name = "kullanicitxt";
            kullanicitxt.Size = new Size(100, 23);
            kullanicitxt.TabIndex = 6;
            // 
            // sifretxt
            // 
            sifretxt.Location = new Point(149, 197);
            sifretxt.Name = "sifretxt";
            sifretxt.PasswordChar = '*';
            sifretxt.Size = new Size(100, 23);
            sifretxt.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(47, 309);
            button1.Name = "button1";
            button1.Size = new Size(121, 38);
            button1.TabIndex = 8;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(201, 309);
            button2.Name = "button2";
            button2.Size = new Size(120, 38);
            button2.TabIndex = 9;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(680, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sifretxt);
            Controls.Add(kullanicitxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox kullanicitxt;
        private TextBox sifretxt;
        private Button button1;
        private Button button2;
    }
}
