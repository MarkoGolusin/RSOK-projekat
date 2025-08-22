namespace SeminarskiRSOK
{
    partial class Form11
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
            label10 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            buttonPrintPdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.Location = new Point(810, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(90, 41);
            button1.TabIndex = 1;
            button1.Text = "NAZAD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label10.Location = new Point(62, 91);
            label10.Name = "label10";
            label10.Size = new Size(75, 21);
            label10.TabIndex = 31;
            label10.Text = "ID KARTE";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(62, 117);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(114, 27);
            textBox8.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label9.Location = new Point(62, 163);
            label9.Name = "label9";
            label9.Size = new Size(96, 21);
            label9.TabIndex = 29;
            label9.Text = "BR. SEDIŠTA";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(62, 189);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(114, 27);
            textBox7.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label8.Location = new Point(66, 224);
            label8.Name = "label8";
            label8.Size = new Size(71, 21);
            label8.TabIndex = 27;
            label8.Text = "BR. LETA";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(62, 251);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 26;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.Font = new Font("Calibri", 15F, FontStyle.Bold);
            button4.Location = new Point(410, 187);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(104, 41);
            button4.TabIndex = 25;
            button4.Text = "RESET";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.Font = new Font("Calibri", 15F, FontStyle.Bold);
            button3.Location = new Point(317, 107);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(267, 41);
            button3.TabIndex = 24;
            button3.Text = "PREGLED VAŠE KARTE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 20.25F, FontStyle.Bold);
            label7.Location = new Point(346, 267);
            label7.Name = "label7";
            label7.Size = new Size(266, 41);
            label7.TabIndex = 23;
            label7.Text = "PREGLED KARATA";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 315);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(875, 200);
            dataGridView1.TabIndex = 32;
            // 
            // buttonPrintPdf
            // 
            buttonPrintPdf.BackColor = Color.PeachPuff;
            buttonPrintPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrintPdf.Location = new Point(706, 267);
            buttonPrintPdf.Name = "buttonPrintPdf";
            buttonPrintPdf.Size = new Size(149, 41);
            buttonPrintPdf.TabIndex = 33;
            buttonPrintPdf.Text = "ŠTAMPAJ KARTU";
            buttonPrintPdf.UseVisualStyleBackColor = false;
            buttonPrintPdf.Click += buttonPrintPdf_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PozadinaAdminKorisnika;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonPrintPdf);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form11";
            Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label10;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox6;
        private Button button4;
        private Button button3;
        private Label label7;
        private DataGridView dataGridView1;
        private Button buttonPrintPdf;
    }
}