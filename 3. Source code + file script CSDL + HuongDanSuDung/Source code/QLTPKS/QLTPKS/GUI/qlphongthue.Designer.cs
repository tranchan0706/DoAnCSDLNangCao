namespace QLTPKS
{
    partial class qlphongthue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qlphongthue));
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dvPhongThue = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dateNgayDen = new System.Windows.Forms.DateTimePicker();
            this.comSOPT = new System.Windows.Forms.ComboBox();
            this.comMaPhong = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.qL_TPKSDataSet1 = new QLTPKS.QL_TPKSDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongThue)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TPKSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(183, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 91);
            this.button1.TabIndex = 145;
            this.button1.Text = "Refresh";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(351, 162);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 91);
            this.btnClear.TabIndex = 144;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(855, 162);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 91);
            this.btnXoa.TabIndex = 143;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(696, 162);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 91);
            this.btnSua.TabIndex = 142;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(519, 162);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 91);
            this.btnThem.TabIndex = 141;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dvPhongThue
            // 
            this.dvPhongThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvPhongThue.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvPhongThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvPhongThue.Location = new System.Drawing.Point(15, 418);
            this.dvPhongThue.Margin = new System.Windows.Forms.Padding(4);
            this.dvPhongThue.Name = "dvPhongThue";
            this.dvPhongThue.Size = new System.Drawing.Size(1080, 240);
            this.dvPhongThue.TabIndex = 139;
            this.dvPhongThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvPhongThue_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateNgayDi);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.dateNgayDen);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.comSOPT);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.comMaPhong);
            this.groupBox1.Controls.Add(this.label54);
            this.groupBox1.Controls.Add(this.label58);
            this.groupBox1.Controls.Add(this.label59);
            this.groupBox1.Controls.Add(this.label60);
            this.groupBox1.Location = new System.Drawing.Point(15, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1028, 275);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            // 
            // dateNgayDi
            // 
            this.dateNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayDi.Location = new System.Drawing.Point(731, 79);
            this.dateNgayDi.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayDi.Name = "dateNgayDi";
            this.dateNgayDi.Size = new System.Drawing.Size(281, 22);
            this.dateNgayDi.TabIndex = 140;
            // 
            // dateNgayDen
            // 
            this.dateNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayDen.Location = new System.Drawing.Point(731, 31);
            this.dateNgayDen.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayDen.Name = "dateNgayDen";
            this.dateNgayDen.Size = new System.Drawing.Size(281, 22);
            this.dateNgayDen.TabIndex = 139;
            // 
            // comSOPT
            // 
            this.comSOPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comSOPT.FormattingEnabled = true;
            this.comSOPT.Location = new System.Drawing.Point(195, 36);
            this.comSOPT.Margin = new System.Windows.Forms.Padding(4);
            this.comSOPT.Name = "comSOPT";
            this.comSOPT.Size = new System.Drawing.Size(281, 24);
            this.comSOPT.TabIndex = 138;
            this.comSOPT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comSOPT_MouseClick);
            // 
            // comMaPhong
            // 
            this.comMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comMaPhong.FormattingEnabled = true;
            this.comMaPhong.Location = new System.Drawing.Point(195, 84);
            this.comMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.comMaPhong.Name = "comMaPhong";
            this.comMaPhong.Size = new System.Drawing.Size(281, 24);
            this.comMaPhong.TabIndex = 137;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(551, 87);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(87, 27);
            this.label54.TabIndex = 136;
            this.label54.Text = "Ngày đi";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(551, 42);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(104, 27);
            this.label58.TabIndex = 135;
            this.label58.Text = "Ngày đến";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(15, 87);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(109, 27);
            this.label59.TabIndex = 134;
            this.label59.Text = "Mã phòng";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(15, 39);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(143, 27);
            this.label60.TabIndex = 133;
            this.label60.Text = "Số phiếu thuê";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Cambria Math", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(412, -17);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(323, 168);
            this.label57.TabIndex = 137;
            this.label57.Text = "Quản lý phòng thuê";
            // 
            // qL_TPKSDataSet1
            // 
            this.qL_TPKSDataSet1.DataSetName = "QL_TPKSDataSet";
            this.qL_TPKSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(945, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 140;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(484, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 26);
            this.button3.TabIndex = 146;
            this.button3.Text = "RS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // qlphongthue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 660);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dvPhongThue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label57);
            this.Name = "qlphongthue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qlphongthue";
            this.Load += new System.EventHandler(this.qlphongthue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongThue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TPKSDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dvPhongThue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateNgayDi;
        private System.Windows.Forms.DateTimePicker dateNgayDen;
        private System.Windows.Forms.ComboBox comSOPT;
        private System.Windows.Forms.ComboBox comMaPhong;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label57;
        private QL_TPKSDataSet qL_TPKSDataSet1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}