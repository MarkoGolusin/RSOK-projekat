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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeminarskiRSOK
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            BinGrid();
        }

        private void binDataGrid()
        {
            string constring = "Data Source=DESKTOP-1VNGR39;Initial Catalog=AvioKarte;Integrated Security=True;";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["idKarte"].Value.ToString();
                textBox2.Text = row.Cells["imePutnika"].Value.ToString();
                textBox3.Text = row.Cells["prezimePutnika"].Value.ToString();
                textBox4.Text = row.Cells["poletanje"].Value.ToString();
                textBox5.Text = row.Cells["sletanje"].Value.ToString();
                textBox6.Text = row.Cells["klasa"].Value.ToString();
                textBox7.Text = row.Cells["vremePoletanja"].Value.ToString();
                textBox8.Text = row.Cells["datumPoletanja"].Value.ToString();
                textBox9.Text = row.Cells["sediste"].Value.ToString();
                textBox10.Text = row.Cells["brojLeta"].Value.ToString();
                textBox11.Text = row.Cells["kapija"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-1VNGR39; Initial Catalog = AvioKarte; Integrated Security = True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("update karta set imePutnika=@imePutnika, prezimePutnika=@prezimePutnika, poletanje=@poletanje, sletanje=@sletanje, klasa=@klasa, vremePoletanja=@vremePoletanja, datumPoletanja=@datumPoletanja, sediste=@sediste, brojLeta=@brojLeta, kapija=@kapija where idKarte=@idKarte", con);

            cmd.Parameters.AddWithValue("@idKarte", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@imePutnika", textBox2.Text);
            cmd.Parameters.AddWithValue("@prezimePutnika", textBox3.Text);
            cmd.Parameters.AddWithValue("@poletanje", textBox4.Text);
            cmd.Parameters.AddWithValue("@sletanje", textBox5.Text);
            cmd.Parameters.AddWithValue("@klasa", textBox6.Text);
            cmd.Parameters.AddWithValue("@vremePoletanja", textBox7.Text);
            cmd.Parameters.AddWithValue("@datumPoletanja", textBox8.Text);
            cmd.Parameters.AddWithValue("@sediste", textBox9.Text);
            cmd.Parameters.AddWithValue("@brojLeta", textBox10.Text);
            cmd.Parameters.AddWithValue("@kapija", textBox11.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Podaci su uspešno izmenjeni");
            BinGrid();
        }
    }
}
