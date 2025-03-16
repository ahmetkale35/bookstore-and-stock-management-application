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
    public partial class LoginForm : Form
    {
        private SQLiteConnection connection2;
        public LoginForm()
        {
            InitializeComponent();
            connection2 = new SQLiteConnection(@"Data Source=C:\Users\ahmet\source\repos\BookStore_V5\BookStore_V5\bin\Debug\mydatabase.db;Version=3;");

        }
        public static class LoginUser
        {
            public static string UserNameforlabel { get; set; }
            public static string UserEmailforlabel { get; set; }
            public static int UserID { get; set; }
            public static string UserFullName { get; set; }
            public static string UserAddressforlabel { get; set; }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Şifreyi gizle
            if (Passwordtxt != null && Passwordtxt.PasswordChar != '*')
            {
                Passwordtxt.PasswordChar = '*';
            }
        }




        private void toRegisterButton_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            {


                try
                {
                    string username = Usernametxt.Text.Trim();
                    string password = Passwordtxt.Text.Trim();
                    connection2.Open();

                    string query = "SELECT UserID, FullName, Address, Email FROM Users WHERE Username = @Username AND PasswordHash = @Password";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection2))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Giriş başarılı, kullanıcı bilgilerini sakla
                                // LoginUser.UserID = Convert.ToInt32(reader["UserID"]);

                                LoginUser.UserFullName = reader["FullName"].ToString();
                                LoginUser.UserAddressforlabel = reader["Address"].ToString();
                                LoginUser.UserEmailforlabel = reader["Email"].ToString();

                                // MessageBox.Show($"Hoşgeldiniz, {LoginUser.UserFullName}!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Ana sayfaya yönlendirme
                                // MağazaForm1 storeForm = new MağazaForm1();
                                // storeForm.Show();
                                // this.Hide();
                            }
                            else
                            {
                                // MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Kullanıcı adı ve şifre boş mu kontrol et
                if (string.IsNullOrEmpty(Usernametxt.Text) || string.IsNullOrEmpty(Passwordtxt.Text))
                {
                    MessageBox.Show("User name and Password fields cannot be empty.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                try
                {
                    // SQLite bağlantısı
                    string databasePath = @"Data Source=C:\Users\ahmet\source\repos\BookStore_V5\BookStore_V5\bin\Debug\mydatabase.db;Version=3;";
                    using (SQLiteConnection connection = new SQLiteConnection(databasePath))
                    {
                        connection.Open();

                        // Kullanıcı adıyla şifre hash'ini sorgula
                        string query = "SELECT PasswordHash FROM Users WHERE Username = @Username";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", Usernametxt.Text);

                            object result = command.ExecuteScalar(); // Kullanıcı şifresini al

                            if (result != null)
                            {
                                string storedPasswordHash = result.ToString();

                                // Şifreyi doğrula
                                if (storedPasswordHash == Passwordtxt.Text) // Hash karşılaştırması yapılabilir
                                {
                                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    new MağazaForm1().Show();
                                    this.Hide();



                                }
                                else
                                {
                                    MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (Usernametxt.Text == "admin" && Passwordtxt.Text == "1234")
                            {
                                MessageBox.Show("Yönetici Girişi Yapıldı.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                new MainForm().Show();

                                this.Hide();

                            }


                            //if(Usernametxt.Text != "admin")
                            //  MessageBox.Show("Giriş Başarılı İyi Alışverişler", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }



                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Usernametxt.Clear();
            Passwordtxt.Clear();
        }




        private void toRegisterButton_Click_1(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void button_mağaza_Click(object sender, EventArgs e)
        {
            new MağazaForm1().Show();
            this.Hide();
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox işaretlendiğinde şifreyi göster/gizle
            if (checkBox31.Checked)
            {
                Passwordtxt.PasswordChar = '\0'; // Şifreyi açık göster
            }
            else
            {
                Passwordtxt.PasswordChar = '*'; // Şifreyi gizle
            }
        }
    }
}
