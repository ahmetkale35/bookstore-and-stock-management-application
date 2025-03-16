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
    public partial class KitapEkleForm : Form
    {
        public KitapEkleForm()
        {
            InitializeComponent();
        }

        private void panel_cover_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_AD_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            {
                // SQLite bağlantı dizesi
                string connectionString = "Data Source=C:\\Users\\ahmet\\source\\repos\\BookStore_V5\\BookStore_V5\\bin\\Debug\\mydatabase.db;Version=3;";

                // SQL INSERT komutu
                string query = @"
        INSERT INTO Books 
        (Title, Author, Genre, Publisher, PublicationDate, ISBN, Price, Stock, Language, PageCount, Description, CoverImage)
        VALUES 
        (@Title, @Author, @Genre, @Publisher, @PublicationDate, @ISBN, @Price, @Stock, @Language, @PageCount, @Description, @CoverImage)";

                // Verileri kontrol eden ve komutu çalıştıran bağlantı bloğu
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        connection.Open(); // Bağlantıyı aç


                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            // TextBox ve diğer kontrollerden verileri al
                            command.Parameters.AddWithValue("@Title", textBox_AD.Text);
                            command.Parameters.AddWithValue("@Author", textBox_YAZAR.Text);
                            command.Parameters.AddWithValue("@Genre", textBox_TÜR.Text);
                            command.Parameters.AddWithValue("@Publisher", textBox_YAYINCI.Text);
                            command.Parameters.AddWithValue("@PublicationDate", yayınlanmaTarihi.Value.Date);
                            command.Parameters.AddWithValue("@ISBN", textBox_ISBN.Text);
                            command.Parameters.AddWithValue("@Price", int.Parse(textBox_FİYAT.Text));
                            command.Parameters.AddWithValue("@Stock", int.Parse(textBox_ADET.Text));
                            command.Parameters.AddWithValue("@Language", textBox_DİL.Text);
                            command.Parameters.AddWithValue("@PageCount", int.Parse(textBox_SAYFA.Text));
                            command.Parameters.AddWithValue("@Description", textBox_AÇIKLAMA.Text);
                            command.Parameters.AddWithValue("@CoverImage", textBox_IMAGE.Text);
                            // command.Parameters.AddWithValue("@CoverImage", txtCoverImage.Text);

                            // Komutu çalıştır
                            command.ExecuteNonQuery();
                            MessageBox.Show("Kitap başarıyla eklendi!");
                            new MainForm().Show();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata mesajı göster
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); // Bağlantıyı kapat
                    }
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_AD.Clear();
            textBox_ADET.Clear();
            textBox_AÇIKLAMA.Clear();
            textBox_DİL.Clear();
            textBox_FİYAT.Clear();
            textBox_ISBN.Clear();
            textBox_SAYFA.Clear();
            textBox_TÜR.Clear();
            textBox_YAYINCI.Clear();
            textBox_YAZAR.Clear();

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Close();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            new KitapSilForm().Show();
            this.Close();
        }

        private void button_yönetim_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_resimSeç_Click(object sender, EventArgs e)
        {
            {
                // OpenFileDialog kullanarak resim dosyası seçme
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                openFileDialog.Title = "Bir resim seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen resim dosyasının yolunu bir TextBox'a veya değişkene at
                    textBox_IMAGE.Text = openFileDialog.FileName;

                    // Resmi PictureBox içinde göster
                    pictureBox_Cover.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox_Cover.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

       
    }
}
