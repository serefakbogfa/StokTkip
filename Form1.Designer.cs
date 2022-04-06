
namespace StokTkip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtadsyd = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttpl = new System.Windows.Forms.TextBox();
            this.txtsts = new System.Windows.Forms.TextBox();
            this.txtmktr = new System.Windows.Forms.TextBox();
            this.txturn = new System.Windows.Forms.TextBox();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblgeneltop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(671, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.txtadsyd);
            this.groupBox1.Controls.Add(this.txttc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(152, 123);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 27);
            this.txttel.TabIndex = 2;
            // 
            // txtadsyd
            // 
            this.txtadsyd.Location = new System.Drawing.Point(152, 70);
            this.txtadsyd.Name = "txtadsyd";
            this.txtadsyd.Size = new System.Drawing.Size(100, 27);
            this.txtadsyd.TabIndex = 1;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(152, 26);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(100, 27);
            this.txttc.TabIndex = 0;
            this.txttc.TextChanged += new System.EventHandler(this.txttc_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txttpl);
            this.groupBox2.Controls.Add(this.txtsts);
            this.groupBox2.Controls.Add(this.txtmktr);
            this.groupBox2.Controls.Add(this.txturn);
            this.groupBox2.Controls.Add(this.txtbarkod);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 290);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Toplam Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Üürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Barkod No";
            // 
            // txttpl
            // 
            this.txttpl.Location = new System.Drawing.Point(171, 218);
            this.txttpl.Name = "txttpl";
            this.txttpl.Size = new System.Drawing.Size(100, 27);
            this.txttpl.TabIndex = 4;
            // 
            // txtsts
            // 
            this.txtsts.Location = new System.Drawing.Point(171, 175);
            this.txtsts.Name = "txtsts";
            this.txtsts.Size = new System.Drawing.Size(100, 27);
            this.txtsts.TabIndex = 3;
            this.txtsts.TextChanged += new System.EventHandler(this.txtsts_TextChanged);
            // 
            // txtmktr
            // 
            this.txtmktr.Location = new System.Drawing.Point(171, 131);
            this.txtmktr.Name = "txtmktr";
            this.txtmktr.Size = new System.Drawing.Size(100, 27);
            this.txtmktr.TabIndex = 2;
            this.txtmktr.Text = "1";
            this.txtmktr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmktr.TextChanged += new System.EventHandler(this.txtmktr_TextChanged);
            // 
            // txturn
            // 
            this.txturn.Location = new System.Drawing.Point(171, 83);
            this.txturn.Name = "txturn";
            this.txturn.Size = new System.Drawing.Size(100, 27);
            this.txturn.TabIndex = 1;
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(171, 32);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(100, 27);
            this.txtbarkod.TabIndex = 0;
            this.txtbarkod.TextChanged += new System.EventHandler(this.txtbarkod_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 126);
            this.panel1.TabIndex = 3;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(731, 38);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(107, 45);
            this.button11.TabIndex = 6;
            this.button11.Text = "Kategori";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(846, 38);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(113, 45);
            this.button10.TabIndex = 5;
            this.button10.Text = "Marka";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(607, 38);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 45);
            this.button9.TabIndex = 4;
            this.button9.Text = "Satış Listeleme";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(476, 38);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 45);
            this.button8.TabIndex = 3;
            this.button8.Text = "Ürün Listeleme";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(327, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 45);
            this.button7.TabIndex = 2;
            this.button7.Text = "Ürün ekleme ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(167, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 45);
            this.button6.TabIndex = 1;
            this.button6.Text = "Müşteri Listeleme";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 45);
            this.button5.TabIndex = 0;
            this.button5.Text = "Müşteri Ekleme";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 625);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Satış İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 566);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(670, 566);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = " Satış Yap";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblgeneltop
            // 
            this.lblgeneltop.AutoSize = true;
            this.lblgeneltop.Location = new System.Drawing.Point(473, 572);
            this.lblgeneltop.Name = "lblgeneltop";
            this.lblgeneltop.Size = new System.Drawing.Size(97, 17);
            this.lblgeneltop.TabIndex = 8;
            this.lblgeneltop.Text = "Genel Toplam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 712);
            this.Controls.Add(this.lblgeneltop);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtadsyd;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttpl;
        private System.Windows.Forms.TextBox txtsts;
        private System.Windows.Forms.TextBox txtmktr;
        private System.Windows.Forms.TextBox txturn;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblgeneltop;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
    }
}

