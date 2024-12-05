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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-DOL06LT; Initial Catalog = AvioKarte; Integrated Security = True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into karta values (@idKarte, @imePutnika, @prezimePutnika, @poletanje, @sletanje, @klasa, @vremePoletanja, @datumPoletanja, @sediste, @brojLeta, @kapija)", con);

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

            MessageBox.Show("Podaci su uspešno uneti!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
