using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStore_V5
{
    partial class MağazaForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MağazaForm1));
            this.button_yönetim = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.flowLayoutPanelStore = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SepeteGit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_menu2 = new System.Windows.Forms.Panel();
            this.button_satışR = new System.Windows.Forms.Button();
            this.button_ürünR = new System.Windows.Forms.Button();
            this.button_Raporlar = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_düzenle = new System.Windows.Forms.Button();
            this.button_sepetim = new System.Windows.Forms.Button();
            this.button_Anasayfa = new System.Windows.Forms.Button();
            this.panel_logo.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_cover.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_menu2.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_yönetim
            // 
            this.button_yönetim.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_yönetim.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_yönetim.Location = new System.Drawing.Point(0, 100);
            this.button_yönetim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_yönetim.Name = "button_yönetim";
            this.button_yönetim.Size = new System.Drawing.Size(250, 54);
            this.button_yönetim.TabIndex = 1;
            this.button_yönetim.Text = "Mağaza";
            this.button_yönetim.UseVisualStyleBackColor = true;
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.label3);
            this.panel_logo.Controls.Add(this.label2);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(250, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "HOŞGELDİNİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Webdings", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "Z";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(250, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1145, 713);
            this.panel_main.TabIndex = 5;
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.flowLayoutPanelStore);
            this.panel_cover.Controls.Add(this.panel4);
            this.panel_cover.Controls.Add(this.panel3);
            this.panel_cover.Controls.Add(this.panel2);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(0, 0);
            this.panel_cover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(1145, 713);
            this.panel_cover.TabIndex = 0;
            // 
            // flowLayoutPanelStore
            // 
            this.flowLayoutPanelStore.AutoScroll = true;
            this.flowLayoutPanelStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelStore.Location = new System.Drawing.Point(0, 154);
            this.flowLayoutPanelStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelStore.Name = "flowLayoutPanelStore";
            this.flowLayoutPanelStore.Size = new System.Drawing.Size(1145, 459);
            this.flowLayoutPanelStore.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.SepeteGit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 613);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1145, 100);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(991, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "SEPET GİT";
            // 
            // SepeteGit
            // 
            this.SepeteGit.BackColor = System.Drawing.Color.AliceBlue;
            this.SepeteGit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SepeteGit.BackgroundImage")));
            this.SepeteGit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SepeteGit.Location = new System.Drawing.Point(1011, 20);
            this.SepeteGit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SepeteGit.Name = "SepeteGit";
            this.SepeteGit.Size = new System.Drawing.Size(85, 53);
            this.SepeteGit.TabIndex = 2;
            this.SepeteGit.UseVisualStyleBackColor = false;
            this.SepeteGit.Click += new System.EventHandler(this.SepeteGit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1145, 54);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 45);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.panel_menu2);
            this.panel1.Controls.Add(this.button_Raporlar);
            this.panel1.Controls.Add(this.panel_menu);
            this.panel1.Controls.Add(this.button_yönetim);
            this.panel1.Controls.Add(this.panel_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 713);
            this.panel1.TabIndex = 4;
            // 
            // panel_menu2
            // 
            this.panel_menu2.Controls.Add(this.button_satışR);
            this.panel_menu2.Controls.Add(this.button_ürünR);
            this.panel_menu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu2.Location = new System.Drawing.Point(0, 377);
            this.panel_menu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_menu2.Name = "panel_menu2";
            this.panel_menu2.Size = new System.Drawing.Size(250, 116);
            this.panel_menu2.TabIndex = 4;
            // 
            // button_satışR
            // 
            this.button_satışR.FlatAppearance.BorderSize = 0;
            this.button_satışR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_satışR.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_satışR.ForeColor = System.Drawing.Color.White;
            this.button_satışR.Location = new System.Drawing.Point(0, 55);
            this.button_satışR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_satışR.Name = "button_satışR";
            this.button_satışR.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_satışR.Size = new System.Drawing.Size(244, 50);
            this.button_satışR.TabIndex = 1;
            this.button_satışR.Text = "Çıkış Yap";
            this.button_satışR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_satışR.UseVisualStyleBackColor = true;
            this.button_satışR.Click += new System.EventHandler(this.button_satışR_Click_1);
            // 
            // button_ürünR
            // 
            this.button_ürünR.FlatAppearance.BorderSize = 0;
            this.button_ürünR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ürünR.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ürünR.ForeColor = System.Drawing.Color.White;
            this.button_ürünR.Location = new System.Drawing.Point(3, 0);
            this.button_ürünR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ürünR.Name = "button_ürünR";
            this.button_ürünR.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_ürünR.Size = new System.Drawing.Size(244, 50);
            this.button_ürünR.TabIndex = 0;
            this.button_ürünR.Text = "Siğarişlerim";
            this.button_ürünR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ürünR.UseVisualStyleBackColor = true;
            // 
            // button_Raporlar
            // 
            this.button_Raporlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Raporlar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Raporlar.Location = new System.Drawing.Point(0, 323);
            this.button_Raporlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Raporlar.Name = "button_Raporlar";
            this.button_Raporlar.Size = new System.Drawing.Size(250, 54);
            this.button_Raporlar.TabIndex = 3;
            this.button_Raporlar.Text = "Hesap Bilgilerim";
            this.button_Raporlar.UseVisualStyleBackColor = true;
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.button_düzenle);
            this.panel_menu.Controls.Add(this.button_sepetim);
            this.panel_menu.Controls.Add(this.button_Anasayfa);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 154);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(250, 169);
            this.panel_menu.TabIndex = 2;
            // 
            // button_düzenle
            // 
            this.button_düzenle.FlatAppearance.BorderSize = 0;
            this.button_düzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_düzenle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_düzenle.ForeColor = System.Drawing.Color.White;
            this.button_düzenle.Location = new System.Drawing.Point(3, 110);
            this.button_düzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_düzenle.Name = "button_düzenle";
            this.button_düzenle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_düzenle.Size = new System.Drawing.Size(244, 50);
            this.button_düzenle.TabIndex = 1;
            this.button_düzenle.Text = "Çok Satanlar";
            this.button_düzenle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_düzenle.UseVisualStyleBackColor = true;
            // 
            // button_sepetim
            // 
            this.button_sepetim.FlatAppearance.BorderSize = 0;
            this.button_sepetim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sepetim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sepetim.ForeColor = System.Drawing.Color.White;
            this.button_sepetim.Location = new System.Drawing.Point(0, 55);
            this.button_sepetim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_sepetim.Name = "button_sepetim";
            this.button_sepetim.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_sepetim.Size = new System.Drawing.Size(244, 50);
            this.button_sepetim.TabIndex = 1;
            this.button_sepetim.Text = "Sepetim";
            this.button_sepetim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sepetim.UseVisualStyleBackColor = true;
            this.button_sepetim.Click += new System.EventHandler(this.button_sepetim_Click);
            // 
            // button_Anasayfa
            // 
            this.button_Anasayfa.FlatAppearance.BorderSize = 0;
            this.button_Anasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Anasayfa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Anasayfa.ForeColor = System.Drawing.Color.White;
            this.button_Anasayfa.Location = new System.Drawing.Point(3, 0);
            this.button_Anasayfa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Anasayfa.Name = "button_Anasayfa";
            this.button_Anasayfa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Anasayfa.Size = new System.Drawing.Size(244, 50);
            this.button_Anasayfa.TabIndex = 0;
            this.button_Anasayfa.Text = "Ana Sayfa";
            this.button_Anasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Anasayfa.UseVisualStyleBackColor = true;
            this.button_Anasayfa.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // MağazaForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 713);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MağazaForm1";
            this.Text = "MağazaForm1";
            this.Load += new System.EventHandler(this.MağazaForm1_Load);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_menu2.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_yönetim;
        private Panel panel_logo;
        private Label label3;
        private Label label2;
        private Panel panel_main;
        private Panel panel_cover;
        private FlowLayoutPanel flowLayoutPanelStore;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Panel panel_menu2;
        private Button button_satışR;
        private Button button_ürünR;
        private Button button_Raporlar;
        private Panel panel_menu;
        private Button button_düzenle;
        private Button button_sepetim;
        private Button button_Anasayfa;
        private Button SepeteGit;
        private Label label4;
    }
}