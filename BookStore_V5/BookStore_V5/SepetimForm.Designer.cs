using System.Drawing;
using System.Windows.Forms;

namespace BookStore_V5
{
    partial class SepetimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SepetimForm));
            this.button_düzenle = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_Raporlar = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_satışR = new System.Windows.Forms.Button();
            this.button_ürünR = new System.Windows.Forms.Button();
            this.panel_menu2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_yönetim = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelStore = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewSepetim = new System.Windows.Forms.DataGridView();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.panelsepetbilgiler = new System.Windows.Forms.Panel();
            this.labelemailsepet = new System.Windows.Forms.Label();
            this.labelİsimSepet = new System.Windows.Forms.Label();
            this.labeladressepet = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button_satınal = new System.Windows.Forms.Button();
            this.totalfiyargösterge = new System.Windows.Forms.Label();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_menu2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.flowLayoutPanelStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepetim)).BeginInit();
            this.panelsepetbilgiler.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_cover.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
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
            this.button_ekle.Text = "Ana Sayfa";
            this.button_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
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
            this.panel_menu.Controls.Add(this.button_sil);
            this.panel_menu.Controls.Add(this.button_ekle);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 154);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(250, 169);
            this.panel_menu.TabIndex = 2;
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
            this.button_sil.Text = "Sepetim";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.UseVisualStyleBackColor = true;
           
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
            this.panel1.Size = new System.Drawing.Size(250, 686);
            this.panel1.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 45);
            this.label1.TabIndex = 0;
            // 
            // flowLayoutPanelStore
            // 
            this.flowLayoutPanelStore.Controls.Add(this.dataGridView1);
            this.flowLayoutPanelStore.Controls.Add(this.dataGridViewSepetim);
            this.flowLayoutPanelStore.Controls.Add(this.lblToplamTutar);
            this.flowLayoutPanelStore.Controls.Add(this.panelsepetbilgiler);
            this.flowLayoutPanelStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelStore.Location = new System.Drawing.Point(0, 154);
            this.flowLayoutPanelStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelStore.Name = "flowLayoutPanelStore";
            this.flowLayoutPanelStore.Size = new System.Drawing.Size(1390, 432);
            this.flowLayoutPanelStore.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(247, 581);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewSepetim
            // 
            this.dataGridViewSepetim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSepetim.Location = new System.Drawing.Point(256, 2);
            this.dataGridViewSepetim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSepetim.Name = "dataGridViewSepetim";
            this.dataGridViewSepetim.RowHeadersWidth = 51;
            this.dataGridViewSepetim.Size = new System.Drawing.Size(279, 424);
            this.dataGridViewSepetim.TabIndex = 1;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(541, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 31);
            this.lblToplamTutar.TabIndex = 2;
            // 
            // panelsepetbilgiler
            // 
            this.panelsepetbilgiler.Controls.Add(this.labelemailsepet);
            this.panelsepetbilgiler.Controls.Add(this.labelİsimSepet);
            this.panelsepetbilgiler.Controls.Add(this.labeladressepet);
            this.panelsepetbilgiler.Location = new System.Drawing.Point(547, 2);
            this.panelsepetbilgiler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelsepetbilgiler.Name = "panelsepetbilgiler";
            this.panelsepetbilgiler.Size = new System.Drawing.Size(513, 242);
            this.panelsepetbilgiler.TabIndex = 3;
            // 
            // labelemailsepet
            // 
            this.labelemailsepet.AutoSize = true;
            this.labelemailsepet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelemailsepet.Location = new System.Drawing.Point(39, 150);
            this.labelemailsepet.Name = "labelemailsepet";
            this.labelemailsepet.Size = new System.Drawing.Size(66, 28);
            this.labelemailsepet.TabIndex = 2;
            this.labelemailsepet.Text = "label7";
            // 
            // labelİsimSepet
            // 
            this.labelİsimSepet.AutoSize = true;
            this.labelİsimSepet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelİsimSepet.Location = new System.Drawing.Point(39, 32);
            this.labelİsimSepet.Name = "labelİsimSepet";
            this.labelİsimSepet.Size = new System.Drawing.Size(66, 28);
            this.labelİsimSepet.TabIndex = 1;
            this.labelİsimSepet.Text = "label6";
            // 
            // labeladressepet
            // 
            this.labeladressepet.AutoSize = true;
            this.labeladressepet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeladressepet.Location = new System.Drawing.Point(39, 87);
            this.labeladressepet.Name = "labeladressepet";
            this.labeladressepet.Size = new System.Drawing.Size(66, 28);
            this.labeladressepet.TabIndex = 0;
            this.labeladressepet.Text = "label5";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.button_satınal);
            this.panel4.Controls.Add(this.totalfiyargösterge);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 586);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1390, 100);
            this.panel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1228, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "SATIN AL";
            // 
            // button_satınal
            // 
            this.button_satınal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_satınal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_satınal.BackgroundImage")));
            this.button_satınal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_satınal.FlatAppearance.BorderSize = 0;
            this.button_satınal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_satınal.Location = new System.Drawing.Point(1228, 0);
            this.button_satınal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_satınal.Name = "button_satınal";
            this.button_satınal.Size = new System.Drawing.Size(110, 72);
            this.button_satınal.TabIndex = 6;
            this.button_satınal.UseVisualStyleBackColor = false;
            this.button_satınal.Click += new System.EventHandler(this.button_satınal_Click);
            // 
            // totalfiyargösterge
            // 
            this.totalfiyargösterge.AutoSize = true;
            this.totalfiyargösterge.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalfiyargösterge.ForeColor = System.Drawing.Color.White;
            this.totalfiyargösterge.Location = new System.Drawing.Point(267, 18);
            this.totalfiyargösterge.Name = "totalfiyargösterge";
            this.totalfiyargösterge.Size = new System.Drawing.Size(0, 31);
            this.totalfiyargösterge.TabIndex = 5;
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
            this.panel_cover.Size = new System.Drawing.Size(1390, 686);
            this.panel_cover.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1390, 54);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(282, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "SEPETİM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1390, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1390, 686);
            this.panel_main.TabIndex = 7;
            // 
            // SepetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SepetimForm";
            this.Text = "SepetimForm";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            this.flowLayoutPanelStore.ResumeLayout(false);
            this.flowLayoutPanelStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepetim)).EndInit();
            this.panelsepetbilgiler.ResumeLayout(false);
            this.panelsepetbilgiler.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_cover.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_düzenle;
        private Button button_ekle;
        private Button button_Raporlar;
        private Panel panel_menu;
        private Button button_sil;
        private Button button_satışR;
        private Button button_ürünR;
        private Panel panel_menu2;
        private Panel panel1;
        private Button button_yönetim;
        private Panel panel_logo;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelStore;
        private Panel panel4;
        private Panel panel_cover;
        private Panel panel3;
        private Label label4;
        private Panel panel2;
        private Panel panel_main;
        private DataGridView dataGridView1;
        private DataGridView dataGridViewSepetim;
        private Label lblToplamTutar;
        private Label totalfiyargösterge;
        private Button button_satınal;
        private Panel panelsepetbilgiler;
        private Label labelemailsepet;
        private Label labelİsimSepet;
        private Label labeladressepet;
        private Label label5;
    }
}