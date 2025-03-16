using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_V5
{
    public partial class MağazaForm1 : Form
    {
        private SQLiteConnection connection;
        private string imageFolderPath = @"C:\Users\ahmet\source\repos\BookStore_V5\IMAGES\";
        private List<int> cart;  // Sepet listesi

        public MağazaForm1()
        {
            InitializeComponent();
            connection = new SQLiteConnection("Data Source=C:\\Users\\ahmet\\source\\repos\\BookStore_V5\\BookStore_V5\\bin\\Debug\\mydatabase.db;Version=3;");
            cart = new List<int>(); // Sepet başlatma
        }

        private void MağazaForm1_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                flowLayoutPanelStore.Controls.Clear(); // Paneli temizle
                connection.Open();

                string query = "SELECT BookID, Title, Price, CoverImage FROM Books";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Kitap bilgilerini al
                        int bookID = Convert.ToInt32(reader["BookID"]);
                        string title = reader["Title"].ToString();
                        decimal price = Convert.ToDecimal(reader["Price"]);
                        string imagePath = Path.Combine(imageFolderPath, reader["CoverImage"].ToString());

                        // Dinamik kontrol oluştur
                        Panel bookPanel = CreateBookPanel(bookID, title, price, imagePath);
                        flowLayoutPanelStore.Controls.Add(bookPanel);
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

        private Panel CreateBookPanel(int bookID, string title, decimal price, string imagePath)
        {
            // Panel
            Panel panel = new Panel
            {
                Width = 150,
                Height = 300, // Panel yüksekliğini artırdık
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            // PictureBox (Kitap Resmi)
            PictureBox pictureBox = new PictureBox
            {
                Width = 130,
                Height = 150,
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            string defaultImagePath = @"C:\Users\ahmet\source\repos\BookStore_V5\IMAGES\defaultImage.png";

            if (File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            else if (File.Exists(defaultImagePath))
            {
                pictureBox.Image = Image.FromFile(defaultImagePath);
            }
            else
            {
                MessageBox.Show("Varsayılan resim bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Label (Kitap Adı)
            Label lblTitle = new Label
            {
                Text = title,
                Width = 130,
                Height = 40,
                Location = new Point(10, 170),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoEllipsis = true // Uzun isimler için
            };

            // Fiyat Bilgisi Label
            Label lblPrice = new Label
            {
                Text = price.ToString("C2"), // Fiyatı ₺ sembolü ile gösterir, 2 ondalıklı
                AutoSize = false,
                Width = 130, // Etiket genişliğini 130 olarak ayarla (kitap adıyla uyumlu)
                Height = 30, // Yüksekliği artırarak görünürlüğü sağla
                Top = lblTitle.Bottom + 5, // Fiyatı başlığın altına yerleştir
                Left = 5,
                ForeColor = Color.Green,
                Font = new Font("Arial", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Button (Sepete Ekle)
            Button btnAddToCart = new Button
            {
                Text = "Sepete Ekle",
                Width = 130,
                Height = 30,
                Location = new Point(10, lblPrice.Bottom + 5), // Buton fiyat etiketinin altına yerleşecek
                Tag = bookID // Kitap ID'sini sakla
            };
            btnAddToCart.Click += BtnAddToCart_Click;

            // Kontrolleri panele ekle
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lblTitle);
            panel.Controls.Add(lblPrice); // Fiyat etiketini de ekle
            panel.Controls.Add(btnAddToCart); // Sepete Ekle butonunu ekle

            return panel;
        }

        // Sepete ekleme işlemi
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int bookID = (int)btn.Tag; // Sepete eklenecek kitabın ID'si

            // Sepet listesine kitabı ekleme işlemi
            if (!cart.Contains(bookID))
            {
                cart.Add(bookID);
                MessageBox.Show($"Kitap ID: {bookID} sepete eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Kitap ID: {bookID} zaten sepette!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Sepet güncelleme işlemi yapılabilir, örneğin başka bir formda gösterim
        }

        // Sepeti gösterme ve işlemleri başlatma




        private void SepeteGit_Click(object sender, EventArgs e)
        {
            // SepetimForm'a mevcut sepeti (cart listesi) aktar
            SepetimForm sepetimForm = new SepetimForm(cart);
            sepetimForm.Show(); // SepetimForm'u aç

            this.Hide(); // MağazaForm'u gizle
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            new SepetimForm(cart).Show();
            this.Hide();
        }

        private void button_satışR_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void button_sepetim_Click(object sender, EventArgs e)
        {
            new SepetimForm(cart).Show();
            this.Hide();
        }

        private void button_satışR_Click_1(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
