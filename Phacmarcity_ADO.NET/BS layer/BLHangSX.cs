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
        public DataTable LayHangSanXuat()
        {
            QLNhaThuocEntities qlntEntity = new QLNhaThuocEntities();
            var tps =
            from p in qlntEntity.HangSXes
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hãng sản xuất");
            dt.Columns.Add("Tên hãng");
            dt.Columns.Add("Quốc gia");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaHangSX, p.TenHang, p.QuocGia);
            }
            return dt;
        }
        public List<HangSX> TimKiemHangSX(string input, string key)
        {
            QLNhaThuocEntities qlNT = new QLNhaThuocEntities();

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
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                HangSX kh = new HangSX();
                kh.MaHangSX = MaHangSX;
                kh.TenHang = TenHang;
                kh.QuocGia = QuocGia;
                qlNT.HangSXes.Add(kh);
                qlNT.SaveChanges();
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
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                var khQuery = (from kh in qlNT.HangSXes
                              where kh.MaHangSX == MaHangSX
                              select kh).SingleOrDefault();
                qlNT.HangSXes.Remove(khQuery);
                qlNT.SaveChanges();
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
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                var khQuery = (from kh in qlNT.HangSXes
                               where kh.MaHangSX == MaHangSX
                               select kh).SingleOrDefault();
                if (khQuery != null)
                {
                    khQuery.TenHang = TenHang;
                    khQuery.QuocGia = QuocGia;
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
}}

