namespace SeminarskiRSOK
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            txt_korisnickoImeAdmina = new TextBox();
            txt_lozinkaAdmina = new TextBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(811, 457);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(361, 94);
            label1.Name = "label1";
            label1.Size = new Size(97, 33);
            label1.TabIndex = 1;
            label1.Text = "ADMIN";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(686, 21);
            button1.Name = "button1";
            button1.Size = new Size(102, 33);
            button1.TabIndex = 2;
            button1.Text = "POČETNA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_korisnickoImeAdmina
            // 
            txt_korisnickoImeAdmina.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_korisnickoImeAdmina.Location = new Point(300, 164);
            txt_korisnickoImeAdmina.Name = "txt_korisnickoImeAdmina";
            txt_korisnickoImeAdmina.Size = new Size(262, 33);
            txt_korisnickoImeAdmina.TabIndex = 5;
            txt_korisnickoImeAdmina.TextChanged += textBox1_TextChanged;
            // 
            // txt_lozinkaAdmina
            // 
            txt_lozinkaAdmina.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_lozinkaAdmina.Location = new Point(300, 236);
            txt_lozinkaAdmina.Name = "txt_lozinkaAdmina";
            txt_lozinkaAdmina.Size = new Size(262, 33);
            txt_lozinkaAdmina.TabIndex = 6;
            txt_lozinkaAdmina.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(348, 346);
            button2.Name = "button2";
            button2.Size = new Size(123, 32);
            button2.TabIndex = 7;
            button2.Text = "ULOGUJ SE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(235, 156);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 41);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(235, 227);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 42);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(txt_lozinkaAdmina);
            Controls.Add(txt_korisnickoImeAdmina);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private TextBox txt_korisnickoImeAdmina;
        private TextBox txt_lozinkaAdmina;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}