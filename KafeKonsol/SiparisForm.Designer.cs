namespace KafeKonsol
{
    partial class SiparisForm
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
            label1 = new Label();
            btnEkle = new Button();
            dgvDetaylar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            nudAdet = new NumericUpDown();
            cboUrun = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cboMasaNo = new ComboBox();
            btnMasaTasi = new Button();
            btnIptal = new Button();
            btnOdemeAl = new Button();
            btnAnaSayfayaDon = new Button();
            label4 = new Label();
            lblMasaNo = new Label();
            lblOdemeTutari = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(284, 31);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.AllowUserToAddRows = false;
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDetaylar.Location = new Point(12, 60);
            dgvDetaylar.MultiSelect = false;
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.ReadOnly = true;
            dgvDetaylar.RowHeadersVisible = false;
            dgvDetaylar.RowTemplate.Height = 25;
            dgvDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaylar.Size = new Size(623, 506);
            dgvDetaylar.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UrunAd";
            Column1.HeaderText = "Ürün";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BirimFiyat";
            Column2.HeaderText = "Fiyat";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Adet";
            Column3.HeaderText = "Adet";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TutarTL";
            Column4.HeaderText = "Tutar";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(146, 31);
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(120, 23);
            nudAdet.TabIndex = 3;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboUrun
            // 
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(12, 31);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(121, 23);
            cboUrun.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 9);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "Adet";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(748, 9);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Masa No:";
            // 
            // cboMasaNo
            // 
            cboMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboMasaNo.FormattingEnabled = true;
            cboMasaNo.Location = new Point(748, 32);
            cboMasaNo.Name = "cboMasaNo";
            cboMasaNo.Size = new Size(73, 23);
            cboMasaNo.TabIndex = 7;
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Location = new Point(843, 32);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(75, 23);
            btnMasaTasi.TabIndex = 8;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            btnIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIptal.BackColor = Color.Red;
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(709, 438);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(126, 61);
            btnIptal.TabIndex = 9;
            btnIptal.Text = "SİPARİŞ İPTAL";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.Location = new Point(843, 438);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(126, 61);
            btnOdemeAl.TabIndex = 10;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = true;
            btnOdemeAl.Click += btnOdemeAl_Click;
            // 
            // btnAnaSayfayaDon
            // 
            btnAnaSayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnaSayfayaDon.Location = new Point(709, 505);
            btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            btnAnaSayfayaDon.Size = new Size(258, 61);
            btnAnaSayfayaDon.TabIndex = 11;
            btnAnaSayfayaDon.Text = "ANASAYFAYA DÖN";
            btnAnaSayfayaDon.UseVisualStyleBackColor = true;
            btnAnaSayfayaDon.Click += btnAnaSayfayaDon_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(723, 330);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 12;
            label4.Text = "Ödeme Tutarı:";
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.Tomato;
            lblMasaNo.Font = new Font("Arial Black", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblMasaNo.ForeColor = Color.White;
            lblMasaNo.Location = new Point(689, 60);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(278, 185);
            lblMasaNo.TabIndex = 13;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.AutoSize = true;
            lblOdemeTutari.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblOdemeTutari.Location = new Point(860, 330);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(70, 25);
            lblOdemeTutari.TabIndex = 14;
            lblOdemeTutari.Text = "0.00 TL";
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 578);
            Controls.Add(lblOdemeTutari);
            Controls.Add(lblMasaNo);
            Controls.Add(label4);
            Controls.Add(btnAnaSayfayaDon);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnIptal);
            Controls.Add(btnMasaTasi);
            Controls.Add(cboMasaNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboUrun);
            Controls.Add(nudAdet);
            Controls.Add(dgvDetaylar);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            MinimumSize = new Size(1012, 617);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sipariş";
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEkle;
        private DataGridView dgvDetaylar;
        private NumericUpDown nudAdet;
        private ComboBox cboUrun;
        private Label label2;
        private Label label3;
        private ComboBox cboMasaNo;
        private Button btnMasaTasi;
        private Button btnIptal;
        private Button btnOdemeAl;
        private Button btnAnaSayfayaDon;
        private Label label4;
        private Label lblMasaNo;
        private Label lblOdemeTutari;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}