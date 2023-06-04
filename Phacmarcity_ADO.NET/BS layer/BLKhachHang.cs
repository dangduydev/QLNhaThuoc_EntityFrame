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
        public DataTable LayKhachHang()
        {
            QLNhaThuocEntities qlntEntity = new QLNhaThuocEntities();
            var tps =
            from p in qlntEntity.KhachHangs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Địa chỉ");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaKhachHang, p.TenKhachHang,p.SoDienThoai,p.DiaChi);
            }
            return dt;
        }
        public List<KhachHang> TimKiemKhachHang(string input, string key)
        {
            QLNhaThuocEntities qlNT = new QLNhaThuocEntities();

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
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                KhachHang kh = new KhachHang();
                kh.MaKhachHang = MaKhachHang;
                kh.TenKhachHang = TenKhachHang;
                kh.DiaChi = DiaChi;
                kh.SoDienThoai = SoDienThoai;
                qlNT.KhachHangs.Add(kh);
                qlNT.SaveChanges();
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

                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                var khQuery = (from kh in qlNT.KhachHangs
                              where kh.MaKhachHang == MaKhachHang
                              select kh).SingleOrDefault();
                qlNT.KhachHangs.Attach(khQuery);
                qlNT.KhachHangs.Remove(khQuery);
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
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                var khQuery = (from kh in qlNT.KhachHangs
                               where kh.MaKhachHang == MaKhachHang
                               select kh).SingleOrDefault();
                if (khQuery != null)
                {
                    khQuery.TenKhachHang = TenKhachHang;
                    khQuery.DiaChi = DiaChi;
                    khQuery.SoDienThoai = SoDienThoai;
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
