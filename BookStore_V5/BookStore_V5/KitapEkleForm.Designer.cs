using System.Drawing;
using System.Windows.Forms;

namespace BookStore_V5
{
    partial class KitapEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkleForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.button_çıkış = new System.Windows.Forms.Button();
            this.panel_menu2 = new System.Windows.Forms.Panel();
            this.button_satışR = new System.Windows.Forms.Button();
            this.button_ürünR = new System.Windows.Forms.Button();
            this.button_Raporlar = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_showall = new System.Windows.Forms.Button();
            this.button_düzenle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.button_resimSeç = new System.Windows.Forms.Button();
            this.textBox_IMAGE = new System.Windows.Forms.TextBox();
            this.pictureBox_Cover = new System.Windows.Forms.PictureBox();
            this.yayınlanmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.textBox_AÇIKLAMA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_SAYFA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_DİL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_ADET = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_FİYAT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_YAYINCI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_TÜR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_YAZAR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_AD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_yönetim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel_menu2.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cover)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 100);
            this.panel2.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(36, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 41);
            this.label14.TabIndex = 0;
            this.label14.Text = "Kitap Ekle";
            // 
            // button_çıkış
            // 
            this.button_çıkış.FlatAppearance.BorderSize = 0;
            this.button_çıkış.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_çıkış.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_çıkış.ForeColor = System.Drawing.Color.White;
            this.button_çıkış.Location = new System.Drawing.Point(0, 602);
            this.button_çıkış.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_çıkış.Name = "button_çıkış";
            this.button_çıkış.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_çıkış.Size = new System.Drawing.Size(244, 50);
            this.button_çıkış.TabIndex = 5;
            this.button_çıkış.Text = "ÇIKIŞ";
            this.button_çıkış.UseVisualStyleBackColor = true;
            // 
            // panel_menu2
            // 
            this.panel_menu2.Controls.Add(this.button_satışR);
            this.panel_menu2.Controls.Add(this.button_ürünR);
            this.panel_menu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu2.Location = new System.Drawing.Point(0, 428);
            this.panel_menu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_menu2.Name = "panel_menu2";
            this.panel_menu2.Size = new System.Drawing.Size(250, 148);
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
            this.button_satışR.Text = "Satış Raporu";
            this.button_satışR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_satışR.UseVisualStyleBackColor = true;
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
            this.button_ürünR.Text = "Ürün Raporu";
            this.button_ürünR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ürünR.UseVisualStyleBackColor = true;
            // 
            // button_Raporlar
            // 
            this.button_Raporlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Raporlar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Raporlar.Location = new System.Drawing.Point(0, 374);
            this.button_Raporlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Raporlar.Name = "button_Raporlar";
            this.button_Raporlar.Size = new System.Drawing.Size(250, 54);
            this.button_Raporlar.TabIndex = 3;
            this.button_Raporlar.Text = "Raporlar";
            this.button_Raporlar.UseVisualStyleBackColor = true;
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.button_showall);
            this.panel_menu.Controls.Add(this.button_düzenle);
            this.panel_menu.Controls.Add(this.button_sil);
            this.panel_menu.Controls.Add(this.button_ekle);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 154);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(250, 220);
            this.panel_menu.TabIndex = 2;
            // 
            // button_showall
            // 
            this.button_showall.FlatAppearance.BorderSize = 0;
            this.button_showall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showall.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_showall.ForeColor = System.Drawing.Color.White;
            this.button_showall.Location = new System.Drawing.Point(0, 170);
            this.button_showall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_showall.Name = "button_showall";
            this.button_showall.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_showall.Size = new System.Drawing.Size(244, 50);
            this.button_showall.TabIndex = 1;
            this.button_showall.Text = "Tüm Kitapları Göster";
            this.button_showall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_showall.UseVisualStyleBackColor = true;
       

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
            this.button_düzenle.Text = "Kitap Düzenle";
            this.button_düzenle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_düzenle.UseVisualStyleBackColor = true;
            this.button_düzenle.Click += new System.EventHandler(this.button_düzenle_Click);

            // 
            // button_sil
            // 
            this.button_sil.FlatAppearance.BorderSize = 0;
            this.button_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.ForeColor = System.Drawing.Color.White;
            this.button_sil.Location = new System.Drawing.Point(0, 55);
            this.button_sil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_sil.Name = "button_sil";
            this.button_sil.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_sil.Size = new System.Drawing.Size(244, 50);
            this.button_sil.TabIndex = 1;
            this.button_sil.Text = "Kitap Sİl";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);


            // 
            // button_ekle
            // 
            this.button_ekle.FlatAppearance.BorderSize = 0;
            this.button_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ekle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ekle.ForeColor = System.Drawing.Color.White;
            this.button_ekle.Location = new System.Drawing.Point(3, 0);
            this.button_ekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_ekle.Size = new System.Drawing.Size(244, 50);
            this.button_ekle.TabIndex = 0;
            this.button_ekle.Text = "Kitap Ekle";
            this.button_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ekle.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.button_cancel);
            this.panel4.Controls.Add(this.button_clear);
            this.panel4.Controls.Add(this.button_save);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 576);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1113, 100);
            this.panel4.TabIndex = 2;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_cancel.BackgroundImage")));
            this.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancel.Location = new System.Drawing.Point(1026, 30);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(56, 45);
            this.button_cancel.TabIndex = 28;
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);

            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_clear.BackgroundImage")));
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_clear.Location = new System.Drawing.Point(936, 31);
            this.button_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(56, 45);
            this.button_clear.TabIndex = 27;
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_save.BackgroundImage")));
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save.Location = new System.Drawing.Point(849, 31);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(56, 45);
            this.button_save.TabIndex = 26;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);

            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.button_resimSeç);
            this.panel_cover.Controls.Add(this.textBox_IMAGE);
            this.panel_cover.Controls.Add(this.pictureBox_Cover);
            this.panel_cover.Controls.Add(this.yayınlanmaTarihi);
            this.panel_cover.Controls.Add(this.textBox_AÇIKLAMA);
            this.panel_cover.Controls.Add(this.label13);
            this.panel_cover.Controls.Add(this.textBox_SAYFA);
            this.panel_cover.Controls.Add(this.label12);
            this.panel_cover.Controls.Add(this.textBox_DİL);
            this.panel_cover.Controls.Add(this.label11);
            this.panel_cover.Controls.Add(this.textBox_ADET);
            this.panel_cover.Controls.Add(this.label10);
            this.panel_cover.Controls.Add(this.textBox_FİYAT);
            this.panel_cover.Controls.Add(this.label9);
            this.panel_cover.Controls.Add(this.textBox_ISBN);
            this.panel_cover.Controls.Add(this.label8);
            this.panel_cover.Controls.Add(this.label7);
            this.panel_cover.Controls.Add(this.textBox_YAYINCI);
            this.panel_cover.Controls.Add(this.label6);
            this.panel_cover.Controls.Add(this.textBox_TÜR);
            this.panel_cover.Controls.Add(this.label5);
            this.panel_cover.Controls.Add(this.textBox_YAZAR);
            this.panel_cover.Controls.Add(this.label4);
            this.panel_cover.Controls.Add(this.textBox_AD);
            this.panel_cover.Controls.Add(this.label1);
            this.panel_cover.Controls.Add(this.panel4);
            this.panel_cover.Controls.Add(this.panel2);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(0, 0);
            this.panel_cover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(1113, 676);
            this.panel_cover.TabIndex = 0;
            // 
            // button_resimSeç
            // 
            this.button_resimSeç.Location = new System.Drawing.Point(898, 392);
            this.button_resimSeç.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_resimSeç.Name = "button_resimSeç";
            this.button_resimSeç.Size = new System.Drawing.Size(94, 23);
            this.button_resimSeç.TabIndex = 28;
            this.button_resimSeç.Text = "Resim Yükle";
            this.button_resimSeç.UseVisualStyleBackColor = true;
            this.button_resimSeç.Click += new System.EventHandler(this.button_resimSeç_Click);

            // 
            // textBox_IMAGE
            // 
            this.textBox_IMAGE.Location = new System.Drawing.Point(867, 459);
            this.textBox_IMAGE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_IMAGE.Name = "textBox_IMAGE";
            this.textBox_IMAGE.Size = new System.Drawing.Size(125, 22);
            this.textBox_IMAGE.TabIndex = 26;
            this.textBox_IMAGE.Visible = false;
            // 
            // pictureBox_Cover
            // 
            this.pictureBox_Cover.Location = new System.Drawing.Point(757, 119);
            this.pictureBox_Cover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Cover.Name = "pictureBox_Cover";
            this.pictureBox_Cover.Size = new System.Drawing.Size(235, 255);
            this.pictureBox_Cover.TabIndex = 25;
            this.pictureBox_Cover.TabStop = false;
            // 
            // yayınlanmaTarihi
            // 
            this.yayınlanmaTarihi.Location = new System.Drawing.Point(267, 338);
            this.yayınlanmaTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yayınlanmaTarihi.Name = "yayınlanmaTarihi";
            this.yayınlanmaTarihi.Size = new System.Drawing.Size(250, 22);
            this.yayınlanmaTarihi.TabIndex = 24;
            // 
            // textBox_AÇIKLAMA
            // 
            this.textBox_AÇIKLAMA.Location = new System.Drawing.Point(515, 283);
            this.textBox_AÇIKLAMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AÇIKLAMA.Name = "textBox_AÇIKLAMA";
            this.textBox_AÇIKLAMA.Size = new System.Drawing.Size(125, 22);
            this.textBox_AÇIKLAMA.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(400, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 29);
            this.label13.TabIndex = 22;
            this.label13.Text = "AÇIKLAMA";
            // 
            // textBox_SAYFA
            // 
            this.textBox_SAYFA.Location = new System.Drawing.Point(515, 225);
            this.textBox_SAYFA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SAYFA.Name = "textBox_SAYFA";
            this.textBox_SAYFA.Size = new System.Drawing.Size(125, 22);
            this.textBox_SAYFA.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(400, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "SAYFA";
            // 
            // textBox_DİL
            // 
            this.textBox_DİL.Location = new System.Drawing.Point(510, 170);
            this.textBox_DİL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DİL.Name = "textBox_DİL";
            this.textBox_DİL.Size = new System.Drawing.Size(125, 22);
            this.textBox_DİL.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(395, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "DİL";
            // 
            // textBox_ADET
            // 
            this.textBox_ADET.Location = new System.Drawing.Point(510, 119);
            this.textBox_ADET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ADET.Name = "textBox_ADET";
            this.textBox_ADET.Size = new System.Drawing.Size(125, 22);
            this.textBox_ADET.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(395, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "ADET";
            // 
            // textBox_FİYAT
            // 
            this.textBox_FİYAT.Location = new System.Drawing.Point(162, 459);
            this.textBox_FİYAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_FİYAT.Name = "textBox_FİYAT";
            this.textBox_FİYAT.Size = new System.Drawing.Size(125, 22);
            this.textBox_FİYAT.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(47, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "FİYAT";
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Location = new System.Drawing.Point(162, 394);
            this.textBox_ISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(125, 22);
            this.textBox_ISBN.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(47, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "ISBN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(36, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "YAYINLANMA TARİHİ";
            // 
            // textBox_YAYINCI
            // 
            this.textBox_YAYINCI.Location = new System.Drawing.Point(151, 280);
            this.textBox_YAYINCI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_YAYINCI.Name = "textBox_YAYINCI";
            this.textBox_YAYINCI.Size = new System.Drawing.Size(125, 22);
            this.textBox_YAYINCI.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(36, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "YAYINCI";
            // 
            // textBox_TÜR
            // 
            this.textBox_TÜR.Location = new System.Drawing.Point(151, 225);
            this.textBox_TÜR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TÜR.Name = "textBox_TÜR";
            this.textBox_TÜR.Size = new System.Drawing.Size(125, 22);
            this.textBox_TÜR.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "TÜR";
            // 
            // textBox_YAZAR
            // 
            this.textBox_YAZAR.Location = new System.Drawing.Point(151, 170);
            this.textBox_YAZAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_YAZAR.Name = "textBox_YAZAR";
            this.textBox_YAZAR.Size = new System.Drawing.Size(125, 22);
            this.textBox_YAZAR.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "YAZAR";
            // 
            // textBox_AD
            // 
            this.textBox_AD.Location = new System.Drawing.Point(151, 119);
            this.textBox_AD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AD.Name = "textBox_AD";
            this.textBox_AD.Size = new System.Drawing.Size(125, 22);
            this.textBox_AD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "AD";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(250, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1113, 676);
            this.panel_main.TabIndex = 3;
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
            // button_yönetim
            // 
            this.button_yönetim.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_yönetim.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_yönetim.Location = new System.Drawing.Point(0, 100);
            this.button_yönetim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_yönetim.Name = "button_yönetim";
            this.button_yönetim.Size = new System.Drawing.Size(250, 54);
            this.button_yönetim.TabIndex = 1;
            this.button_yönetim.Text = "Ana Sayfa";
            this.button_yönetim.UseVisualStyleBackColor = true;
            this.button_yönetim.Click += new System.EventHandler(this.button_yönetim_Click);

            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.button_çıkış);
            this.panel1.Controls.Add(this.panel_menu2);
            this.panel1.Controls.Add(this.button_Raporlar);
            this.panel1.Controls.Add(this.panel_menu);
            this.panel1.Controls.Add(this.button_yönetim);
            this.panel1.Controls.Add(this.panel_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 676);
            this.panel1.TabIndex = 2;
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
            // KitapEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 676);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KitapEkleForm";
            this.Text = "KitapEkleForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_menu2.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            this.panel_cover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cover)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button button_çıkış;
        private Panel panel_menu2;
        private Button button_satışR;
        private Button button_ürünR;
        private Button button_Raporlar;
        private Panel panel_menu;
        private Button button_showall;
        private Button button_düzenle;
        private Button button_sil;
        private Button button_ekle;
        private Panel panel4;
        private Panel panel_cover;
        private Panel panel_main;
        private Label label3;
        private Label label2;
        private Button button_yönetim;
        private Panel panel1;
        private Panel panel_logo;
        private TextBox textBox_AD;
        private Label label1;
        private TextBox textBox_YAZAR;
        private Label label4;
        private DateTimePicker yayınlanmaTarihi;
        private TextBox textBox_AÇIKLAMA;
        private Label label13;
        private TextBox textBox_SAYFA;
        private Label label12;
        private TextBox textBox_DİL;
        private Label label11;
        private TextBox textBox_ADET;
        private Label label10;
        private TextBox textBox_FİYAT;
        private Label label9;
        private TextBox textBox_ISBN;
        private Label label8;
        private Label label7;
        private TextBox textBox_YAYINCI;
        private Label label6;
        private TextBox textBox_TÜR;
        private Label label5;
        private PictureBox pictureBox_Cover;
        private Button button_cancel;
        private Button button_clear;
        private Label label14;
        private Button button_resimSeç;
        private TextBox textBox_IMAGE;
        private Button button_save;
    }
}