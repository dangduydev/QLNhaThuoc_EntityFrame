using Phacmarcity_ADO.NET.DB_layer;
using Phacmarcity_ADO.NET.ENUM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLHangSX
    {
        public System.Data.Linq.Table<HangSX> LayHangSX()
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
            return qlNT.HangSXes;
        }
        public List<HangSX> TimKiemHangSX(string input, string key)
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();

            List<HangSX> HangSXList = null;

            switch (input)
            {
                case nameof(Cls_Enum.OptionHangSX.MaHangSX):
                    HangSXList = qlNT.HangSXes
                        .Where(kh => kh.MaHangSX.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionHangSX.TenHang):
                    HangSXList = qlNT.HangSXes
                        .Where(kh => kh.TenHang.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionHangSX.QuocGia):
                    HangSXList = qlNT.HangSXes
                        .Where(kh => kh.MaHangSX.Contains(key))
                        .ToList();
                    break;
                default:
                    HangSXList = new List<HangSX>(); // Trường hợp không hợp lệ
                    break;
            }

            return HangSXList;
        }
        public bool ThemHangSX(string MaHangSX, string TenHang, string QuocGia, ref string err)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                HangSX kh = new HangSX();
                kh.MaHangSX = MaHangSX;
                kh.TenHang = TenHang;
                kh.QuocGia = QuocGia;
                qlNT.HangSXes.InsertOnSubmit(kh);
                qlNT.HangSXes.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }

        }
        public bool XoaHangSX(ref string err, string MaHangSX)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                var khQuery = from kh in qlNT.HangSXes
                              where kh.MaHangSX == MaHangSX
                              select kh;
                qlNT.HangSXes.DeleteAllOnSubmit(khQuery);
                qlNT.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatHangSX(string MaHangSX, string TenHang, string QuocGia, ref string err)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                var khQuery = (from kh in qlNT.HangSXes
                               where kh.MaHangSX == MaHangSX
                               select kh).SingleOrDefault();
                if (khQuery != null)
                {
                    khQuery.TenHang = TenHang;
                    khQuery.QuocGia = QuocGia;
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
}}

