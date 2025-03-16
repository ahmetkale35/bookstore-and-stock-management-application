using System.Drawing;
using System.Windows.Forms;

namespace BookStore_V5
{
    partial class RegisterForm
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
            ClearButton = new Button();
            label_Username = new Label();
            toLoginButton = new Label();
            label2 = new Label();
            RegisterButton = new Button();
            Passwordtxt = new TextBox();
            label_Password = new Label();
            Usernametxt = new TextBox();
            label_GetStarted = new Label();
            PasswordConfirmtxt = new TextBox();
            PasswordConfirmLabel = new Label();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.White;
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.ForeColor = Color.MediumSlateBlue;
            ClearButton.Location = new Point(77, 667);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(341, 46);
            ClearButton.TabIndex = 51;
            ClearButton.Text = "CLEAR";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Username.ForeColor = Color.Gray;
            label_Username.Location = new Point(77, 222);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(106, 28);
            label_Username.TabIndex = 50;
            label_Username.Text = "Username";
            // 
            // toLoginButton
            // 
            toLoginButton.AutoSize = true;
            toLoginButton.ForeColor = Color.MediumSlateBlue;
            toLoginButton.Location = new Point(195, 813);
            toLoginButton.Name = "toLoginButton";
            toLoginButton.Size = new Size(99, 20);
            toLoginButton.TabIndex = 49;
            toLoginButton.Text = "Back to Login";
            toLoginButton.Click += toLoginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(155, 769);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 48;
            label2.Text = "Already Have an Account";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.MediumSlateBlue;
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(77, 599);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(341, 46);
            RegisterButton.TabIndex = 47;
            RegisterButton.Text = "REGISTER";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // Passwordtxt
            // 
            Passwordtxt.BackColor = Color.Gainsboro;
            Passwordtxt.Font = new Font("MS Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Passwordtxt.Location = new Point(77, 361);
            Passwordtxt.Multiline = true;
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(341, 44);
            Passwordtxt.TabIndex = 45;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Password.ForeColor = Color.Gray;
            label_Password.Location = new Point(77, 330);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(100, 28);
            label_Password.TabIndex = 44;
            label_Password.Text = "Password";
            // 
            // Usernametxt
            // 
            Usernametxt.BackColor = Color.Gainsboro;
            Usernametxt.Font = new Font("MS Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Usernametxt.Location = new Point(77, 253);
            Usernametxt.Multiline = true;
            Usernametxt.Name = "Usernametxt";
            Usernametxt.Size = new Size(341, 44);
            Usernametxt.TabIndex = 43;
            // 
            // label_GetStarted
            // 
            label_GetStarted.AutoSize = true;
            label_GetStarted.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_GetStarted.ForeColor = Color.MediumSlateBlue;
            label_GetStarted.Location = new Point(71, 117);
            label_GetStarted.Name = "label_GetStarted";
            label_GetStarted.Size = new Size(194, 34);
            label_GetStarted.TabIndex = 42;
            label_GetStarted.Text = "Get Started";
            // 
            // PasswordConfirmtxt
            // 
            PasswordConfirmtxt.BackColor = Color.Gainsboro;
            PasswordConfirmtxt.Font = new Font("MS Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            PasswordConfirmtxt.Location = new Point(77, 469);
            PasswordConfirmtxt.Multiline = true;
            PasswordConfirmtxt.Name = "PasswordConfirmtxt";
            PasswordConfirmtxt.Size = new Size(341, 44);
            PasswordConfirmtxt.TabIndex = 52;
            // 
            // PasswordConfirmLabel
            // 
            PasswordConfirmLabel.AutoSize = true;
            PasswordConfirmLabel.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordConfirmLabel.ForeColor = Color.Gray;
            PasswordConfirmLabel.Location = new Point(77, 438);
            PasswordConfirmLabel.Name = "PasswordConfirmLabel";
            PasswordConfirmLabel.Size = new Size(182, 28);
            PasswordConfirmLabel.TabIndex = 53;
            PasswordConfirmLabel.Text = "Password Confirm";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 912);
            Controls.Add(PasswordConfirmLabel);
            Controls.Add(PasswordConfirmtxt);
            Controls.Add(ClearButton);
            Controls.Add(label_Username);
            Controls.Add(toLoginButton);
            Controls.Add(label2);
            Controls.Add(RegisterButton);
            Controls.Add(Passwordtxt);
            Controls.Add(label_Password);
            Controls.Add(Usernametxt);
            Controls.Add(label_GetStarted);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Label label_Username;
        private Label toLoginButton;
        private Label label2;
        private Button RegisterButton;
        private TextBox Passwordtxt;
        private Label label_Password;
        private TextBox Usernametxt;
        private Label label_GetStarted;
        private TextBox PasswordConfirmtxt;
        private Label PasswordConfirmLabel;
    }
}