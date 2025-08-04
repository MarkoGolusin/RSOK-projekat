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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SeminarskiRSOK
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            BinGrid();
        }

        private void binDataGrid()
        {
            string constring = "Data Source=DESKTOP-DMH1A5F;Initial Catalog=AvioKarte;Integrated Security=True;";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                int idKarte = (int)dataGridView1.CurrentRow.Cells[0].Value;
                SqlConnection con = new SqlConnection("Data Source = DESKTOP-1VNGR39; Initial Catalog = AvioKarte; Integrated Security = True;");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into korisnik values (@imeKorisnika, @prezimeKorisnika, @emailKorisnika, @telefonKorisnika, @lozinkaKorisnika) UPDATE karta SET imePutnika=@imeKorisnika, prezimePutnika=@prezimeKorisnika WHERE idKarte=@idKarte", con);
=======
            int idKarte = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-DMH1A5F; Initial Catalog = AvioKarte; Integrated Security = True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into korisnik values (@imeKorisnika, @prezimeKorisnika, @emailKorisnika, @telefonKorisnika, @lozinkaKorisnika) UPDATE karta SET imePutnika=@imeKorisnika, prezimePutnika=@prezimeKorisnika WHERE idKarte=@idKarte", con);
>>>>>>> aff740f5ed80fd55d8379e084f5dfe1d2b4fedb2

                cmd.Parameters.AddWithValue("@imeKorisnika", textBox1.Text);
                cmd.Parameters.AddWithValue("@prezimeKorisnika", textBox2.Text);
                cmd.Parameters.AddWithValue("@telefonKorisnika", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@emailKorisnika", textBox4.Text);
                cmd.Parameters.AddWithValue("@lozinkaKorisnika", textBox5.Text);
                cmd.Parameters.AddWithValue("@idKarte", idKarte);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Podaci su uspešno uneti!");

                ResetTabele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Niste popunili sva polja!");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void label7_Click_1(object sender, EventArgs e)
        {

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            Visible = false;
=======
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = @"Data Source=DESKTOP-DMH1A5F;Initial Catalog=AvioKarte;Integrated Security=True;";
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

                MessageBox.Show("Greska " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

                MessageBox.Show("Greska " + ex.Message);
            }
>>>>>>> aff740f5ed80fd55d8379e084f5dfe1d2b4fedb2
        }
    }
}
