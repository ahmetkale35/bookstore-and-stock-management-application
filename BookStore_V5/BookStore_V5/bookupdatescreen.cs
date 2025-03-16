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
    public partial class bookupdatescreen : Form
    {
        private int kitapID;
        private SQLiteConnection connection;


        public bookupdatescreen(int kitapID)
        {
            InitializeComponent();
            this.kitapID = kitapID;
            connection = new SQLiteConnection("Data Source=C:\\Users\\ahmet\\source\\repos\\BookStore_V5\\BookStore_V5\\bin\\Debug\\mydatabase.db;Version=3;");
        }
        private void bookupdatescreen_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = @"SELECT Title, Author, Genre, Publisher, PublicationDate, ISBN, Price, Stock, Language, PageCount, Description FROM Books WHERE BookID = @BookID";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("BookID", kitapID);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBox_AD.Text = reader["Title"].ToString();
                        textBox_YAZAR.Text = reader["Author"].ToString();
                        textBox_TÜR.Text = reader["Genre"].ToString();
                        textBox_YAYINCI.Text = reader["Publisher"].ToString();
                        DateTime publicationDate = Convert.ToDateTime(reader["PublicationDate"]);
                        yayınlanmaTarihi.Value = publicationDate;
                        textBox_ISBN.Text = reader["ISBN"].ToString();
                        textBox_FİYAT.Text = reader["Price"].ToString();
                        textBox_ADET.Text = reader["Stock"].ToString();
                        textBox_DİL.Text = reader["Language"].ToString();
                        textBox_SAYFA.Text = reader["PageCount"].ToString();
                        textBox_AÇIKLAMA.Text = reader["Description"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen ID'ye ait kitap bulunamadı.");
                        this.Close();
                    }
                }
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

        private void button_save2_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcının girdiği değerleri değişkenlere al
                string title = textBox_AD.Text.Trim();
                string author = textBox_YAZAR.Text.Trim();
                string genre = textBox_TÜR.Text.Trim();
                string publisher = textBox_YAYINCI.Text.Trim();
                DateTime publicationDate = yayınlanmaTarihi.Value;
                string isbn = textBox_ISBN.Text.Trim();
                decimal price = Convert.ToDecimal(textBox_FİYAT.Text.Trim());
                int stock = Convert.ToInt32(textBox_ADET.Text.Trim());
                string language = textBox_DİL.Text.Trim();
                int pageCount = Convert.ToInt32(textBox_SAYFA.Text.Trim());
                string description = textBox_AÇIKLAMA.Text.Trim();
                string coverImage = textBox_IMAGE2.Text.Trim(); // Resim dosyasının yolu (yalnızca yol veya ismini saklıyorsunuz)

                // Veritabanı bağlantısını aç
                connection.Open();

                // UPDATE SQL sorgusu
                string updateQuery = @"UPDATE Books 
                               SET Title = @Title, 
                                   Author = @Author, 
                                   Genre = @Genre, 
                                   Publisher = @Publisher, 
                                   PublicationDate = @PublicationDate, 
                                   ISBN = @ISBN, 
                                   Price = @Price, 
                                   Stock = @Stock, 
                                   Language = @Language, 
                                   PageCount = @PageCount, 
                                   Description = @Description,
                                   CoverImage = @CoverImage 
                               WHERE BookID = @BookID";

                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@Genre", genre);
                    command.Parameters.AddWithValue("@Publisher", publisher);
                    command.Parameters.AddWithValue("@PublicationDate", publicationDate);
                    command.Parameters.AddWithValue("@ISBN", isbn);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Stock", stock);
                    command.Parameters.AddWithValue("@Language", language);
                    command.Parameters.AddWithValue("@PageCount", pageCount);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@CoverImage", coverImage); // CoverImage parametresi
                    command.Parameters.AddWithValue("@BookID", kitapID); // kitapID form yüklenirken atanmıştı

                    // Komutu çalıştır
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kitap bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new KitapDüzenleForm().Show();
                        this.Close(); // Güncelleme sonrası formu kapat
                    }
                    else
                    {
                        MessageBox.Show("Kitap güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button_resimyükle_Click(object sender, EventArgs e)
        {

            // OpenFileDialog kullanarak resim dosyası seçme
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFileDialog.Title = "Bir resim seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen resim dosyasının yolunu bir TextBox'a veya değişkene at
                textBox_IMAGE2.Text = openFileDialog.FileName;

                // Resmi PictureBox içinde göster
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
