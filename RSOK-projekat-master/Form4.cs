using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRSOK
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            BinGrid();
        }

        private void binDataGrid()
        {
            string constring = "Data Source=DESKTOP-1VNGR39;Initial Catalog=AvioKarte;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
               



            }


         }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BinGrid();
        }

        private void BinGrid()
        {
            string constring = @"Data Source=DESKTOP-1VNGR39;Initial Catalog=AvioKarte;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * FROM karta", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter (cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill (dt);
                            dataGridView1.DataSource  = dt;
                        }
                    }

                }
                    

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         private void Form4_Load(object sender, EventArgs e)
 {

 }

 private void button2_Click(object sender, EventArgs e)
 {
     Form1 form1 = new Form1();
     form1.Show();
     this.Hide();
 }

 private void button1_Click(object sender, EventArgs e)
 {

 }
    }
}
