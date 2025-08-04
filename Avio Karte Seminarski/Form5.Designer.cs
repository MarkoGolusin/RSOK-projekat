namespace SeminarskiRSOK
{
    partial class Form5
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(521, 360);
            button1.Name = "button1";
            button1.Size = new Size(153, 44);
            button1.TabIndex = 0;
            button1.Text = "OBRIŠI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1177, 267);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlText;
            button2.ImageAlign = ContentAlignment.BottomCenter;
            button2.Location = new Point(1091, 12);
            button2.Name = "button2";
            button2.Size = new Size(98, 33);
            button2.TabIndex = 2;
            button2.Text = "NAZAD";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(456, 12);
            label6.Name = "label6";

            label6.Size = new Size(171, 33);
            label6.TabIndex = 7;
            label6.Text = "Brisanje karte";

            label6.Size = new Size(276, 33);
            label6.TabIndex = 7;
            label6.Text = "REGISTRACIJA PUTNIKA";

            label6.Click += label6_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(136, 204, 227);
            ClientSize = new Size(1199, 428);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label6;
    }
}