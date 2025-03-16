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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Usernametxt.Text) || string.IsNullOrEmpty(Passwordtxt.Text) || string.IsNullOrEmpty(PasswordConfirmtxt.Text))
            {
                MessageBox.Show("User name and Password fields cannot be empty.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Passwordtxt.Text != PasswordConfirmtxt.Text)
            {
                MessageBox.Show("Passwords do not match.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\ahmet\\source\\repos\\BookStore_V5\\BookStore_V5\\bin\\Debug\\mydatabase.db;Version=3;"))
                {
                    connection.Open();

                    string query = "INSERT INTO Users (Username, PasswordHash) VALUES (@Username, @PasswordHash)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Usernametxt.Text);
                        command.Parameters.AddWithValue("@PasswordHash", Passwordtxt.Text); // Normalde şifreyi hashleyip kaydetmelisiniz.

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Usernametxt.Clear();
                    Passwordtxt.Clear();
                    PasswordConfirmtxt.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Usernametxt.Clear();
            Passwordtxt.Clear();
            PasswordConfirmtxt.Clear();
        }

        private void toLoginButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
