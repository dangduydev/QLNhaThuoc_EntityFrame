using Phacmarcity_ADO.NET.ENUM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phacmarcity_ADO.NET.BS_layer
{
    public class BLThuoc
    {
        public DataTable LayThuoc()
        {
            QLNhaThuocEntities qlntEntity = new QLNhaThuocEntities();
            var tps =
            from p in qlntEntity.Thuocs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã thuốc");
            dt.Columns.Add("Tên thuốc");
            dt.Columns.Add("Mã hãng sản xuất");
            dt.Columns.Add("Mã nhà cung cấp");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Công dụng");
            dt.Columns.Add("Ghi chú");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaThuoc, p.TenThuoc, p.MaHangSX, p.MaNhaCungCap, p.SoLuong, p.CongDung, p.GhiChu);
            }
            return dt;
        }
        public List<Thuoc> TimKiemThuoc(string input, string key)
        {
            QLNhaThuocEntities  qlNT = new QLNhaThuocEntities();

            List<Thuoc> ThuocList = null;

            switch (input)
            {
                case nameof(Cls_Enum.OptionMedicine.MaThuoc):
                    ThuocList = qlNT.Thuocs
                        .Where(kh => kh.MaThuoc.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionMedicine.TenThuoc):
                    ThuocList = qlNT.Thuocs
                        .Where(kh => kh.TenThuoc.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionMedicine.MaHangSX):
                    ThuocList = qlNT.Thuocs
                        .Where(kh => kh.MaHangSX.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionMedicine.MaNhaCungCap):
                    ThuocList = qlNT.Thuocs
                        .Where(kh => kh.MaNhaCungCap.Contains(key))
                        .ToList();
                    break;

                default:
                    ThuocList = new List<Thuoc>(); // Trường hợp không hợp lệ
                    break;
            }

            return ThuocList;
        }
        public bool ThemThuoc(string MaThuoc, string TenThuoc, string MaHangSX, string MaNhaCungCap, string CongDung, string GhiChu, ref string err)
        {
            try
            {
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                Thuoc kh = new Thuoc();
                kh.MaThuoc = MaThuoc;
                kh.TenThuoc = TenThuoc;
                kh.MaHangSX = MaHangSX;
                kh.MaNhaCungCap = MaNhaCungCap;
                kh.CongDung = CongDung;
                kh.GhiChu = GhiChu;
                kh.SoLuong = 0;
                qlNT.Thuocs.Add(kh);
                qlNT.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }

        }
        public bool XoaThuoc(ref string err, string MaThuoc)
        {
            try
            {
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                var khQuery = (from kh in qlNT.Thuocs
                              where kh.MaThuoc == MaThuoc
                              select kh).SingleOrDefault();
                qlNT.Thuocs.Remove(khQuery);
                qlNT.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatSLThuoc(ref string err)
        {
            QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
            var tongNhap = from ct in qlNT.CTPhieuNhaps
                           group ct by ct.MaThuoc into grp
                           select new
                           {
                               MaThuoc = grp.Key,
                               SoLuong = grp.Sum(c => c.SoLuong)
                           };

            var tongXuat = from ct in qlNT.CTPhieuXuats
                           group ct by ct.MaThuoc into grp
                           select new
                           {
                               MaThuoc = grp.Key,
                               SoLuong = grp.Sum(c => c.SoLuong)
                           };

            var query = from thuoc in qlNT.Thuocs
                        join tn in tongNhap on thuoc.MaThuoc equals tn.MaThuoc into nhapGroup
                        from nhap in nhapGroup.DefaultIfEmpty()
                        join tx in tongXuat on thuoc.MaThuoc equals tx.MaThuoc into xuatGroup
                        from xuat in xuatGroup.DefaultIfEmpty()
                        select new
                        {
                            Thuoc = thuoc,
                            TongNhap = nhap != null ? nhap.SoLuong : 0,
                            TongXuat = xuat != null ? xuat.SoLuong : 0
                        };

            foreach (var item in query)
            {
                item.Thuoc.SoLuong = item.TongNhap - item.TongXuat;
            }

            try
            {
                qlNT.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatThuoc(string MaThuoc, string TenThuoc, string MaHangSX, string MaNhaCungCap, string CongDung, string GhiChu, ref string err)
        {
            try
            {
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                var khQuery = (from kh in qlNT.Thuocs
                               where kh.MaThuoc == MaThuoc
                               select kh).SingleOrDefault();
                if (khQuery != null)
                {
                    khQuery.TenThuoc = TenThuoc;
                    khQuery.MaHangSX = MaHangSX;
                    khQuery.MaNhaCungCap = MaNhaCungCap;
                    khQuery.CongDung = CongDung;
                    khQuery.GhiChu = GhiChu;
                    qlNT.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}
