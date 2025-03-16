using System.Drawing;
using System.Windows.Forms;

namespace BookStore_V5
{
    partial class KitapDüzenleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapDüzenleForm));
            this.button_yönetim = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DüzenlenecekID = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ToplamKitapLabel = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_showall = new System.Windows.Forms.Button();
            this.button_düzenle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_çıkış = new System.Windows.Forms.Button();
            this.panel_menu2 = new System.Windows.Forms.Panel();
            this.button_satışR = new System.Windows.Forms.Button();
            this.button_ürünR = new System.Windows.Forms.Button();
            this.button_Raporlar = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_logo.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.button_yönetim.Text = "Ana Sayfa";
            this.button_yönetim.UseVisualStyleBackColor = true;
            this.button_yönetim.Click += new System.EventHandler(this.button_yönetim_Click);

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
            this.panel_main.Size = new System.Drawing.Size(1135, 720);
            this.panel_main.TabIndex = 5;
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.label1);
            this.panel_cover.Controls.Add(this.textBox_DüzenlenecekID);
            this.panel_cover.Controls.Add(this.dataGridView3);
            this.panel_cover.Controls.Add(this.panel4);
            this.panel_cover.Controls.Add(this.panel3);
            this.panel_cover.Controls.Add(this.panel2);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(0, 0);
            this.panel_cover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(1135, 720);
            this.panel_cover.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Düzenlemek İstedğiniz Kitabın ID si :";
            // 
            // textBox_DüzenlenecekID
            // 
            this.textBox_DüzenlenecekID.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_DüzenlenecekID.Location = new System.Drawing.Point(387, 542);
            this.textBox_DüzenlenecekID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DüzenlenecekID.Name = "textBox_DüzenlenecekID";
            this.textBox_DüzenlenecekID.Size = new System.Drawing.Size(125, 43);
            this.textBox_DüzenlenecekID.TabIndex = 6;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 154);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(1137, 370);
            this.dataGridView3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.ToplamKitapLabel);
            this.panel4.Controls.Add(this.button_update);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 620);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1135, 100);
            this.panel4.TabIndex = 2;
            // 
            // ToplamKitapLabel
            // 
            this.ToplamKitapLabel.AutoSize = true;
            this.ToplamKitapLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamKitapLabel.ForeColor = System.Drawing.Color.White;
            this.ToplamKitapLabel.Location = new System.Drawing.Point(271, 27);
            this.ToplamKitapLabel.Name = "ToplamKitapLabel";
            this.ToplamKitapLabel.Size = new System.Drawing.Size(0, 28);
            this.ToplamKitapLabel.TabIndex = 28;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_update.BackgroundImage")));
            this.button_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_update.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.Location = new System.Drawing.Point(1001, 6);
            this.button_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(100, 72);
            this.button_update.TabIndex = 27;
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Kayıtlı Kitap  :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 54);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kitap Bilgileri Düzenle";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 100);
            this.panel2.TabIndex = 0;
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
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);

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
            this.panel1.Size = new System.Drawing.Size(250, 720);
            this.panel1.TabIndex = 4;
            // 
            // button_çıkış
            // 
            this.button_çıkış.FlatAppearance.BorderSize = 0;
            this.button_çıkış.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_çıkış.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_çıkış.ForeColor = System.Drawing.Color.White;
            this.button_çıkış.Location = new System.Drawing.Point(0, 648);
            this.button_çıkış.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_çıkış.Name = "button_çıkış";
            this.button_çıkış.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_çıkış.Size = new System.Drawing.Size(244, 50);
            this.button_çıkış.TabIndex = 5;
            this.button_çıkış.Text = "ÇIKIŞ";
            this.button_çıkış.UseVisualStyleBackColor = true;
            this.button_çıkış.Click += new System.EventHandler(this.button_çıkış_Click);

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
            // KitapDüzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 720);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KitapDüzenleForm";
            this.Text = "KitapDüzenleForm";
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            this.panel_cover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private TextBox textBox_DüzenlenecekID;
        private Label label6;
        private DataGridView dataGridView3;
        private Panel panel4;
        private Label ToplamKitapLabel;
        private Button button_update;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private Panel panel2;
        private Button button_showall;
        private Button button_düzenle;
        private Button button_sil;
        private Button button_ekle;
        private Panel panel1;
        private Button button_çıkış;
        private Panel panel_menu2;
        private Button button_satışR;
        private Button button_ürünR;
        private Button button_Raporlar;
        private Panel panel_menu;
        private Label label1;
    }
}