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
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-DOL06LT; Initial Catalog = AvioKarte; Integrated Security = True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into korisnik values (@imeKorisnika, @prezimeKorisnika, @emailKorisnika, @telefonKorisnika, @lozinkaKorisnika)", con);

            cmd.Parameters.AddWithValue("@imeKorisnika", textBox1.Text);
            cmd.Parameters.AddWithValue("@prezimeKorisnika", textBox2.Text);
            cmd.Parameters.AddWithValue("@telefonKorisnika", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@emailKorisnika", textBox4.Text);
            cmd.Parameters.AddWithValue("@lozinkaKorisnika", textBox5.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Podaci su uspešno uneti!");
        }
    }
}
