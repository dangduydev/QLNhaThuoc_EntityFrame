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
    internal class BL_Supplier
    {
        public DataTable LayNCC()
        {
            QLNhaThuocEntities qlntEntity = new QLNhaThuocEntities();
            var tps =
            from p in qlntEntity.NhaCungCaps
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhà cung cấp");
            dt.Columns.Add("Tên nhà cung cấp");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Thông tin đại diện");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaNhaCungCap, p.TenNhaCungCap, p.DiaChi, p.ThongTinDaiDien);
            }
            return dt;
        }
        public List<NhaCungCap> TimKiemNCC(string input, string key)
        {
            QLNhaThuocEntities qlNT = new QLNhaThuocEntities();

            List<NhaCungCap> nhaCungCapList = null;

            switch (input)
            {
                case nameof(Cls_Enum.OptionSupplier.MaNhaCungCap):
                    nhaCungCapList = qlNT.NhaCungCaps
                        .Where(kh => kh.MaNhaCungCap.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionSupplier.TenNhaCungCap):
                    nhaCungCapList = qlNT.NhaCungCaps
                        .Where(kh => kh.TenNhaCungCap.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionSupplier.DiaChi):
                    nhaCungCapList = qlNT.NhaCungCaps
                        .Where(kh => kh.DiaChi.Contains(key))
                        .ToList();
                    break;
                case nameof(Cls_Enum.OptionSupplier.ThongTinDaiDien):
                    nhaCungCapList = qlNT.NhaCungCaps
                        .Where(kh => kh.ThongTinDaiDien.Contains(key))
                        .ToList();
                    break;

                default:
                    nhaCungCapList = new List<NhaCungCap>(); // Trường hợp không hợp lệ
                    break;
            }

            return nhaCungCapList;
        }


        public bool ThemNCC(string MaNCC, string TenNCC, string DiaChi, string ThongTinDaiDien, ref string err)
        {
            try
            {
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                NhaCungCap kh = new NhaCungCap();
                kh.MaNhaCungCap = MaNCC;
                kh.TenNhaCungCap = TenNCC;
                kh.DiaChi = DiaChi;
                kh.ThongTinDaiDien = ThongTinDaiDien;
                qlNT.NhaCungCaps.Add(kh);
                qlNT.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }

        }
        public bool XoaNCC(ref string err, string MaNhaCungCap)
        {
            try
            {

                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                var khQuery = (from kh in qlNT.NhaCungCaps
                               where kh.MaNhaCungCap == MaNhaCungCap
                               select kh).SingleOrDefault();
                qlNT.NhaCungCaps.Attach(khQuery);
                qlNT.NhaCungCaps.Remove(khQuery);
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatNCC(string MaNCC, string TenNCC, string DiaChi, string ThongTinDaiDien, ref string err)
        {
            try
            {
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                var khQuery = (from kh in qlNT.NhaCungCaps
                               where kh.MaNhaCungCap == MaNCC
                               select kh).SingleOrDefault();
                if (khQuery != null)
                {
                    khQuery.TenNhaCungCap = TenNCC;
                    khQuery.DiaChi = DiaChi;
                    khQuery.ThongTinDaiDien = ThongTinDaiDien;
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
