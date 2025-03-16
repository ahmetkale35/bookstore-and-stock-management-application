using System.Drawing;
using System.Windows.Forms;

namespace BookStore_V5
{
    partial class MainForm
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
            panel1 = new Panel();
            button_çıkış = new Button();
            panel_menu2 = new Panel();
            button_satışR = new Button();
            button_ürünR = new Button();
            button_Raporlar = new Button();
            panel_menu = new Panel();
            button_showall = new Button();
            button_düzenle = new Button();
            button_sil = new Button();
            button_ekle = new Button();
            button_yönetim = new Button();
            panel_logo = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel_main = new Panel();
            panel_cover = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            toplamkitapsayiysi = new Label();
            KitapSAyıyısıLabel = new Label();
            panel3 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel_menu2.SuspendLayout();
            panel_menu.SuspendLayout();
            panel_logo.SuspendLayout();
            panel_main.SuspendLayout();
            panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(button_çıkış);
            panel1.Controls.Add(panel_menu2);
            panel1.Controls.Add(button_Raporlar);
            panel1.Controls.Add(panel_menu);
            panel1.Controls.Add(button_yönetim);
            panel1.Controls.Add(panel_logo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 873);
            panel1.TabIndex = 0;
            // 
            // button_çıkış
            // 
            button_çıkış.FlatAppearance.BorderSize = 0;
            button_çıkış.FlatStyle = FlatStyle.Flat;
            button_çıkış.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_çıkış.ForeColor = Color.White;
            button_çıkış.Location = new Point(0, 810);
            button_çıkış.Name = "button_çıkış";
            button_çıkış.Padding = new Padding(10, 0, 0, 0);
            button_çıkış.Size = new Size(244, 63);
            button_çıkış.TabIndex = 5;
            button_çıkış.Text = "ÇIKIŞ";
            button_çıkış.UseVisualStyleBackColor = true;
            button_çıkış.Click += button_çıkış_Click;
            // 
            // panel_menu2
            // 
            panel_menu2.Controls.Add(button_satışR);
            panel_menu2.Controls.Add(button_ürünR);
            panel_menu2.Dock = DockStyle.Top;
            panel_menu2.Location = new Point(0, 536);
            panel_menu2.Name = "panel_menu2";
            panel_menu2.Size = new Size(250, 185);
            panel_menu2.TabIndex = 4;
            // 
            // button_satışR
            // 
            button_satışR.FlatAppearance.BorderSize = 0;
            button_satışR.FlatStyle = FlatStyle.Flat;
            button_satışR.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_satışR.ForeColor = Color.White;
            button_satışR.Location = new Point(0, 69);
            button_satışR.Name = "button_satışR";
            button_satışR.Padding = new Padding(10, 0, 0, 0);
            button_satışR.Size = new Size(244, 63);
            button_satışR.TabIndex = 1;
            button_satışR.Text = "Satış Raporu";
            button_satışR.TextAlign = ContentAlignment.MiddleLeft;
            button_satışR.UseVisualStyleBackColor = true;
            button_satışR.Click += button_satışR_Click;
            // 
            // button_ürünR
            // 
            button_ürünR.FlatAppearance.BorderSize = 0;
            button_ürünR.FlatStyle = FlatStyle.Flat;
            button_ürünR.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_ürünR.ForeColor = Color.White;
            button_ürünR.Location = new Point(3, 0);
            button_ürünR.Name = "button_ürünR";
            button_ürünR.Padding = new Padding(10, 0, 0, 0);
            button_ürünR.Size = new Size(244, 63);
            button_ürünR.TabIndex = 0;
            button_ürünR.Text = "Ürün Raporu";
            button_ürünR.TextAlign = ContentAlignment.MiddleLeft;
            button_ürünR.UseVisualStyleBackColor = true;
            button_ürünR.Click += button_ürünR_Click;
            // 
            // button_Raporlar
            // 
            button_Raporlar.Dock = DockStyle.Top;
            button_Raporlar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_Raporlar.Location = new Point(0, 468);
            button_Raporlar.Name = "button_Raporlar";
            button_Raporlar.Size = new Size(250, 68);
            button_Raporlar.TabIndex = 3;
            button_Raporlar.Text = "Raporlar";
            button_Raporlar.UseVisualStyleBackColor = true;
            button_Raporlar.Click += button_Raporlar_Click;
            // 
            // panel_menu
            // 
            panel_menu.Controls.Add(button_showall);
            panel_menu.Controls.Add(button_düzenle);
            panel_menu.Controls.Add(button_sil);
            panel_menu.Controls.Add(button_ekle);
            panel_menu.Dock = DockStyle.Top;
            panel_menu.Location = new Point(0, 193);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(250, 275);
            panel_menu.TabIndex = 2;
            // 
            // button_showall
            // 
            button_showall.FlatAppearance.BorderSize = 0;
            button_showall.FlatStyle = FlatStyle.Flat;
            button_showall.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_showall.ForeColor = Color.White;
            button_showall.Location = new Point(0, 212);
            button_showall.Name = "button_showall";
            button_showall.Padding = new Padding(10, 0, 0, 0);
            button_showall.Size = new Size(244, 63);
            button_showall.TabIndex = 1;
            button_showall.Text = "Tüm Kitapları Göster";
            button_showall.TextAlign = ContentAlignment.MiddleLeft;
            button_showall.UseVisualStyleBackColor = true;
            button_showall.Click += button_showall_Click;
            // 
            // button_düzenle
            // 
            button_düzenle.FlatAppearance.BorderSize = 0;
            button_düzenle.FlatStyle = FlatStyle.Flat;
            button_düzenle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_düzenle.ForeColor = Color.White;
            button_düzenle.Location = new Point(3, 138);
            button_düzenle.Name = "button_düzenle";
            button_düzenle.Padding = new Padding(10, 0, 0, 0);
            button_düzenle.Size = new Size(244, 63);
            button_düzenle.TabIndex = 1;
            button_düzenle.Text = "Kitap Düzenle";
            button_düzenle.TextAlign = ContentAlignment.MiddleLeft;
            button_düzenle.UseVisualStyleBackColor = true;
            button_düzenle.Click += button_düzenle_Click;
            // 
            // button_sil
            // 
            button_sil.FlatAppearance.BorderSize = 0;
            button_sil.FlatStyle = FlatStyle.Flat;
            button_sil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_sil.ForeColor = Color.White;
            button_sil.Location = new Point(0, 69);
            button_sil.Name = "button_sil";
            button_sil.Padding = new Padding(10, 0, 0, 0);
            button_sil.Size = new Size(244, 63);
            button_sil.TabIndex = 1;
            button_sil.Text = "Kitap Sİl";
            button_sil.TextAlign = ContentAlignment.MiddleLeft;
            button_sil.UseVisualStyleBackColor = true;
            button_sil.Click += button_sil_Click;
            // 
            // button_ekle
            // 
            button_ekle.FlatAppearance.BorderSize = 0;
            button_ekle.FlatStyle = FlatStyle.Flat;
            button_ekle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_ekle.ForeColor = Color.White;
            button_ekle.Location = new Point(3, 0);
            button_ekle.Name = "button_ekle";
            button_ekle.Padding = new Padding(10, 0, 0, 0);
            button_ekle.Size = new Size(244, 63);
            button_ekle.TabIndex = 0;
            button_ekle.Text = "Kitap Ekle";
            button_ekle.TextAlign = ContentAlignment.MiddleLeft;
            button_ekle.UseVisualStyleBackColor = true;
            button_ekle.Click += button_ekle_Click;
            // 
            // button_yönetim
            // 
            button_yönetim.Dock = DockStyle.Top;
            button_yönetim.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_yönetim.Location = new Point(0, 125);
            button_yönetim.Name = "button_yönetim";
            button_yönetim.Size = new Size(250, 68);
            button_yönetim.TabIndex = 1;
            button_yönetim.Text = "Kitap Yönetim";
            button_yönetim.UseVisualStyleBackColor = true;
            button_yönetim.Click += button_yönetim_Click_1;
            // 
            // panel_logo
            // 
            panel_logo.Controls.Add(label3);
            panel_logo.Controls.Add(label2);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(250, 125);
            panel_logo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(46, 75);
            label3.Name = "label3";
            label3.Size = new Size(164, 31);
            label3.TabIndex = 2;
            label3.Text = "HOŞGELDİNİZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Webdings", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 2);
            label2.ForeColor = Color.White;
            label2.Location = new Point(76, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 61);
            label2.TabIndex = 1;
            label2.Text = "Z";
            // 
            // panel_main
            // 
            panel_main.Controls.Add(panel_cover);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(250, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1156, 873);
            panel_main.TabIndex = 1;
            // 
            // panel_cover
            // 
            panel_cover.Controls.Add(dataGridView1);
            panel_cover.Controls.Add(panel4);
            panel_cover.Controls.Add(panel3);
            panel_cover.Controls.Add(panel2);
            panel_cover.Dock = DockStyle.Fill;
            panel_cover.Location = new Point(0, 0);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(1156, 873);
            panel_cover.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1156, 555);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Controls.Add(toplamkitapsayiysi);
            panel4.Controls.Add(KitapSAyıyısıLabel);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 748);
            panel4.Name = "panel4";
            panel4.Size = new Size(1156, 125);
            panel4.TabIndex = 2;
            // 
            // toplamkitapsayiysi
            // 
            toplamkitapsayiysi.AutoSize = true;
            toplamkitapsayiysi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            toplamkitapsayiysi.ForeColor = Color.White;
            toplamkitapsayiysi.Location = new Point(33, 62);
            toplamkitapsayiysi.Name = "toplamkitapsayiysi";
            toplamkitapsayiysi.Size = new Size(221, 28);
            toplamkitapsayiysi.TabIndex = 1;
            toplamkitapsayiysi.Text = "Toplam Kayıtlı Kitap  :";
            // 
            // KitapSAyıyısıLabel
            // 
            KitapSAyıyısıLabel.AutoSize = true;
            KitapSAyıyısıLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            KitapSAyıyısıLabel.ForeColor = Color.White;
            KitapSAyıyısıLabel.Location = new Point(33, 15);
            KitapSAyıyısıLabel.Name = "KitapSAyıyısıLabel";
            KitapSAyıyısıLabel.Size = new Size(177, 28);
            KitapSAyıyısıLabel.TabIndex = 0;
            KitapSAyıyısıLabel.Text = "Toplam Müşteri  :";
            KitapSAyıyısıLabel.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(1156, 68);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 13);
            label5.Name = "label5";
            label5.Size = new Size(240, 38);
            label5.TabIndex = 4;
            label5.Text = "En son Eklenenler";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1156, 125);
            panel2.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1406, 873);
            Controls.Add(panel_main);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel_menu2.ResumeLayout(false);
            panel_menu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            panel_main.ResumeLayout(false);
            panel_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel_menu;
        private Button button_ekle;
        private Button button_yönetim;
        private Panel panel_logo;
        private Button button_Raporlar;
        private Button button_showall;
        private Button button_düzenle;
        private Button button_sil;
        private Panel panel_menu2;
        private Button button_satışR;
        private Button button_ürünR;
        private Button button_çıkış;
        private Label label2;
        private Label label3;
        private Panel panel_main;
        private Panel panel_cover;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label toplamkitapsayiysi;
        private Label KitapSAyıyısıLabel;
        private DataGridView dataGridView1;
        private Label label5;
    }
}