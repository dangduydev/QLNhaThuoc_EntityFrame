using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Phacmarcity_ADO.NET.BS_layer;
using System.Data.SqlClient;
using Phacmarcity_ADO.NET.Class;
using Phacmarcity_ADO.NET.ENUM;

namespace Phacmarcity_ADO.NET
{
    public partial class Frm_Manufacturer : Form
    {
        string err;
        bool Them;
        BLHangSX dbTP = new BLHangSX();
        public Frm_Manufacturer()
        {
            InitializeComponent();
        }

        private void Frm_Manufacturer_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            pnlSearch.Enabled = false;
            LoadData();
        }
        void reset()
        {
            foreach (Control control in pnlMain.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Clear();
                }
            }
            pnlSearch.Enabled = false;
        }
        void LoadData()
        {
            try
            {
                reset();
                dgvHangSX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Đưa dữ liệu lên DataGridView 
                dgvHangSX.DataSource = dbTP.LayHangSanXuat();
                // Thay đổi độ rộng cột 
                dgvHangSX.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
                //
                dgvHangSX_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HangSX. Lỗi rồi!!!");
            }
        }
        void LoadDataSearch(string input, string key)
        {
            try
            {

                // Đưa dữ liệu lên DataGridView 
                dgvHangSX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvHangSX.DataSource = dbTP.TimKiemHangSX(input, key);
                // Thay đổi độ rộng cột 
                dgvHangSX.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HangSX. Lỗi rồi!!!");

            }
        }


        private void picNCC_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Supplier();
            f.ShowDialog();
        }

        private void picThuoc_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Medicine();
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            Them = true;
            // Xóa trống các đối tượng trong Panel 
            reset();
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            // Đưa con trỏ đến TextField txtKhachHang 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối 
            // Thêm dữ liệu 
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh 
                    BLHangSX blTp = new BLHangSX();
                    blTp.ThemHangSX(this.txtMaHSX.Text, this.txtTenHang.Text, this.txtQuocGia.Text, ref err);
                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    reset();
                    // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh 
                BLHangSX blTp = new BLHangSX();
                blTp.CapNhatHangSX(this.txtMaHSX.Text, this.txtTenHang.Text, this.txtQuocGia.Text, ref err);

                // Load lại dữ liệu trên DataGridView 
                LoadData();
                reset();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối 
            pnlMain.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvHangSX.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strHangSX =
                dgvHangSX.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL 
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    dbTP.XoaHangSX(ref err, strHangSX);
                    // Cập nhật lại DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Cho phép thao tác trên Panel 
            dgvHangSX_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            pnlMain.Enabled = false;
            dgvHangSX_CellClick(null, null);
            reset();
        }

        private void dgvHangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvHangSX.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaHSX.Text =
            dgvHangSX.Rows[r].Cells[0].Value.ToString();
            this.txtTenHang.Text =
            dgvHangSX.Rows[r].Cells[1].Value.ToString();
            this.txtQuocGia.Text =
            dgvHangSX.Rows[r].Cells[2].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != null && cbxTimKiem.SelectedIndex != -1)
            {
                string typeSearch = StringConvert.ConvertToEnumMedicine(cbxTimKiem.SelectedItem.ToString());
                LoadDataSearch(typeSearch, txtTimKiem.Text);

            }
        }
    }
}
