namespace QLTPKS
{
    partial class phieuthue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(phieuthue));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dvPhongThue = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dvPhieuThue = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateNgayThue = new System.Windows.Forms.DateTimePicker();
            this.comMaKH = new System.Windows.Forms.ComboBox();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.txtSoPT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dateNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dateNgayDen = new System.Windows.Forms.DateTimePicker();
            this.comMaPhong = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongThue)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhieuThue)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dvPhongThue);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(81, 523);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(1119, 230);
            this.groupBox6.TabIndex = 118;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Phòng được thuê";
            // 
            // dvPhongThue
            // 
            this.dvPhongThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvPhongThue.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvPhongThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvPhongThue.Location = new System.Drawing.Point(28, 23);
            this.dvPhongThue.Margin = new System.Windows.Forms.Padding(4);
            this.dvPhongThue.Name = "dvPhongThue";
            this.dvPhongThue.Size = new System.Drawing.Size(1054, 203);
            this.dvPhongThue.TabIndex = 115;
            this.dvPhongThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvPhongThue_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dvPhieuThue);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(81, 392);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1119, 134);
            this.groupBox5.TabIndex = 117;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Phiếu thuê";
            // 
            // dvPhieuThue
            // 
            this.dvPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvPhieuThue.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvPhieuThue.Location = new System.Drawing.Point(28, 23);
            this.dvPhieuThue.Margin = new System.Windows.Forms.Padding(4);
            this.dvPhieuThue.Name = "dvPhieuThue";
            this.dvPhieuThue.Size = new System.Drawing.Size(1054, 103);
            this.dvPhieuThue.TabIndex = 89;
            this.dvPhieuThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvPhieuThue_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.dateNgayThue);
            this.groupBox2.Controls.Add(this.comMaKH);
            this.groupBox2.Controls.Add(this.txtTienCoc);
            this.groupBox2.Controls.Add(this.label48);
            this.groupBox2.Controls.Add(this.label50);
            this.groupBox2.Controls.Add(this.label51);
            this.groupBox2.Controls.Add(this.label52);
            this.groupBox2.Controls.Add(this.txtSoPT);
            this.groupBox2.Location = new System.Drawing.Point(27, 73);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(639, 296);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(41, 199);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 77);
            this.button1.TabIndex = 140;
            this.button1.Text = "Refresh";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(164, 199);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 77);
            this.btnClear.TabIndex = 139;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(503, 199);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 77);
            this.btnXoa.TabIndex = 138;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(395, 199);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 77);
            this.btnSua.TabIndex = 137;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(288, 199);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 77);
            this.btnThem.TabIndex = 136;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateNgayThue
            // 
            this.dateNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayThue.Location = new System.Drawing.Point(256, 108);
            this.dateNgayThue.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayThue.Name = "dateNgayThue";
            this.dateNgayThue.Size = new System.Drawing.Size(285, 22);
            this.dateNgayThue.TabIndex = 108;
            // 
            // comMaKH
            // 
            this.comMaKH.FormattingEnabled = true;
            this.comMaKH.Location = new System.Drawing.Point(256, 66);
            this.comMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.comMaKH.Name = "comMaKH";
            this.comMaKH.Size = new System.Drawing.Size(285, 24);
            this.comMaKH.TabIndex = 107;
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(256, 149);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(285, 22);
            this.txtTienCoc.TabIndex = 106;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(88, 149);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(94, 27);
            this.label48.TabIndex = 105;
            this.label48.Text = "Tiền cọc";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(88, 108);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(111, 27);
            this.label50.TabIndex = 104;
            this.label50.Text = "Ngày thuê";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(88, 65);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(160, 27);
            this.label51.TabIndex = 103;
            this.label51.Text = "Mã khách hàng";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(88, 18);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(143, 27);
            this.label52.TabIndex = 102;
            this.label52.Text = "Số phiếu thuê";
            // 
            // txtSoPT
            // 
            this.txtSoPT.Location = new System.Drawing.Point(257, 20);
            this.txtSoPT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoPT.Name = "txtSoPT";
            this.txtSoPT.Size = new System.Drawing.Size(284, 22);
            this.txtSoPT.TabIndex = 101;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChon);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.dateNgayDi);
            this.groupBox1.Controls.Add(this.dateNgayDen);
            this.groupBox1.Controls.Add(this.comMaPhong);
            this.groupBox1.Controls.Add(this.label54);
            this.groupBox1.Controls.Add(this.label58);
            this.groupBox1.Controls.Add(this.label59);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(677, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(564, 300);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng thuê";
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.White;
            this.btnChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.Location = new System.Drawing.Point(100, 205);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(100, 75);
            this.btnChon.TabIndex = 146;
            this.btnChon.Text = "Chọn";
            this.btnChon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(222, 204);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 76);
            this.btnHuy.TabIndex = 145;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dateNgayDi
            // 
            this.dateNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayDi.Location = new System.Drawing.Point(222, 127);
            this.dateNgayDi.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayDi.Name = "dateNgayDi";
            this.dateNgayDi.Size = new System.Drawing.Size(281, 29);
            this.dateNgayDi.TabIndex = 144;
            // 
            // dateNgayDen
            // 
            this.dateNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayDen.Location = new System.Drawing.Point(222, 83);
            this.dateNgayDen.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayDen.Name = "dateNgayDen";
            this.dateNgayDen.Size = new System.Drawing.Size(281, 29);
            this.dateNgayDen.TabIndex = 143;
            // 
            // comMaPhong
            // 
            this.comMaPhong.FormattingEnabled = true;
            this.comMaPhong.Location = new System.Drawing.Point(222, 42);
            this.comMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.comMaPhong.Name = "comMaPhong";
            this.comMaPhong.Size = new System.Drawing.Size(281, 29);
            this.comMaPhong.TabIndex = 142;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(56, 131);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(87, 27);
            this.label54.TabIndex = 141;
            this.label54.Text = "Ngày đi";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(56, 85);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(104, 27);
            this.label58.TabIndex = 140;
            this.label58.Text = "Ngày đến";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(56, 45);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(109, 27);
            this.label59.TabIndex = 139;
            this.label59.Text = "Mã phòng";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Cambria Math", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(487, -33);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(281, 151);
            this.label49.TabIndex = 113;
            this.label49.Text = "Quản lý phiếu thuê";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1143, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 119;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // phieuthue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 775);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label49);
            this.Name = "phieuthue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "phieuthue";
            this.Load += new System.EventHandler(this.phieuthue_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongThue)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvPhieuThue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dvPhongThue;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dvPhieuThue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateNgayThue;
        private System.Windows.Forms.ComboBox comMaKH;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtSoPT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateNgayDi;
        private System.Windows.Forms.DateTimePicker dateNgayDen;
        private System.Windows.Forms.ComboBox comMaPhong;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button button2;
    }
}