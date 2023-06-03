using System.Windows.Forms;

namespace Phacmarcity_ADO.NET
{
    partial class Frm_Medicine
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picHangSX = new System.Windows.Forms.PictureBox();
            this.picNCC = new System.Windows.Forms.PictureBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtMaHangSanXuat = new System.Windows.Forms.TextBox();
            this.txtCongDung = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHangSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCC)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(31, 404);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 41);
            this.btnSearch.TabIndex = 192;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(289, 528);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 41);
            this.btnSave.TabIndex = 191;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(393, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 28);
            this.label13.TabIndex = 186;
            this.label13.Text = "Hãng sản xuất";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(110, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 28);
            this.label11.TabIndex = 184;
            this.label11.Text = "Nhà cung cấp";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(160, 580);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 41);
            this.btnEdit.TabIndex = 179;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(32, 580);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 41);
            this.btnDelete.TabIndex = 178;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(31, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 28);
            this.label9.TabIndex = 173;
            this.label9.Text = "Công dụng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 636);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 22);
            this.panel2.TabIndex = 167;
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
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lb.ForeColor = System.Drawing.Color.DarkCyan;
            this.lb.Location = new System.Drawing.Point(31, 254);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(181, 28);
            this.lb.TabIndex = 170;
            this.lb.Text = "Mã hãng sản xuất";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.GridColor = System.Drawing.Color.White;
            this.dgvThuoc.Location = new System.Drawing.Point(447, 192);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 29;
            this.dgvThuoc.Size = new System.Drawing.Size(826, 405);
            this.dgvThuoc.TabIndex = 166;
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(160, 528);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 41);
            this.btnUpdate.TabIndex = 165;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(31, 528);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 41);
            this.btnAdd.TabIndex = 164;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(31, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 28);
            this.label3.TabIndex = 158;
            this.label3.Text = "Mã nhà cung cấp";
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
            this.panel1.TabIndex = 155;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(31, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 195;
            this.label2.Text = "Mã thuốc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(31, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 28);
            this.label7.TabIndex = 196;
            this.label7.Text = "Tên thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(30, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 198;
            this.label4.Text = "Ghi chú";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(796, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 50);
            this.label16.TabIndex = 190;
            this.label16.Text = "Thuốc";
            // 
            // cbxTimKiem
            // 
            this.cbxTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxTimKiem.FormattingEnabled = true;
            this.cbxTimKiem.Items.AddRange(new object[] {
            "Mã thuốc",
            "Tên thuốc",
            "Mã hãng sản xuất",
            "Mã nhà cung cấp"});
            this.cbxTimKiem.Location = new System.Drawing.Point(3, 2);
            this.cbxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTimKiem.Name = "cbxTimKiem";
            this.cbxTimKiem.Size = new System.Drawing.Size(169, 28);
            this.cbxTimKiem.TabIndex = 203;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtTimKiem.Location = new System.Drawing.Point(4, 39);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(169, 27);
            this.txtTimKiem.TabIndex = 202;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.DarkCyan;
            this.label19.Location = new System.Drawing.Point(135, 422);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 28);
            this.label19.TabIndex = 201;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.cbxTimKiem);
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Location = new System.Drawing.Point(230, 395);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(180, 70);
            this.pnlSearch.TabIndex = 205;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(288, 580);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 41);
            this.btnCancel.TabIndex = 206;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picHangSX
            // 
            this.picHangSX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHangSX.Image = global::Phacmarcity_ADO.NET.Properties.Resources.production;
            this.picHangSX.Location = new System.Drawing.Point(311, 92);
            this.picHangSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHangSX.Name = "picHangSX";
            this.picHangSX.Size = new System.Drawing.Size(63, 35);
            this.picHangSX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHangSX.TabIndex = 182;
            this.picHangSX.TabStop = false;
            this.picHangSX.Click += new System.EventHandler(this.picHangSX_Click);
            // 
            // picNCC
            // 
            this.picNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNCC.Image = global::Phacmarcity_ADO.NET.Properties.Resources.nha_cung_cap;
            this.picNCC.Location = new System.Drawing.Point(41, 92);
            this.picNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picNCC.Name = "picNCC";
            this.picNCC.Size = new System.Drawing.Size(63, 35);
            this.picNCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNCC.TabIndex = 180;
            this.picNCC.TabStop = false;
            this.picNCC.Click += new System.EventHandler(this.picNCC_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtGhiChu.Location = new System.Drawing.Point(2, 175);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(169, 27);
            this.txtGhiChu.TabIndex = 197;
            // 
            // txtMaNhaCungCap
            // 
            this.txtMaNhaCungCap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtMaNhaCungCap.Location = new System.Drawing.Point(3, 105);
            this.txtMaNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            this.txtMaNhaCungCap.Size = new System.Drawing.Size(169, 27);
            this.txtMaNhaCungCap.TabIndex = 194;
            // 
            // txtMaHangSanXuat
            // 
            this.txtMaHangSanXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtMaHangSanXuat.Location = new System.Drawing.Point(3, 71);
            this.txtMaHangSanXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHangSanXuat.Name = "txtMaHangSanXuat";
            this.txtMaHangSanXuat.Size = new System.Drawing.Size(169, 27);
            this.txtMaHangSanXuat.TabIndex = 193;
            // 
            // txtCongDung
            // 
            this.txtCongDung.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtCongDung.Location = new System.Drawing.Point(3, 138);
            this.txtCongDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(169, 27);
            this.txtCongDung.TabIndex = 172;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtTenThuoc.Location = new System.Drawing.Point(3, 37);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(169, 27);
            this.txtTenThuoc.TabIndex = 168;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtMaThuoc.Location = new System.Drawing.Point(3, 2);
            this.txtMaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(169, 27);
            this.txtMaThuoc.TabIndex = 156;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtMaThuoc);
            this.pnlMain.Controls.Add(this.txtTenThuoc);
            this.pnlMain.Controls.Add(this.txtCongDung);
            this.pnlMain.Controls.Add(this.txtMaHangSanXuat);
            this.pnlMain.Controls.Add(this.txtMaNhaCungCap);
            this.pnlMain.Controls.Add(this.txtGhiChu);
            this.pnlMain.Location = new System.Drawing.Point(230, 185);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(184, 206);
            this.pnlMain.TabIndex = 204;
            // 
            // Frm_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 658);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.picHangSX);
            this.Controls.Add(this.picNCC);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuốc";
            this.Load += new System.EventHandler(this.Frm_Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHangSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCC)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private Button btnSave;
        private Label label13;
        private Label label11;
        private PictureBox picHangSX;
        private PictureBox picNCC;
        private Button btnEdit;
        private Button btnDelete;
        private Label label9;
        private ComboBox comboBox1;
        private Panel panel2;
        private Label label1;
        private Label lb;
        private DataGridView dgvThuoc;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cbbMaThuoc;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label label7;
        private Label label4;
        private Label label16;
        private ComboBox cbxTimKiem;
        private TextBox txtTimKiem;
        private Label label19;
        private Panel pnlSearch;
        private Button btnCancel;
        private TextBox txtGhiChu;
        private TextBox txtMaNhaCungCap;
        private TextBox txtMaHangSanXuat;
        private TextBox txtCongDung;
        private TextBox txtTenThuoc;
        private TextBox txtMaThuoc;
        private Panel pnlMain;
    }
}