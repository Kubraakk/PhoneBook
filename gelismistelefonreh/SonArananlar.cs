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

namespace GelismisTelefonRehberi
{
    public partial class SonArananlar : Form
    {
        int sayac = 0;
        private SqlConnection connection = null;
        private string ad, soyad, telefon, tur;
        public SonArananlar(string column1, string column2, string column3, string column4)
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True;");
            ad = column1;
            soyad = column2;
            string cleanedPhoneNumber = new string(column3.Where(char.IsDigit).ToArray());
            telefon = cleanedPhoneNumber;
            tur = column4;

        }

        private void SonArananlar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(233, 233, 233);
            statusStripLast.BackColor = Color.FromArgb(76, 92, 115);

            listViewLast.BackColor = Color.FromArgb(233, 233, 233);
            listViewLast.View = View.Details;

            listViewLast.Columns.Add("Ad", 110);
            listViewLast.Columns.Add("Soyad", 110);
            listViewLast.Columns.Add("Numara", 110);
            listViewLast.Columns.Add("Telefon Türü", 110);
            listViewLast.Items.Clear();

            connection.Open();

            string insertQuery = "INSERT INTO SonAramalar (aramaID) VALUES ((SELECT TOP 1 tel_id FROM TelRehber WHERE Tel = @Telefon))";
            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@Ad", ad);
                insertCommand.Parameters.AddWithValue("@Soyad", soyad);
                insertCommand.Parameters.AddWithValue("@Telefon", telefon);
                insertCommand.Parameters.AddWithValue("@Tur", tur);

                insertCommand.ExecuteNonQuery();

            }
            listViewLast.Items.Clear();

            string selectQuery = "select ad,soyad,tel,tur from TelRehber JOIN SonAramalar ON TelRehber.tel_id = SonAramalar.aramaID ORDER BY SonAramalar.ID DESC;";
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

                        listViewLast.Items.Add(new ListViewItem(new[] { ad, soyad, telefon, tur }) { ImageIndex = 2 });
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            toolStripStatusLabelTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            toolStripStatusLabelTime.Alignment = ToolStripItemAlignment.Left;
            toolStripStatusLabelLast.Text = "Son Aramalar: " + listViewLast.Items.Count.ToString();
            toolStripStatusLabelLast.Alignment = ToolStripItemAlignment.Right;
            sayac++;
        }
    }
}
