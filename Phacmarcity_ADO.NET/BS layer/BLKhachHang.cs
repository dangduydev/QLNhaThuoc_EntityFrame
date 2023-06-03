using Phacmarcity_ADO.NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phacmarcity_ADO.NET.ENUM;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLKhachHang
    {
        public System.Data.Linq.Table<KhachHang> LayKhachHang()
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
            return qlNT.KhachHangs;
        }
        public List<KhachHang> TimKiemKhachHang(string input, string key)
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();

            List<KhachHang> khachHangList = null;

            switch (input)
            {
                case nameof(Cls_Enum.OptionClient.MaKhachHang):
                    khachHangList = qlNT.KhachHangs
                        .Where(kh => kh.MaKhachHang.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionClient.TenKhachHang):
                    khachHangList = qlNT.KhachHangs
                        .Where(kh => kh.TenKhachHang.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionClient.SoDienThoai):
                    khachHangList = qlNT.KhachHangs
                        .Where(kh => kh.SoDienThoai.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionClient.DiaChi):
                    khachHangList = qlNT.KhachHangs
                        .Where(kh => kh.DiaChi.Contains(key))
                        .ToList();
                    break;
                        
                default:
                    khachHangList = new List<KhachHang>(); // Trường hợp không hợp lệ
                    break;
            }

            return khachHangList;
        }


        public bool ThemKhachHang(string MaKhachHang, string TenKhachHang, string SoDienThoai, string DiaChi, ref string err)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                KhachHang kh = new KhachHang();
                kh.MaKhachHang = MaKhachHang;
                kh.TenKhachHang = TenKhachHang;
                kh.DiaChi = DiaChi;
                kh.SoDienThoai = SoDienThoai;
                qlNT.KhachHangs.InsertOnSubmit(kh);
                qlNT.KhachHangs.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }

        }
        public bool XoaKhachHang(ref string err, string MaKhachHang)
        {
            try
            {

                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                var khQuery = from kh in qlNT.KhachHangs
                              where kh.MaKhachHang == MaKhachHang
                              select kh;
                qlNT.KhachHangs.DeleteAllOnSubmit(khQuery);
                qlNT.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatKhachHang(string MaKhachHang, string TenKhachHang, string SoDienThoai, string DiaChi, ref string err)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                var khQuery = (from kh in qlNT.KhachHangs
                               where kh.MaKhachHang == MaKhachHang
                               select kh).SingleOrDefault();
                if (khQuery != null)
                {
                    khQuery.TenKhachHang = TenKhachHang;
                    khQuery.DiaChi = DiaChi;
                    khQuery.SoDienThoai = SoDienThoai;
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
