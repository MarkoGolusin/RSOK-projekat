using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRSOK
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            BinGrid();
        }

        private void BinGrid()
        {
            string constring = @"Data Source=DESKTOP-1VNGR39;Initial Catalog=AvioKarte;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM karta WHERE imePutnika = 'nije rezervisano' AND prezimePutnika = 'nije rezervisano'", con))
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
        private void ResetTabele()
        {
            try
            {
                string constring = @"Data Source=DESKTOP-1VNGR39;Initial Catalog=AvioKarte;Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(constring))
                {

                    con.Open();


                    string selectQuery = "SELECT * FROM karta WHERE imePutnika = 'nije rezervisano' AND prezimePutnika = 'nije rezervisano'";
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-1VNGR39; Initial Catalog = AvioKarte; Integrated Security = True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from karta where sediste=@sediste AND brojLeta=@brojLeta AND idKarte=@idKarte", con);

            cmd.Parameters.AddWithValue("@idKarte", textBox8.Text);
            cmd.Parameters.AddWithValue("@sediste", textBox7.Text);
            cmd.Parameters.AddWithValue("@brojLeta", textBox6.Text);

            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                using (DataTable dt = new DataTable())
                {
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            ResetTabele();
        }

    }
}
