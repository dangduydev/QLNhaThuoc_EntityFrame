using Phacmarcity_ADO.NET.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phacmarcity_ADO.NET.BS_layer
{
    public class BLThuoc
    {
        public System.Data.Linq.Table<Thuoc> LayThuoc()
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
            return qlNT.Thuocs;
        }
        public List<Thuoc> TimKiemThuoc(string input, string key)
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();

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
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                Thuoc kh = new Thuoc();
                kh.MaThuoc = MaThuoc;
                kh.TenThuoc = TenThuoc;
                kh.MaHangSX = MaHangSX;
                kh.MaNhaCungCap = MaNhaCungCap;
                kh.CongDung = CongDung;
                kh.GhiChu = GhiChu;
                kh.SoLuong = 0;
                qlNT.Thuocs.InsertOnSubmit(kh);
                qlNT.Thuocs.Context.SubmitChanges();
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
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                var khQuery = from kh in qlNT.Thuocs
                              where kh.MaThuoc == MaThuoc
                              select kh;
                qlNT.Thuocs.DeleteAllOnSubmit(khQuery);
                qlNT.SubmitChanges();
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
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
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
                qlNT.SubmitChanges();
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
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
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
                    qlNT.SubmitChanges();
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
