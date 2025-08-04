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
using System.Net.Http.Headers;

namespace SeminarskiRSOK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txt_korisnickoImeAdmina.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            txt_lozinkaAdmina.KeyDown += new KeyEventHandler(TextBox_KeyDown);
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1VNGR39;Initial Catalog=AvioKarte;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                // Call the button click event
                button2_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String korisnickoImeAdmina, lozinkaAdmina;

            korisnickoImeAdmina = txt_korisnickoImeAdmina.Text;
            lozinkaAdmina = txt_lozinkaAdmina.Text;

            try
            {
                String querry = "SELECT * FROM admini WHERE korisnickoImeAdmina = '"+txt_korisnickoImeAdmina.Text+ "' AND lozinkaAdmina = '"+txt_lozinkaAdmina.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    korisnickoImeAdmina = txt_korisnickoImeAdmina.Text;
                    lozinkaAdmina = txt_lozinkaAdmina.Text;

                    //ucitavanje sledece stranice
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Uneti podaci su netačni!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_korisnickoImeAdmina.Clear();
                    txt_lozinkaAdmina.Clear(); 
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
