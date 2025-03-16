using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_V5
{
    public partial class KitapDüzenleForm : Form
    {
        private void Listele()
        {
            // SQLite bağlantı dizesi
            string connectionString = "Data Source=C:\\Users\\ahmet\\source\\repos\\BookStore_V5\\BookStore_V5\\bin\\Debug\\mydatabase.db;Version=3;";

            // Verileri listelemek için SQL komutu
            string query = "SELECT * FROM Books ORDER BY BookID DESC";

            // Bağlantı ve komut işlemleri
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Bağlantıyı aç
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                    // Verileri DataTable'a doldur
                    DataTable dataTable3 = new DataTable();
                    adapter.Fill(dataTable3);

                    // DataGridView'e bağla
                    dataGridView3.DataSource = dataTable3;
                }
                catch (Exception ex)
                {
                    // Hata durumunda mesaj göster
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Bağlantıyı kapat
                }
            }
        }
        public KitapDüzenleForm()
        {
            InitializeComponent();
            Listele();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_yönetim_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            new KitapEkleForm().Show();
            this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {


            if (int.TryParse(textBox_DüzenlenecekID.Text, out int kitapID))
            {
                // KitapDüzenleForm'u aç ve ID'yi gönder
                new bookupdatescreen(kitapID).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir kitap ID'si girin.");
            }




        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            new KitapSilForm().Show();
            this.Hide();
        }

        private void button_çıkış_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
