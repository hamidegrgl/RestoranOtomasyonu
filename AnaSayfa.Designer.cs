namespace Otomasyon_1
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.TabIndex = 1;
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
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(56, 116);
            button1.Name = "button1";
            button1.Size = new Size(136, 82);
            button1.TabIndex = 4;
            button1.Text = "MASA DURUMU ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(239, 116);
            button2.Name = "button2";
            button2.Size = new Size(136, 82);
            button2.TabIndex = 5;
            button2.Text = "MENÜ SEÇİMİ\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGreen;
            button3.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(147, 226);
            button3.Name = "button3";
            button3.Size = new Size(136, 82);
            button3.TabIndex = 6;
            button3.Text = "ÖDEME\r\n";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PapayaWhip;
            button4.Dock = DockStyle.Right;
            button4.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.Location = new Point(591, 0);
            button4.Name = "button4";
            button4.Size = new Size(89, 55);
            button4.TabIndex = 7;
            button4.Text = "BACK\r\n";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 395);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 55);
            panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(401, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(279, 345);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(680, 450);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaSayfa";
            StartPosition = FormStartPosition.Manual;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}