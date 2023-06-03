using Phacmarcity_ADO.NET.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phacmarcity_ADO.NET
{
    public partial class Frm_DrugSales : Form
    {
        DataTable dtDoanhThu = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 
        string err;
        BLDrugSales dbTP = new BLDrugSales();
        public Frm_DrugSales()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                decimal doanhThu = dbTP.TongDoanhThu(ref err);

                txtDoanhThu.Text = doanhThu.ToString("N0");
                /*                reset();*/
                dtDoanhThu = new DataTable();
                dtDoanhThu.Clear();
                DataTable dataTable = dbTP.LaySLThuoc();
                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(dataTable.Copy());

                // Đưa dữ liệu lên DataGridView 
                dgvDoanhThuThuoc.DataSource = dtDoanhThu;
                // Thay đổi độ rộng cột 
                dgvDoanhThuThuoc.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                //dgvPhieuNhap_CellClick(null, null);
                txtDoanhThu.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Trong CSDL. Lỗi rồi!!!");
            }
        }
        private void dgvDoanhThuThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDoanhThu_TextChanged(object sender, EventArgs e)
        {
            decimal doanhThu = dbTP.TongDoanhThu(ref err);

            txtDoanhThu.Text = doanhThu.ToString("N0");
        }

        private void dgvDoanhThuThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_DrugSales_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
