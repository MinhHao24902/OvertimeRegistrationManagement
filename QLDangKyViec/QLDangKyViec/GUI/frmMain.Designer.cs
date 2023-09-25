namespace QLDangKyViec
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTuGio = new System.Windows.Forms.DateTimePicker();
            this.dateDenGio = new System.Windows.Forms.DateTimePicker();
            this.dateTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtgDangKy = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTUNGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDENNGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTUGIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDENGIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNGUOIDANGKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLYDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboNgDangKy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(887, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Từ giờ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(904, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến giờ";
            // 
            // dateTuGio
            // 
            this.dateTuGio.CustomFormat = "HH:mm";
            this.dateTuGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTuGio.Location = new System.Drawing.Point(161, 164);
            this.dateTuGio.Name = "dateTuGio";
            this.dateTuGio.Size = new System.Drawing.Size(372, 26);
            this.dateTuGio.TabIndex = 4;
            // 
            // dateDenGio
            // 
            this.dateDenGio.CustomFormat = "HH:mm";
            this.dateDenGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDenGio.Location = new System.Drawing.Point(974, 169);
            this.dateDenGio.Name = "dateDenGio";
            this.dateDenGio.Size = new System.Drawing.Size(358, 26);
            this.dateDenGio.TabIndex = 5;
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTuNgay.Location = new System.Drawing.Point(161, 70);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(372, 26);
            this.dateTuNgay.TabIndex = 6;
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDenNgay.Location = new System.Drawing.Point(974, 75);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(358, 26);
            this.dateDenNgay.TabIndex = 7;
            // 
            // dtgDangKy
            // 
            this.dtgDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTUNGAY,
            this.colDENNGAY,
            this.colTUGIO,
            this.colDENGIO,
            this.colNGUOIDANGKY,
            this.colLYDO});
            this.dtgDangKy.Location = new System.Drawing.Point(161, 543);
            this.dtgDangKy.Name = "dtgDangKy";
            this.dtgDangKy.RowHeadersWidth = 62;
            this.dtgDangKy.RowTemplate.Height = 28;
            this.dtgDangKy.Size = new System.Drawing.Size(1171, 255);
            this.dtgDangKy.TabIndex = 8;
            this.dtgDangKy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDangKy_CellClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "STT";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.Width = 150;
            // 
            // colTUNGAY
            // 
            this.colTUNGAY.DataPropertyName = "TUNGAY";
            this.colTUNGAY.HeaderText = "Từ ngày";
            this.colTUNGAY.MinimumWidth = 8;
            this.colTUNGAY.Name = "colTUNGAY";
            this.colTUNGAY.Width = 150;
            // 
            // colDENNGAY
            // 
            this.colDENNGAY.DataPropertyName = "DENNGAY";
            this.colDENNGAY.HeaderText = "Đến ngày";
            this.colDENNGAY.MinimumWidth = 8;
            this.colDENNGAY.Name = "colDENNGAY";
            this.colDENNGAY.Width = 150;
            // 
            // colTUGIO
            // 
            this.colTUGIO.DataPropertyName = "TUGIO";
            this.colTUGIO.HeaderText = "Từ giờ";
            this.colTUGIO.MinimumWidth = 8;
            this.colTUGIO.Name = "colTUGIO";
            this.colTUGIO.Width = 150;
            // 
            // colDENGIO
            // 
            this.colDENGIO.DataPropertyName = "DENGIO";
            this.colDENGIO.HeaderText = "Đến giờ";
            this.colDENGIO.MinimumWidth = 8;
            this.colDENGIO.Name = "colDENGIO";
            this.colDENGIO.Width = 150;
            // 
            // colNGUOIDANGKY
            // 
            this.colNGUOIDANGKY.DataPropertyName = "NGUOIDANGKY";
            this.colNGUOIDANGKY.HeaderText = "Người đăng ký";
            this.colNGUOIDANGKY.MinimumWidth = 8;
            this.colNGUOIDANGKY.Name = "colNGUOIDANGKY";
            this.colNGUOIDANGKY.Width = 150;
            // 
            // colLYDO
            // 
            this.colLYDO.DataPropertyName = "LYDO";
            this.colLYDO.HeaderText = "Lý do";
            this.colLYDO.MinimumWidth = 8;
            this.colLYDO.Name = "colLYDO";
            this.colLYDO.Width = 150;
            // 
            // cboNgDangKy
            // 
            this.cboNgDangKy.FormattingEnabled = true;
            this.cboNgDangKy.Location = new System.Drawing.Point(161, 241);
            this.cboNgDangKy.Name = "cboNgDangKy";
            this.cboNgDangKy.Size = new System.Drawing.Size(1171, 28);
            this.cboNgDangKy.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Người đăng ký:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lý do làm thêm:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(161, 314);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(1171, 151);
            this.txtLyDo.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(161, 486);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 42);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(287, 486);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 42);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(418, 486);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 42);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tìm theo tên:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(832, 491);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(343, 26);
            this.txtTimKiem.TabIndex = 17;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1209, 483);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 42);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(550, 486);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(102, 42);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1428, 861);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboNgDangKy);
            this.Controls.Add(this.dtgDangKy);
            this.Controls.Add(this.dateDenNgay);
            this.Controls.Add(this.dateTuNgay);
            this.Controls.Add(this.dateDenGio);
            this.Controls.Add(this.dateTuGio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLyDo);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký làm việc ngoài giờ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTuGio;
        private System.Windows.Forms.DateTimePicker dateDenGio;
        private System.Windows.Forms.DateTimePicker dateTuNgay;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.DataGridView dtgDangKy;
        private System.Windows.Forms.ComboBox cboNgDangKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTUNGAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDENNGAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTUGIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDENGIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNGUOIDANGKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLYDO;
        private System.Windows.Forms.Button btnIn;
    }
}

