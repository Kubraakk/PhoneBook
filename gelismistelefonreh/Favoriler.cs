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

namespace gelismistelefonreh
{
    public partial class Favoriler : Form
    {

        int sayac = 0;
        private SqlConnection connection = null;
        public Favoriler()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True;");

        }
        private void Favoriler_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(233, 233, 233);
            listViewFavoriler.BackColor = Color.FromArgb(233, 233, 233);
            menuStripFavoriler.BackColor = Color.FromArgb(76, 92, 115);
            statusStripFavoriler.BackColor = Color.FromArgb(76, 92, 115);
            listViewFavoriler.View = View.Details;
            listViewFavoriler.Columns.Add("Ad", 110);
            listViewFavoriler.Columns.Add("Soyad", 110);
            listViewFavoriler.Columns.Add("Numara", 110);
            listViewFavoriler.Columns.Add("Telefon Türü", 110);
            listViewFavoriler.Items.Clear();

            string selectQuery = "select ad,soyad,tel,tur from TelRehber JOIN Favori ON TelRehber.tel_id = Favori.kisiID;";


            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True;"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ad = reader["Ad"].ToString();
                            string soyad = reader["Soyad"].ToString();
                            string telefon = reader["Tel"].ToString();
                            string tur = reader["Tur"].ToString();

                            listViewFavoriler.Items.Add(new ListViewItem(new[] { ad, soyad, telefon, tur }) { ImageIndex = 3 });
                        }
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            toolStripStatusLabelFavDate.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            toolStripStatusLabelFavDate.Alignment = ToolStripItemAlignment.Left;
            toolStripStatusLabelFavoriNum.Text = "Favorilerdeki kişi sayısı: " + listViewFavoriler.Items.Count.ToString();
            toolStripStatusLabelFavoriNum.Alignment = ToolStripItemAlignment.Right;
            sayac++;
        }

        private void favoridenÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewFavoriler.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewFavoriler.SelectedItems[0];

                string ad = selectedItem.SubItems[0].Text;
                string soyad = selectedItem.SubItems[1].Text;

                using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True;"))
                {
                    connection.Open();

                    string deletequery = "DELETE FROM Favori WHERE kisiID = (SELECT TOP 1 tel_id FROM TelRehber WHERE Ad=@Ad AND Soyad=@Soyad)";

                    using (SqlCommand command = new SqlCommand(deletequery, connection))
                    {
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);

                        command.ExecuteNonQuery();
                    }
                }

                // ListView'den seçilen kişiyi kaldırma
                listViewFavoriler.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kişiyi seçiniz!");
            }
        }
    }
}
