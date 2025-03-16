using System.Drawing;
using System.Windows.Forms;

namespace BookStore_V5
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toRegisterButton = new Label();
            label2 = new Label();
            LoginButton = new Button();
            Passwordtxt = new TextBox();
            label_Password = new Label();
            Usernametxt = new TextBox();
            label_GetStarted = new Label();
            ClearButton = new Button();
            label_Username = new Label();
            checkBox31 = new CheckBox();
            SuspendLayout();
            // 
            // toRegisterButton
            // 
            toRegisterButton.AutoSize = true;
            toRegisterButton.ForeColor = Color.MediumSlateBlue;
            toRegisterButton.Location = new Point(185, 764);
            toRegisterButton.Name = "toRegisterButton";
            toRegisterButton.Size = new Size(110, 20);
            toRegisterButton.TabIndex = 33;
            toRegisterButton.Text = "Create Account";
            toRegisterButton.Click += toRegisterButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(155, 708);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 32;
            label2.Text = "Dont Have an Account ?";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.MediumSlateBlue;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(74, 530);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(341, 46);
            LoginButton.TabIndex = 30;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // Passwordtxt
            // 
            Passwordtxt.BackColor = Color.Gainsboro;
            Passwordtxt.Font = new Font("MS Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Passwordtxt.Location = new Point(74, 333);
            Passwordtxt.Multiline = true;
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(341, 44);
            Passwordtxt.TabIndex = 28;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Password.ForeColor = Color.Gray;
            label_Password.Location = new Point(74, 302);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(100, 28);
            label_Password.TabIndex = 27;
            label_Password.Text = "Password";
            // 
            // Usernametxt
            // 
            Usernametxt.BackColor = Color.Gainsboro;
            Usernametxt.Font = new Font("MS Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Usernametxt.Location = new Point(74, 225);
            Usernametxt.Multiline = true;
            Usernametxt.Name = "Usernametxt";
            Usernametxt.Size = new Size(341, 44);
            Usernametxt.TabIndex = 26;
            // 
            // label_GetStarted
            // 
            label_GetStarted.AutoSize = true;
            label_GetStarted.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_GetStarted.ForeColor = Color.MediumSlateBlue;
            label_GetStarted.Location = new Point(61, 88);
            label_GetStarted.Name = "label_GetStarted";
            label_GetStarted.Size = new Size(194, 34);
            label_GetStarted.TabIndex = 24;
            label_GetStarted.Text = "Get Started";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.White;
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.ForeColor = Color.MediumSlateBlue;
            ClearButton.Location = new Point(74, 611);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(341, 46);
            ClearButton.TabIndex = 41;
            ClearButton.Text = "CLEAR";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Username.ForeColor = Color.Gray;
            label_Username.Location = new Point(74, 194);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(106, 28);
            label_Username.TabIndex = 35;
            label_Username.Text = "Username";
            // 
            // checkBox31
            // 
            checkBox31.AutoSize = true;
            checkBox31.Location = new Point(296, 397);
            checkBox31.Name = "checkBox31";
            checkBox31.Size = new Size(119, 24);
            checkBox31.TabIndex = 42;
            checkBox31.Text = "Şifreyi Göster";
            checkBox31.UseVisualStyleBackColor = true;
            checkBox31.CheckedChanged += checkBox31_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 882);
            Controls.Add(checkBox31);
            Controls.Add(ClearButton);
            Controls.Add(label_Username);
            Controls.Add(toRegisterButton);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            Controls.Add(Passwordtxt);
            Controls.Add(label_Password);
            Controls.Add(Usernametxt);
            Controls.Add(label_GetStarted);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label toRegisterButton;
        private Label label2;
        private Button LoginButton;
        private TextBox Passwordtxt;
        private Label label_Password;
        private TextBox Usernametxt;
        private Label label_GetStarted;
        private Button ClearButton;
        private Label label_Username;
        private CheckBox checkBox31;
    }
}