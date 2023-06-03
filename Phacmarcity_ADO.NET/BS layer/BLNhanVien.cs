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
    class BLNhanVien
    {
        public System.Data.Linq.Table<NhanVien> LayNhanVien()
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
            return qlNT.NhanViens;
        }
        public List<NhanVien> TimKiemNhanVien(string input, string key)
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();

            List<NhanVien> NhanVienList = null;

            switch (input)
            {
                case nameof(Cls_Enum.OptionEmployee.MaNhanVien):
                    NhanVienList = qlNT.NhanViens
                        .Where(kh => kh.MaNhanVien.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionEmployee.HoTen):
                    NhanVienList = qlNT.NhanViens
                        .Where(kh => kh.HoTen.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionEmployee.SoDienThoai):
                    NhanVienList = qlNT.NhanViens
                        .Where(kh => kh.SoDienThoai.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionEmployee.NgaySinh):
                    NhanVienList = qlNT.NhanViens
                        .Where(kh => kh.NgaySinh.Value.ToString() == key)
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionEmployee.NgayVaoLam):
                    NhanVienList = qlNT.NhanViens
                        .Where(kh => kh.NgayVaoLam.Value.ToString() == key)
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionEmployee.BoPhan):
                    NhanVienList = qlNT.NhanViens
                        .Where(kh => kh.BoPhan.Contains(key))
                        .ToList();
                    break;
                default:
                    NhanVienList = new List<NhanVien>(); // Trường hợp không hợp lệ
                    break;
            }

            return NhanVienList;
        }


        public bool ThemNhanVien(string MaNhanVien, string HoTen, DateTime NgaySinh, string BoPhan, string SoDienThoai,DateTime NgayVaoLam, ref string err)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                NhanVien kh = new NhanVien();
                kh.MaNhanVien = MaNhanVien;
                kh.HoTen = HoTen;
                kh.SoDienThoai = SoDienThoai;
                kh.BoPhan = BoPhan;
                kh.NgaySinh = NgaySinh;
                kh.NgayVaoLam = NgayVaoLam;
                qlNT.NhanViens.InsertOnSubmit(kh);
                qlNT.NhanViens.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }

        }
        public bool XoaNhanVien(ref string err, string MaNhanVien)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                var khQuery = from kh in qlNT.NhanViens
                              where kh.MaNhanVien == MaNhanVien
                              select kh;
                qlNT.NhanViens.DeleteAllOnSubmit(khQuery);
                qlNT.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatNhanVien(string MaNhanVien, string HoTen, DateTime NgaySinh, string BoPhan, string SoDienThoai, DateTime NgayVaoLam, ref string err)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                var khQuery = (from kh in qlNT.NhanViens
                               where kh.MaNhanVien == MaNhanVien
                               select kh).SingleOrDefault();
                if (khQuery != null)
                {
                    khQuery.HoTen = HoTen;
                    khQuery.NgaySinh = NgaySinh;
                    khQuery.SoDienThoai = SoDienThoai;
                    khQuery.NgayVaoLam = NgayVaoLam;
                    khQuery.BoPhan= BoPhan;
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
