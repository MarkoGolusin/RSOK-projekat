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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


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

        private void buttonPrintPdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo izaberite kartu iz tabele!");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            string idKarte = row.Cells["idKarte"].Value.ToString();
            string ime = row.Cells["imePutnika"].Value.ToString();
            string prezime = row.Cells["prezimePutnika"].Value.ToString();
            string poletanje = row.Cells["poletanje"].Value.ToString();
            string sletanje = row.Cells["sletanje"].Value.ToString();
            string klasa = row.Cells["klasa"].Value.ToString();
            string vreme = row.Cells["vremePoletanja"].Value.ToString();
            string datum = row.Cells["datumPoletanja"].Value.ToString();
            string sediste = row.Cells["sediste"].Value.ToString();
            string brojLeta = row.Cells["brojLeta"].Value.ToString();
            string kapija = row.Cells["kapija"].Value.ToString();


            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(folderPath, $"Karta_{idKarte}.pdf");

            try
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();


                Paragraph title = new Paragraph("Avio Karta", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                doc.Add(new Paragraph("\n"));


                doc.Add(new Paragraph($"ID karte: {idKarte}"));
                doc.Add(new Paragraph($"Putnik: {ime} {prezime}"));
                doc.Add(new Paragraph($"Polazak: {poletanje}"));
                doc.Add(new Paragraph($"Sletanje: {sletanje}"));
                doc.Add(new Paragraph($"Klasa: {klasa}"));
                doc.Add(new Paragraph($"Datum: {datum}"));
                doc.Add(new Paragraph($"Vreme: {vreme}"));
                doc.Add(new Paragraph($"Sedište: {sediste}"));
                doc.Add(new Paragraph($"Broj leta: {brojLeta}"));
                doc.Add(new Paragraph($"Kapija: {kapija}"));

                doc.Close();

                MessageBox.Show($"PDF karta je uspešno sačuvana na: {filePath}");

                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
