using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SeminarskiRSOK
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            BinGrid();
        }

        private void binDataGrid()
        {
            string constring = "Data Source=DESKTOP-DMH1A5F;Initial Catalog=AvioKarte;Integrated Security=True;Trust Server Certificate=True";
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
            string constring = @"Data Source=DESKTOP-DMH1A5F;Initial Catalog=AvioKarte;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * FROM karta", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }

                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.CurrentRow != null)
                {
                    int idKarte = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    string constring = @"Data Source=DESKTOP-DMH1A5F;Initial Catalog=AvioKarte;Integrated Security=True;";

                    using (SqlConnection con = new SqlConnection(constring))
                    {

                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM karta WHERE idKarte=@idKarte", con))
                        {
                            cmd.Parameters.AddWithValue("@idKarte", idKarte);


                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Obrisano");
                            }
                            else
                            {
                                MessageBox.Show("Nije pronadjen id za brisanje");
                            }
                        }
                    }


                    ResetTabele();
                }
                else
                {
                    MessageBox.Show("Izaberite red za brisanje");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska: " + ex.Message);
            }
        }

        private void ResetTabele()
        {
            try
            {
                string constring = @"Data Source=DESKTOP-DMH1A5F;Initial Catalog=AvioKarte;Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(constring))
                {

                    con.Open();


                    string selectQuery = "SELECT * FROM karta";
                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {

                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {

                            da.Fill(dt);
                        }


                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska pri prikazivanju nove tabele " + ex.Message);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
