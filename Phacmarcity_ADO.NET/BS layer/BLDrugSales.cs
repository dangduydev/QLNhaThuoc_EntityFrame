using Phacmarcity_ADO.NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Phacmarcity_ADO.NET.BS_layer
{
    internal class BLDrugSales
    {

        DBMain db = null;
        public BLDrugSales()
        {
            db = new DBMain();
        }

        public DataTable LaySLThuoc()
        {
            string sqlString = "SELECT CTPhieuNhap.MaThuoc, Thuoc.TenThuoc, CTPhieuNhap.SoLuong AS 'So Luong Nhap', CTPhieuNhap.DonGia AS 'Gia Nhap', CTPhieuXuat.SoLuong AS 'So Luong Ban', CTPhieuXuat.DonGia AS 'Gia Ban', (CTPhieuXuat.SoLuong * (CTPhieuXuat.DonGia - CTPhieuNhap.DonGia)) AS DoanhThu FROM CTPhieuNhap JOIN CTPhieuXuat ON CTPhieuNhap.MaThuoc = CTPhieuXuat.MaThuoc JOIN Thuoc ON CTPhieuNhap.MaThuoc = Thuoc.MaThuoc";

            DataTable dataTable = db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];

            return dataTable;
        }

        public decimal TongDoanhThu(ref string err)
        {
            decimal tongDoanhThu = 0;
            string sqlString = "SELECT CTPhieuNhap.MaThuoc, Thuoc.TenThuoc, CTPhieuNhap.SoLuong AS 'So Luong Nhap', CTPhieuNhap.DonGia AS 'Gia Nhap', CTPhieuXuat.SoLuong AS 'So Luong Ban', CTPhieuXuat.DonGia AS 'Gia Ban', (CTPhieuXuat.SoLuong * (CTPhieuXuat.DonGia - CTPhieuNhap.DonGia)) AS DoanhThu FROM CTPhieuNhap JOIN CTPhieuXuat ON CTPhieuNhap.MaThuoc = CTPhieuXuat.MaThuoc JOIN Thuoc ON CTPhieuNhap.MaThuoc = Thuoc.MaThuoc";

            DataTable dataTable = db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];

            tongDoanhThu = dataTable.AsEnumerable()
                .Sum(row => row.Field<decimal>("DoanhThu"));

            return tongDoanhThu;
        }


    }
}
