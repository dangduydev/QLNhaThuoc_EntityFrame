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
        public System.Data.Linq.Table<NhaCungCap> LayNCC()
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
            return qlNT.NhaCungCaps;
        }
        public List<NhaCungCap> TimKiemNCC(string input, string key)
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();

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
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                NhaCungCap kh = new NhaCungCap();
                kh.MaNhaCungCap = MaNCC;
                kh.TenNhaCungCap = TenNCC;
                kh.DiaChi = DiaChi;
                kh.ThongTinDaiDien = ThongTinDaiDien;
                qlNT.NhaCungCaps.InsertOnSubmit(kh);
                qlNT.NhaCungCaps.Context.SubmitChanges();
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
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                var khQuery = from kh in qlNT.NhaCungCaps
                              where kh.MaNhaCungCap == MaNhaCungCap
                              select kh;
                qlNT.NhaCungCaps.DeleteAllOnSubmit(khQuery);
                qlNT.SubmitChanges();
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
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                var khQuery = (from kh in qlNT.NhaCungCaps
                               where kh.MaNhaCungCap == MaNCC
                               select kh).SingleOrDefault();
                if (khQuery != null)
                {
                    khQuery.TenNhaCungCap = TenNCC;
                    khQuery.DiaChi = DiaChi;
                    khQuery.ThongTinDaiDien = ThongTinDaiDien;
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
