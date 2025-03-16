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
using static BookStore_V5.LoginForm;

namespace BookStore_V5
{
    public partial class SepetimForm : Form
    {
        private List<int> cart; // Sepetteki BookID'ler
        private SQLiteConnection connection;

        public SepetimForm(List<int> cart)
        {
            InitializeComponent();
            this.cart = cart; // MağazaForm'dan gelen sepetteki ID listesi
            connection = new SQLiteConnection("Data Source=C:\\Users\\ahmet\\source\\repos\\BookStore v2\\BookStore v2\\bin\\Debug\\mydatabase.db;Version=3;");
            this.Load += new EventHandler(SepetimForm_Load); // Load olayını bağla
        }

        private void SepetimForm_Load(object sender, EventArgs e)
        {
            labeladressepet.Text = $"Adresiniz: {LoginUser.UserAddressforlabel}";
            labelİsimSepet.Text = $"Kişisel Bilgiler: {LoginUser.UserFullName}";
            labelemailsepet.Text = $"E-Mail : {LoginUser.UserEmailforlabel}";
            //  MessageBox.Show("LOADİNG", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewSepetim.Columns.Clear();

            // Sadece Kitap Adı ve Fiyat için kolonları ekle
            dataGridViewSepetim.Columns.Add("Title", "Kitap İsmi");
            dataGridViewSepetim.Columns.Add("Price", "Fiyat");
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            dataGridViewSepetim.Rows.Clear(); // DataGridView'i temizle
            decimal totalPrice = 0;

            foreach (var bookID in cart)
            {
                // Kitap bilgilerini veritabanından çek
                string query = "SELECT Title, Price FROM Books WHERE BookID = @BookID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    connection.Open();

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string title = reader["Title"].ToString();
                            decimal price = Convert.ToDecimal(reader["Price"]);

                            // DataGridView'e sadece kitap adı ve fiyatını ekle
                            dataGridViewSepetim.Rows.Add(title, price.ToString("C2")); // Fiyatı ₺ formatında göster
                            totalPrice += price;
                        }
                    }

                    connection.Close();
                }
            }
            totalfiyargösterge.Text = $"Toplam Fiyat: {totalPrice:C2}";
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            new MağazaForm1().Show();
            this.Hide();
        }

        private void button_satınal_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Sepetteki kitaplar için stokları 1 azaltma işlemi
                foreach (var bookID in cart)
                {
                    string query = "UPDATE Books SET Stock = Stock - 1 WHERE BookID = @BookID";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        cmd.ExecuteNonQuery(); // Stok miktarını güncelle
                    }
                }

                connection.Close();

                // Satın alma işlemi tamamlandığında bir mesaj göster
                MessageBox.Show("Satın alma işlemi başarılı. Stoklar güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Satın alma işleminden sonra SepetForm'u temizleyebiliriz (isteğe bağlı)
                cart.Clear();  // Sepeti temizle
                dataGridViewSepetim.Rows.Clear();  // DataGridView'i temizle
                totalfiyargösterge.Text = "Toplam Fiyat: 0.00 ₺";  // Toplam fiyatı sıfırla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_satışR_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void userAdressLabel_Click(object sender, EventArgs e)
        {

        }

       
    }
    }

