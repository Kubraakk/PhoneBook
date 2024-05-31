using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.Binding;
using System.Data.SqlClient;

namespace gelismistelefonreh
{
    public partial class Rehber : Form
    {

        int sayac = 0;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private SqlConnection baglanti = null;
        public Rehber()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            try
            {
                baglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = TelefonRehberi; Integrated Security = True;");
                baglanti.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql baglanti hatasi" + ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
                //MessageBox.Show("sql baglantisi basarili");
            }

        }


        private void Rehber_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(233, 233, 233);
            statusStrip1.BackColor = Color.FromArgb(76, 92, 115);
            menuStripRehber.BackColor = Color.FromArgb(76, 92, 115);
            listViewRehber.BackColor = Color.FromArgb(233, 233, 233);
            listViewRehber.View = View.Details;

            listViewRehber.Columns.Add("Ad", 110);
            listViewRehber.Columns.Add("Soyad", 110);
            listViewRehber.Columns.Add("Numara", 110);
            listViewRehber.Columns.Add("Telefon Türü", 110);
            try
            {
                baglanti.Open();

                string query = "SELECT ad, soyad, tel, tur FROM TelRehber"; //listview içi databaseden çekilen değerler ile dolduruluyor
                adapter = new SqlDataAdapter(query, baglanti);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["ad"].ToString());
                    item.SubItems.Add(row["soyad"].ToString());
                    item.SubItems.Add(row["tel"].ToString());
                    item.SubItems.Add(row["tur"].ToString());
                    item.ImageIndex = 1;

                    listViewRehber.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        public class ListBoxItem
        {
            public string Text { get; set; }
            public Image Icon { get; set; }

            public ListBoxItem(string text, Image icon)
            {
                Text = text;
                Icon = icon;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            toolStripStatusLBLdatetime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            toolStripStatusLBLdatetime.Alignment = ToolStripItemAlignment.Left;
            toolStripStatusLblkisisayisi.Text = "Rehberdeki kişi sayısı: " + listViewRehber.Items.Count.ToString();
            toolStripStatusLblkisisayisi.Alignment = ToolStripItemAlignment.Right;
            sayac++;
        }

        Favoriler favoriler_form = new Favoriler();
        private void tümFavoriKişilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            favoriler_form.ShowDialog();
        }

        Arama arama_form = new Arama();

        private void aramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arama_form.ShowDialog();
        }

        private void kişiyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewRehber.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewRehber.SelectedItems[0];

                string ad = selectedItem.SubItems[0].Text;
                string soyad = selectedItem.SubItems[1].Text;

                // Favori tablosundan silme işlemi
                string deleteQueryFavori = "DELETE FROM Favori WHERE kisiID = (SELECT TOP 1 tel_id FROM TelRehber WHERE Ad=@Ad AND Soyad=@Soyad)";

                using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand deleteCommandFavori = new SqlCommand(deleteQueryFavori, connection))
                    {
                        deleteCommandFavori.Parameters.AddWithValue("@Ad", ad);
                        deleteCommandFavori.Parameters.AddWithValue("@Soyad", soyad);
                        deleteCommandFavori.ExecuteNonQuery();
                    }
                }

                // TelRehber tablosundan silme işlemi
                string deleteQuery = "DELETE FROM TelRehber WHERE Ad = @Ad AND Soyad = @Soyad AND Tel = @Telefon AND Tur = @Tur";

                using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);
                        command.Parameters.AddWithValue("@Telefon", selectedItem.SubItems[2].Text);
                        command.Parameters.AddWithValue("@Tur", selectedItem.SubItems[3].Text);
                        command.ExecuteNonQuery();
                    }
                }
            
       
            listViewRehber.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kişiyi seçiniz!");
            }


        }

        private void kişiyiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewRehber.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewRehber.SelectedItems[0];

                Duzenle duzenle_form = new Duzenle(
                    selectedItem.SubItems[0].Text, // 1. sütun
                    selectedItem.SubItems[1].Text, // 2. sütun
                    selectedItem.SubItems[2].Text, // 3. sütun
                    selectedItem.SubItems[3].Text  // 4. sütun
                );
                duzenle_form.Show();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz kişiyi seçiniz!");
            }
        }

        private void aileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewRehber.Items.Clear();

            string selectQuery = "SELECT * FROM TelRehber WHERE Tur = 'Aile'";

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

                            listViewRehber.Items.Add(new ListViewItem(new[] { ad, soyad, telefon, tur }) { ImageIndex = 1 });
                        }
                    }
                }
            }
        }

        private void evToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewRehber.Items.Clear();

            string selectQuery = "SELECT * FROM TelRehber WHERE Tur = 'Ev'";

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

                            listViewRehber.Items.Add(new ListViewItem(new[] { ad, soyad, telefon, tur }) { ImageIndex = 1 });
                        }
                    }
                }
            }

        }

        private void işToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewRehber.Items.Clear();

            string selectQuery = "SELECT * FROM TelRehber WHERE Tur = 'İş'";

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

                            listViewRehber.Items.Add(new ListViewItem(new[] { ad, soyad, telefon, tur }) { ImageIndex = 1 });
                        }
                    }
                }
            }

        }

        private void okulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewRehber.Items.Clear();

            string selectQuery = "SELECT * FROM TelRehber WHERE Tur = 'Okul'";

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

                            listViewRehber.Items.Add(new ListViewItem(new[] { ad, soyad, telefon, tur }) { ImageIndex = 1 });
                        }
                    }
                }
            }

        }

        private void tümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewRehber.Items.Clear();

            string selectQuery = "SELECT * FROM TelRehber";

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

                            listViewRehber.Items.Add(new ListViewItem(new[] { ad, soyad, telefon, tur }) { ImageIndex = 1 });
                        }
                    }
                }
            }
        }

        //private List<ListViewItem> listViewItems = new List<ListViewItem>();
        private void ismeGöreSıralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewRehber.Items.Clear();

            string selectQuery = "SELECT * FROM TelRehber ORDER BY Ad";

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

                            listViewRehber.Items.Add(new ListViewItem(new[] { ad, soyad, telefon, tur }) { ImageIndex = 1 });
                        }
                    }
                }
            }
        }

        private void numarayaGöreSıralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewRehber.Items.Clear();

            string selectQuery = "SELECT * FROM TelRehber ORDER BY Tel";

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

                            listViewRehber.Items.Add(new ListViewItem(new[] { ad, soyad, telefon, tur }) { ImageIndex = 1 });
                        }
                    }
                }
            }
        }

        private void soyadaGöreSıralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewRehber.Items.Clear();

            string selectQuery = "SELECT * FROM TelRehber ORDER BY Soyad";

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

                            listViewRehber.Items.Add(new ListViewItem(new[] { ad, soyad, telefon, tur }) { ImageIndex = 1 });
                        }
                    }
                }
            }
        }

        private void aramaToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(76, 92, 115);
        }

        private void favorilerToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = (ToolStripDropDownItem)sender;
            ToolStripDropDown dropDown = (ToolStripDropDown)item.DropDown;
            dropDown.BackColor = Color.FromArgb(76, 92, 115);
        }

        private void filtrelemeToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = (ToolStripDropDownItem)sender;
            ToolStripDropDown dropDown = (ToolStripDropDown)item.DropDown;
            dropDown.BackColor = Color.FromArgb(76, 92, 115);

        }

        private void sıralamaToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = (ToolStripDropDownItem)sender;
            ToolStripDropDown dropDown = (ToolStripDropDown)item.DropDown;
            dropDown.BackColor = Color.FromArgb(76, 92, 115);
        }

        private void düzenleToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = (ToolStripDropDownItem)sender;
            ToolStripDropDown dropDown = (ToolStripDropDown)item.DropDown;
            dropDown.BackColor = Color.FromArgb(76, 92, 115);
        }

        private void FavEkletoolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (listViewRehber.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewRehber.SelectedItems[0];

                string ad = selectedItem.SubItems[0].Text;
                string soyad = selectedItem.SubItems[1].Text;
                string telefon = selectedItem.SubItems[2].Text;
                string tur = selectedItem.SubItems[3].Text;

                // Favori tablosuna eklenip eklenmediğini kontrol etme sorgusu
                string checkQuery = "SELECT COUNT(*) FROM Favori WHERE kisiID = (SELECT tel_id FROM TelRehber WHERE Ad = @Ad AND Soyad = @Soyad AND Tel = @Telefon AND Tur = @Tur)";

                using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True;"))
                {
                    connection.Open();

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Ad", ad);
                        checkCommand.Parameters.AddWithValue("@Soyad", soyad);
                        checkCommand.Parameters.AddWithValue("@Telefon", telefon);
                        checkCommand.Parameters.AddWithValue("@Tur", tur);

                        int existingCount = (int)checkCommand.ExecuteScalar();
                        

                        if (existingCount == 0)
                        {
                            // Kişi favoriye ekli değil, ekleme işlemi gerçekleştir
                            string insertQuery = "INSERT INTO Favori (kisiID) VALUES ((SELECT tel_id FROM TelRehber WHERE Ad = @Ad AND Soyad = @Soyad AND Tel = @Telefon AND Tur = @Tur))";

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@Ad", ad);
                                insertCommand.Parameters.AddWithValue("@Soyad", soyad);
                                insertCommand.Parameters.AddWithValue("@Telefon", telefon);
                                insertCommand.Parameters.AddWithValue("@Tur", tur);

                                insertCommand.ExecuteNonQuery();

                                MessageBox.Show("Kişi Favorilere Eklendi!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kişi zaten favorilerde kayıtlı!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen favoriye eklemek istediğiniz kişiyi seçiniz!");
            }
        }
    }
}