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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private SQLiteConnection connection31;
        SQLiteConnection baglan = new SQLiteConnection("Data Source=C:\\Users\\ahmet\\source\\repos\\BookStore_V5\\BookStore_V5\\bin\\Debug\\mydatabase.db;Version=3;");

        private void MainForm_Load(object sender, EventArgs e)
        {
            Listele();
            connection31 = new SQLiteConnection("Data Source=C:\\Users\\ahmet\\source\\repos\\BookStore_V5\\BookStore_V5\\bin\\Debug\\mydatabase.db;Version=3;");
            connection31.Open();

            GetTotalBookCount();
            GetTotalUserCount();
        }
        private void customizeDesign()
        {
            panel_menu.Visible = false;
            panel_menu2.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_menu.Visible == true)
                panel_menu.Visible = false;
            if (panel_menu2.Visible == true)
                panel_menu2.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

        }


        private void GetTotalUserCount()
        {
            try
            {
                // Toplam kullanıcı sayısını al
                string kullaniciSayisiSorgu = "SELECT COUNT(*) FROM Users";
                using (var command = new SQLiteCommand(kullaniciSayisiSorgu, connection31))
                {
                    var toplamKullaniciSayisi = command.ExecuteScalar();
                    toplamkitapsayiysi.Text = "Toplam Kayıtlı Kullanıcı Sayısı: " + toplamKullaniciSayisi.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        private void GetTotalBookCount()
        {
            try
            {
                // Toplam kitap sayısını al
                string kitapSayisiSorgu = "SELECT COUNT(*) FROM Books";
                using (var command = new SQLiteCommand(kitapSayisiSorgu, connection31))
                {
                    var toplamKitapSayisi = command.ExecuteScalar();
                    KitapSAyıyısıLabel.Text = "Toplam Kitap Sayısı: " + toplamKitapSayisi.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        #region Yönetim
        private void button_yönetim_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_menu);
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            new KitapEkleForm().Show();
            this.Hide();
            hideSubmenu();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            new KitapSilForm().Show();
            this.Hide();
            hideSubmenu();
        }

        private void button_düzenle_Click(object sender, EventArgs e)
        {
            new KitapDüzenleForm().Show();
            this.Hide();
            hideSubmenu();
        }

        private void button_showall_Click(object sender, EventArgs e)
        {
            // code
            hideSubmenu();
        }
        #endregion Yönetim

        #region Raporlar
        private void button_Raporlar_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_menu2);
        }

        private void button_ürünR_Click(object sender, EventArgs e)
        {
            // code
            hideSubmenu();
        }

        private void button_satışR_Click(object sender, EventArgs e)
        {
            //  new SatışFormu1().Show();
            this.Hide();
            hideSubmenu();
        }
        #endregion Raporlar
        private void button_çıkış_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
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
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e bağla
                    dataGridView1.DataSource = dataTable;
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

        private void button_yenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

       


       
    }
}
