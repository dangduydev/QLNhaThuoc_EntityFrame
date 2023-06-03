using System.Windows.Forms;

namespace Phacmarcity_ADO.NET
{
    partial class Frm_Manufacturer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHangSX = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHSX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picThuoc = new System.Windows.Forms.PictureBox();
            this.picNCC = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSX)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 87);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(430, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy Managerment Version 1.0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 636);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 22);
            this.panel2.TabIndex = 42;
            // 
            // dgvHangSX
            // 
            this.dgvHangSX.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvHangSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangSX.GridColor = System.Drawing.Color.White;
            this.dgvHangSX.Location = new System.Drawing.Point(481, 199);
            this.dgvHangSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHangSX.Name = "dgvHangSX";
            this.dgvHangSX.RowHeadersWidth = 51;
            this.dgvHangSX.RowTemplate.Height = 29;
            this.dgvHangSX.Size = new System.Drawing.Size(784, 408);
            this.dgvHangSX.TabIndex = 43;
            this.dgvHangSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangSX_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(186, 566);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 41);
            this.btnEdit.TabIndex = 75;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(50, 566);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 41);
            this.btnDelete.TabIndex = 74;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(38, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 66;
            this.label8.Text = "Quốc gia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(38, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 28);
            this.label7.TabIndex = 65;
            this.label7.Text = "Tên hãng";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtTenHang.Location = new System.Drawing.Point(3, 63);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(169, 27);
            this.txtTenHang.TabIndex = 64;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(186, 514);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 41);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(49, 514);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 41);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(38, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 28);
            this.label2.TabIndex = 55;
            this.label2.Text = "Mã hãng sản xuất";
            // 
            // txtMaHSX
            // 
            this.txtMaHSX.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtMaHSX.Location = new System.Drawing.Point(3, 21);
            this.txtMaHSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHSX.Name = "txtMaHSX";
            this.txtMaHSX.Size = new System.Drawing.Size(169, 27);
            this.txtMaHSX.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(746, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(269, 50);
            this.label11.TabIndex = 76;
            this.label11.Text = "Hãng sản xuất";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(391, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 28);
            this.label14.TabIndex = 84;
            this.label14.Text = "Thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(120, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 28);
            this.label3.TabIndex = 81;
            this.label3.Text = "Nhà cung cấp";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(38, 354);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 41);
            this.btnSearch.TabIndex = 154;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(322, 514);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 41);
            this.btnSave.TabIndex = 153;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxTimKiem
            // 
            this.cbxTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxTimKiem.FormattingEnabled = true;
            this.cbxTimKiem.Items.AddRange(new object[] {
            "Mã sản xuất",
            "Tên hãng",
            "Quốc gia"});
            this.cbxTimKiem.Location = new System.Drawing.Point(3, 2);
            this.cbxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTimKiem.Name = "cbxTimKiem";
            this.cbxTimKiem.Size = new System.Drawing.Size(169, 28);
            this.cbxTimKiem.TabIndex = 164;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtTimKiem.Location = new System.Drawing.Point(3, 36);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(169, 27);
            this.txtTimKiem.TabIndex = 163;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.DarkCyan;
            this.label19.Location = new System.Drawing.Point(144, 386);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 28);
            this.label19.TabIndex = 162;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtQuocGia);
            this.pnlMain.Controls.Add(this.txtTenHang);
            this.pnlMain.Controls.Add(this.txtMaHSX);
            this.pnlMain.Location = new System.Drawing.Point(246, 199);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(189, 146);
            this.pnlMain.TabIndex = 165;
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtQuocGia.Location = new System.Drawing.Point(3, 105);
            this.txtQuocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.Size = new System.Drawing.Size(169, 27);
            this.txtQuocGia.TabIndex = 65;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.cbxTimKiem);
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Location = new System.Drawing.Point(246, 349);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(182, 76);
            this.pnlSearch.TabIndex = 166;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(322, 566);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 41);
            this.btnCancel.TabIndex = 193;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picThuoc
            // 
            this.picThuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picThuoc.Image = global::Phacmarcity_ADO.NET.Properties.Resources.medicine;
            this.picThuoc.Location = new System.Drawing.Point(311, 101);
            this.picThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picThuoc.Name = "picThuoc";
            this.picThuoc.Size = new System.Drawing.Size(63, 35);
            this.picThuoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThuoc.TabIndex = 80;
            this.picThuoc.TabStop = false;
            this.picThuoc.Click += new System.EventHandler(this.picThuoc_Click);
            // 
            // picNCC
            // 
            this.picNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNCC.Image = global::Phacmarcity_ADO.NET.Properties.Resources.nha_cung_cap;
            this.picNCC.Location = new System.Drawing.Point(51, 101);
            this.picNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picNCC.Name = "picNCC";
            this.picNCC.Size = new System.Drawing.Size(63, 35);
            this.picNCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNCC.TabIndex = 77;
            this.picNCC.TabStop = false;
            this.picNCC.Click += new System.EventHandler(this.picNCC_Click);
            // 
            // Frm_Manufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1312, 658);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picThuoc);
            this.Controls.Add(this.picNCC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHangSX);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Manufacturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manufacturer";
            this.Load += new System.EventHandler(this.Frm_Manufacturer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSX)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvHangSX;
        private Button btnEdit;
        private Button btnDelete;
        private Label label8;
        private Label label7;
        private TextBox txtTenHang;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label2;
        private TextBox txtMaHSX;
        private Label label11;
        private Label label14;
        private Label label3;
        private PictureBox picThuoc;
        private PictureBox picNCC;
        private Button btnSearch;
        private Button btnSave;
        private ComboBox cbxTimKiem;
        private TextBox txtTimKiem;
        private Label label19;
        private Panel pnlMain;
        private Panel pnlSearch;
        private Button btnCancel;
        private TextBox txtQuocGia;
    }
}