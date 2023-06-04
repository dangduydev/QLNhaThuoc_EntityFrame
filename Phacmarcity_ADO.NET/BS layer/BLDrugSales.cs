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
        public DataTable LaySLThuoc()
        {
            try
            {
                using (QLNhaThuocEntities qlNT = new QLNhaThuocEntities())
                {
                    var query = from ctPhieuNhap in qlNT.CTPhieuNhaps
                                join ctPhieuXuat in qlNT.CTPhieuXuats on ctPhieuNhap.MaThuoc equals ctPhieuXuat.MaThuoc
                                join thuoc in qlNT.Thuocs on ctPhieuNhap.MaThuoc equals thuoc.MaThuoc
                                select new
                                {
                                    ctPhieuNhap.MaThuoc,
                                    thuoc.TenThuoc,
                                    SoLuongNhap = ctPhieuNhap.SoLuong,
                                    GiaNhap = ctPhieuNhap.DonGia,
                                    SoLuongBan = ctPhieuXuat.SoLuong,
                                    GiaBan = ctPhieuXuat.DonGia,
                                    DoanhThu = ctPhieuXuat.SoLuong * (ctPhieuXuat.DonGia - ctPhieuNhap.DonGia)
                                };

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("MaThuoc");
                    dataTable.Columns.Add("TenThuoc");
                    dataTable.Columns.Add("So Luong Nhap");
                    dataTable.Columns.Add("Gia Nhap");
                    dataTable.Columns.Add("So Luong Ban");
                    dataTable.Columns.Add("Gia Ban");
                    dataTable.Columns.Add("DoanhThu");

                    foreach (var item in query)
                    {
                        dataTable.Rows.Add(item.MaThuoc, item.TenThuoc, item.SoLuongNhap, item.GiaNhap, item.SoLuongBan, item.GiaBan, item.DoanhThu);
                    }

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây (err = ex.Message)
                return null;
            }
        }


        public decimal TongDoanhThu(ref string err)
        {
            try
            {
                decimal tongDoanhThu = 0;
                using (QLNhaThuocEntities qlNT = new QLNhaThuocEntities())
                {
                    var query = from ctPhieuNhap in qlNT.CTPhieuNhaps
                                join ctPhieuXuat in qlNT.CTPhieuXuats on ctPhieuNhap.MaThuoc equals ctPhieuXuat.MaThuoc
                                join thuoc in qlNT.Thuocs on ctPhieuNhap.MaThuoc equals thuoc.MaThuoc
                                select ctPhieuXuat.SoLuong * (ctPhieuXuat.DonGia - ctPhieuNhap.DonGia);

                    tongDoanhThu = query.Sum() ?? 0;// ?? là khi null lấy giá trị là 0
                }

                return tongDoanhThu;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return 0;
            }
        }



    }
}
