namespace Hafta_11
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
            this.dataGridViewFilmler = new System.Windows.Forms.DataGridView();
            this.dataGridViewOyuncular = new System.Windows.Forms.DataGridView();
            this.lblHata = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOyuncular = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOyuncular)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFilmler
            // 
            this.dataGridViewFilmler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilmler.Location = new System.Drawing.Point(12, 158);
            this.dataGridViewFilmler.MultiSelect = false;
            this.dataGridViewFilmler.Name = "dataGridViewFilmler";
            this.dataGridViewFilmler.ReadOnly = true;
            this.dataGridViewFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilmler.Size = new System.Drawing.Size(378, 280);
            this.dataGridViewFilmler.TabIndex = 0;
            this.dataGridViewFilmler.SelectionChanged += new System.EventHandler(this.dataGridViewFilmler_SelectionChanged);
            // 
            // dataGridViewOyuncular
            // 
            this.dataGridViewOyuncular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOyuncular.Location = new System.Drawing.Point(396, 158);
            this.dataGridViewOyuncular.Name = "dataGridViewOyuncular";
            this.dataGridViewOyuncular.Size = new System.Drawing.Size(392, 280);
            this.dataGridViewOyuncular.TabIndex = 1;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.ForeColor = System.Drawing.Color.Red;
            this.lblHata.Location = new System.Drawing.Point(12, 453);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 13);
            this.lblHata.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Film Adi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yonetmeni:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yili:";
            // 
            // comboBoxOyuncular
            // 
            this.comboBoxOyuncular.FormattingEnabled = true;
            this.comboBoxOyuncular.Location = new System.Drawing.Point(107, 121);
            this.comboBoxOyuncular.Name = "comboBoxOyuncular";
            this.comboBoxOyuncular.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOyuncular.TabIndex = 6;
            this.comboBoxOyuncular.SelectedIndexChanged += new System.EventHandler(this.comboBoxOyuncular_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(249, 121);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oyuncular:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.comboBoxOyuncular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.dataGridViewOyuncular);
            this.Controls.Add(this.dataGridViewFilmler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOyuncular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFilmler;
        private System.Windows.Forms.DataGridView dataGridViewOyuncular;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOyuncular;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
    }
}

