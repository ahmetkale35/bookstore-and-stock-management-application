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
    public partial class KitapSilForm : Form
    {
        public KitapSilForm()
        {
            InitializeComponent();
            Listele();
        }

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
                    DataTable dataTable2 = new DataTable();
                    adapter.Fill(dataTable2);

                    // DataGridView'e bağla
                    dataGridView2.DataSource = dataTable2;
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

        private void KitapCounter()
        {
            string connectionString = "Data Source=C:\\Users\\ahmet\\source\\repos\\BookStore_V5\\BookStore_V5\\bin\\Debug\\mydatabase.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Books";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    int kitapSayisi = Convert.ToInt32(command.ExecuteScalar());
                    ToplamKitapLabel.Text = "Toplam Kitap Sayısı: " + kitapSayisi.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {

            {
                // Silinecek ID'yi al
                string silinecekID = textBox_silinecekID.Text;

                // Kullanıcının boş bırakmasını engelle
                if (string.IsNullOrEmpty(silinecekID))
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kitabın ID'sini girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ID'nin geçerli bir sayı olup olmadığını kontrol et
                if (!int.TryParse(silinecekID, out int bookID))
                {
                    MessageBox.Show("Geçerli bir ID giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Veritabanı bağlantısını oluştur
                string connectionString = @"Data Source=C:\\Users\\ahmet\\source\\repos\\BookStore_V5\BookStore_V5\\bin\\Debug\\mydatabase.db;Version=3;";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        // Bağlantıyı aç
                        connection.Open();

                        // SQL DELETE komutunu hazırla
                        string deleteQuery = "DELETE FROM Books WHERE BookID = @BookID";

                        // Komut nesnesini oluştur
                        using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                        {
                            // Parametreyi ekle
                            command.Parameters.AddWithValue("@BookID", bookID);

                            // Komutu çalıştır ve etkilenen satır sayısını al
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Kitap başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBox_silinecekID.Clear();
                                // Listeyi yenilemek için listeleme fonksiyonunu çağırın
                                Listele();
                            }
                            else
                            {
                                MessageBox.Show("Silmek istediğiniz kitap bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Bağlantıyı kapat
                        if (connection.State == System.Data.ConnectionState.Open)
                            connection.Close();
                    }
                }
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_yönetim_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Close();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            new KitapEkleForm().Show();
            this.Close();
        }

        private void button_düzenle_Click(object sender, EventArgs e)
        {
            new KitapDüzenleForm().Show();
            this.Close();
        }

        private void button_çıkış_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
