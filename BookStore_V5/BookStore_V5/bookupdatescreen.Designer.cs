using System.Drawing;
using System.Windows.Forms;

namespace BookStore_V5
{
    partial class bookupdatescreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookupdatescreen));
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
            this.button_save2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_resimyükle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IMAGE2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // yayınlanmaTarihi
            // 
            this.yayınlanmaTarihi.Location = new System.Drawing.Point(320, 318);
            this.yayınlanmaTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yayınlanmaTarihi.Name = "yayınlanmaTarihi";
            this.yayınlanmaTarihi.Size = new System.Drawing.Size(250, 22);
            this.yayınlanmaTarihi.TabIndex = 46;
            // 
            // textBox_AÇIKLAMA
            // 
            this.textBox_AÇIKLAMA.Location = new System.Drawing.Point(568, 263);
            this.textBox_AÇIKLAMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AÇIKLAMA.Name = "textBox_AÇIKLAMA";
            this.textBox_AÇIKLAMA.Size = new System.Drawing.Size(125, 22);
            this.textBox_AÇIKLAMA.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(453, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 29);
            this.label13.TabIndex = 44;
            this.label13.Text = "AÇIKLAMA";
            // 
            // textBox_SAYFA
            // 
            this.textBox_SAYFA.Location = new System.Drawing.Point(568, 205);
            this.textBox_SAYFA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SAYFA.Name = "textBox_SAYFA";
            this.textBox_SAYFA.Size = new System.Drawing.Size(125, 22);
            this.textBox_SAYFA.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(453, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 29);
            this.label12.TabIndex = 42;
            this.label12.Text = "SAYFA";
            // 
            // textBox_DİL
            // 
            this.textBox_DİL.Location = new System.Drawing.Point(563, 150);
            this.textBox_DİL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DİL.Name = "textBox_DİL";
            this.textBox_DİL.Size = new System.Drawing.Size(125, 22);
            this.textBox_DİL.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(448, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 29);
            this.label11.TabIndex = 40;
            this.label11.Text = "DİL";
            // 
            // textBox_ADET
            // 
            this.textBox_ADET.Location = new System.Drawing.Point(563, 99);
            this.textBox_ADET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ADET.Name = "textBox_ADET";
            this.textBox_ADET.Size = new System.Drawing.Size(125, 22);
            this.textBox_ADET.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(448, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 29);
            this.label10.TabIndex = 38;
            this.label10.Text = "ADET";
            // 
            // textBox_FİYAT
            // 
            this.textBox_FİYAT.Location = new System.Drawing.Point(215, 439);
            this.textBox_FİYAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_FİYAT.Name = "textBox_FİYAT";
            this.textBox_FİYAT.Size = new System.Drawing.Size(125, 22);
            this.textBox_FİYAT.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(100, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 29);
            this.label9.TabIndex = 36;
            this.label9.Text = "FİYAT";
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Location = new System.Drawing.Point(215, 374);
            this.textBox_ISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(125, 22);
            this.textBox_ISBN.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(100, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "ISBN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(89, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "YAYINLANMA TARİHİ";
            // 
            // textBox_YAYINCI
            // 
            this.textBox_YAYINCI.Location = new System.Drawing.Point(204, 260);
            this.textBox_YAYINCI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_YAYINCI.Name = "textBox_YAYINCI";
            this.textBox_YAYINCI.Size = new System.Drawing.Size(125, 22);
            this.textBox_YAYINCI.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(89, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "YAYINCI";
            // 
            // textBox_TÜR
            // 
            this.textBox_TÜR.Location = new System.Drawing.Point(204, 205);
            this.textBox_TÜR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TÜR.Name = "textBox_TÜR";
            this.textBox_TÜR.Size = new System.Drawing.Size(125, 22);
            this.textBox_TÜR.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(89, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "TÜR";
            // 
            // textBox_YAZAR
            // 
            this.textBox_YAZAR.Location = new System.Drawing.Point(204, 150);
            this.textBox_YAZAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_YAZAR.Name = "textBox_YAZAR";
            this.textBox_YAZAR.Size = new System.Drawing.Size(125, 22);
            this.textBox_YAZAR.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(89, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "YAZAR";
            // 
            // textBox_AD
            // 
            this.textBox_AD.Location = new System.Drawing.Point(204, 99);
            this.textBox_AD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AD.Name = "textBox_AD";
            this.textBox_AD.Size = new System.Drawing.Size(125, 22);
            this.textBox_AD.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(89, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "AD";
            // 
            // button_save2
            // 
            this.button_save2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_save2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_save2.BackgroundImage")));
            this.button_save2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save2.Location = new System.Drawing.Point(878, 416);
            this.button_save2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save2.Name = "button_save2";
            this.button_save2.Size = new System.Drawing.Size(56, 45);
            this.button_save2.TabIndex = 47;
            this.button_save2.UseVisualStyleBackColor = false;
            this.button_save2.Click += new System.EventHandler(this.button_save2_Click);

            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(749, 96);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 189);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // button_resimyükle
            // 
            this.button_resimyükle.Location = new System.Drawing.Point(749, 307);
            this.button_resimyükle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_resimyükle.Name = "button_resimyükle";
            this.button_resimyükle.Size = new System.Drawing.Size(94, 23);
            this.button_resimyükle.TabIndex = 49;
            this.button_resimyükle.Text = "YÜKLE";
            this.button_resimyükle.UseVisualStyleBackColor = true;
            this.button_resimyükle.Click += new System.EventHandler(this.button_resimyükle_Click);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 41);
            this.label2.TabIndex = 50;
            this.label2.Text = "Bilgileri Düzenleyin";
            // 
            // textBox_IMAGE2
            // 
            this.textBox_IMAGE2.Location = new System.Drawing.Point(749, 362);
            this.textBox_IMAGE2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_IMAGE2.Name = "textBox_IMAGE2";
            this.textBox_IMAGE2.Size = new System.Drawing.Size(125, 22);
            this.textBox_IMAGE2.TabIndex = 51;
            this.textBox_IMAGE2.Visible = false;
            // 
            // bookupdatescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 544);
            this.Controls.Add(this.textBox_IMAGE2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_resimyükle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_save2);
            this.Controls.Add(this.yayınlanmaTarihi);
            this.Controls.Add(this.textBox_AÇIKLAMA);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_SAYFA);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_DİL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_ADET);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_FİYAT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_ISBN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_YAYINCI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_TÜR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_YAZAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_AD);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "bookupdatescreen";
            this.Text = "bookupdatescreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private TextBox textBox_YAZAR;
        private Label label4;
        private TextBox textBox_AD;
        private Label label1;
        private Button button_save2;
        private PictureBox pictureBox2;
        private Button button_resimyükle;
        private Label label2;
        private TextBox textBox_IMAGE2;
    }
}