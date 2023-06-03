using Phacmarcity_ADO.NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phacmarcity_ADO.NET.ENUM;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Phacmarcity_ADO.NET.Class;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLPhieuNhap
    {
        DBMain db = null;
        public List<PhieuNhapDTO> LayPhieuNhap()
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();

            List<PhieuNhapDTO> phieuNhapList = (from pn in qlNT.PhieuNhaps
                                                join ctpn in qlNT.CTPhieuNhaps on pn.MaPN equals ctpn.MaPN
                                                select new PhieuNhapDTO
                                                {
                                                    MaPN = pn.MaPN,
                                                    MaNhanVien = pn.MaNhanVien,
                                                    MaNhaCungCap = pn.MaNhaCungCap,
                                                    NgayNhap = (DateTime)pn.NgayNhap,
                                                    MaThuoc = ctpn.MaThuoc,
                                                    SoLuong = (int)ctpn.SoLuong,
                                                    DonGia = ctpn.DonGia.ToString(),
                                                    NgaySX = (DateTime)ctpn.NgaySX,
                                                    NgayHH = (DateTime)ctpn.NgayHH
                                                }).ToList();

            return phieuNhapList;
        }



        public List<PhieuNhapDTO> TimKiemPhieuNhap(string input, string key)
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
            List<PhieuNhapDTO> phieuNhapList = null;

            switch (input)
            {
                case nameof(Cls_Enum.OptionPhieuNhap.MaPN):
                case nameof(Cls_Enum.OptionPhieuNhap.MaNhanVien):
                case nameof(Cls_Enum.OptionPhieuNhap.MaNhaCungCap):
                    phieuNhapList = (from pn in qlNT.PhieuNhaps
                                     join ctpn in qlNT.CTPhieuNhaps on pn.MaPN equals ctpn.MaPN
                                     where (input == nameof(Cls_Enum.OptionPhieuNhap.MaPN)
                                     && pn.MaPN.ToString().Contains(key))
                                           || (input == nameof(Cls_Enum.OptionPhieuNhap.MaNhanVien) && pn.MaNhanVien.ToString().Contains(key))
                                           || pn.MaNhaCungCap.ToString().Contains(key)
                                     select new PhieuNhapDTO
                                     {
                                         MaPN = pn.MaPN,
                                         MaNhanVien = pn.MaNhanVien,
                                         MaNhaCungCap = pn.MaNhaCungCap,
                                         NgayNhap = (DateTime)pn.NgayNhap,
                                         MaThuoc = ctpn.MaThuoc,
                                         SoLuong = (int)ctpn.SoLuong,
                                         DonGia = ctpn.DonGia.ToString(),
                                         NgaySX = (DateTime)ctpn.NgaySX,
                                         NgayHH = (DateTime)ctpn.NgayHH
                                     }).ToList();

                    break;
                case nameof(Cls_Enum.OptionPhieuNhap.NgayNhap):
                    DateTime ngayNhap;
                    if (DateTime.TryParse(key, out ngayNhap))
                    {
                        phieuNhapList = (from pn in qlNT.PhieuNhaps
                                         join ctpn in qlNT.CTPhieuNhaps on pn.MaPN equals ctpn.MaPN
                                         where pn.NgayNhap == ngayNhap
                                         select new PhieuNhapDTO
                                         {
                                             MaPN = pn.MaPN,
                                             MaNhanVien = pn.MaNhanVien,
                                             MaNhaCungCap = pn.MaNhaCungCap,
                                             NgayNhap = (DateTime)pn.NgayNhap,
                                             MaThuoc = ctpn.MaThuoc,
                                             SoLuong = (int)ctpn.SoLuong,
                                             DonGia = ctpn.DonGia.ToString(),
                                             NgaySX = (DateTime)ctpn.NgaySX,
                                             NgayHH = (DateTime)ctpn.NgayHH
                                         }).ToList();
                    }
                    else
                    {
                        phieuNhapList = new List<PhieuNhapDTO>();
                    }
                    break;
                case nameof(Cls_Enum.OptionCTPhieuNhap.SoLuong):
                case nameof(Cls_Enum.OptionCTPhieuNhap.MaThuoc):
                case nameof(Cls_Enum.OptionCTPhieuNhap.DonGia):
                    phieuNhapList = (from pn in qlNT.PhieuNhaps
                                     join ctpn in qlNT.CTPhieuNhaps on pn.MaPN equals ctpn.MaPN
                                     where (input == nameof(Cls_Enum.OptionCTPhieuNhap.SoLuong) && ctpn.SoLuong.ToString().Contains(key))
                                     || (input == nameof(Cls_Enum.OptionCTPhieuNhap.MaThuoc) && ctpn.MaThuoc.ToString().Contains(key))
                                     || (input == nameof(Cls_Enum.OptionCTPhieuNhap.DonGia) && ctpn.DonGia.ToString().Contains(key))
                                     select new PhieuNhapDTO
                                     {
                                         MaPN = pn.MaPN,
                                         MaNhanVien = pn.MaNhanVien,
                                         MaNhaCungCap = pn.MaNhaCungCap,
                                         NgayNhap = (DateTime)pn.NgayNhap,
                                         MaThuoc = ctpn.MaThuoc,
                                         SoLuong = (int)ctpn.SoLuong,
                                         DonGia = ctpn.DonGia.ToString(),
                                         NgaySX = (DateTime)ctpn.NgaySX,
                                         NgayHH = (DateTime)ctpn.NgayHH
                                     }).ToList();
                    break;
                case nameof(Cls_Enum.OptionCTPhieuNhap.NgaySX):
                case nameof(Cls_Enum.OptionCTPhieuNhap.NgayHH):
                    DateTime ngay;
                    if (DateTime.TryParse(key, out ngay))
                    {
                        phieuNhapList = (from pn in qlNT.PhieuNhaps
                                         join ctpn in qlNT.CTPhieuNhaps on pn.MaPN equals ctpn.MaPN
                                         where ctpn.NgaySX == ngay || ctpn.NgayHH == ngay
                                         select new PhieuNhapDTO
                                         {
                                             MaPN = pn.MaPN,
                                             MaNhanVien = pn.MaNhanVien,
                                             MaNhaCungCap = pn.MaNhaCungCap,
                                             NgayNhap = (DateTime)pn.NgayNhap,
                                             MaThuoc = ctpn.MaThuoc,
                                             SoLuong = (int)ctpn.SoLuong,
                                             DonGia = ctpn.DonGia.ToString(),
                                             NgaySX = (DateTime)ctpn.NgaySX,
                                             NgayHH = (DateTime)ctpn.NgayHH
                                         }).ToList();
                    }
                    else
                    {
                        phieuNhapList = new List<PhieuNhapDTO>();
                    }
                    break;
                default:
                    phieuNhapList = new List<PhieuNhapDTO>();
                    break;
            }

            return phieuNhapList;
        }


        public bool ThemPhieuNhap(string MaPN, string MaNhanVien, string MaNhaCungCap, DateTime NgayNhap, string MaThuoc, int SoLuong, decimal DonGia, DateTime NgaySX, DateTime NgayHH, ref string err)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();

                // Kiểm tra trùng mã phiếu nhập
                if (qlNT.PhieuNhaps.Any(pn => pn.MaPN == MaPN))
                {
                    err = "Mã phiếu nhập đã tồn tại.";
                    return false;
                }

                // Tạo mới phiếu nhập và chi tiết phiếu nhập
                PhieuNhap phieuNhap = new PhieuNhap
                {
                    MaPN = MaPN,
                    MaNhanVien = MaNhanVien,
                    MaNhaCungCap = MaNhaCungCap,
                    NgayNhap = NgayNhap
                };

                CTPhieuNhap cTPhieuNhap = new CTPhieuNhap
                {
                    MaPN = MaPN,
                    MaThuoc = MaThuoc,
                    SoLuong = SoLuong,
                    DonGia = DonGia,
                    NgaySX = NgaySX,
                    NgayHH = NgayHH
                };

                // Thêm phiếu nhập và chi tiết phiếu nhập
                qlNT.PhieuNhaps.InsertOnSubmit(phieuNhap);
                qlNT.CTPhieuNhaps.InsertOnSubmit(cTPhieuNhap);
                qlNT.SubmitChanges();

                // Cập nhật số lượng thuốc
                var thuoc = qlNT.Thuocs.SingleOrDefault(th => th.MaThuoc == MaThuoc);
                if (thuoc != null)
                {
                    thuoc.SoLuong += SoLuong;
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


        public bool XoaPhieuNhap(ref string err, string MaPhieuNhap)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();

                var phieuNhap = from pn in qlNT.PhieuNhaps
                                where pn.MaPN == MaPhieuNhap
                                select pn;

                var cTPhieuNhap = from ctpn in qlNT.CTPhieuNhaps
                                  where ctpn.MaPN == MaPhieuNhap
                                  select ctpn;

                qlNT.PhieuNhaps.DeleteAllOnSubmit(phieuNhap);
                qlNT.CTPhieuNhaps.DeleteAllOnSubmit(cTPhieuNhap);
                qlNT.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool CapNhatPhieuNhap(string MaPN, string MaNhanVien, string MaNhaCungCap, DateTime NgayNhap, string MaThuoc, int SoLuong, decimal DonGia, DateTime NgaySX, DateTime NgayHH, ref string err)
        {
            /*string sqlString = "Update PhieuNhap Set MaNhanVien= '" + MaNhanVien + "', MaNhaCungCap= '" + MaNhaCungCap + "', NgayNhap ='" + NgayNhap + "' Where MaPN='" + MaPhieuNhap + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);*/
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                var khQuery = (from kh in qlNT.PhieuNhaps
                               where kh.MaPN == MaPN
                               select kh).SingleOrDefault();

                khQuery.MaNhanVien = MaNhanVien;
                khQuery.MaNhaCungCap = MaNhaCungCap;
                khQuery.NgayNhap = NgayNhap;


                var cTPhieuNhap = (from ct in qlNT.CTPhieuNhaps
                                   where ct.MaPN == MaPN
                                   select ct).SingleOrDefault();

                cTPhieuNhap.MaThuoc = MaThuoc;
                cTPhieuNhap.SoLuong = SoLuong;
                cTPhieuNhap.DonGia = DonGia;
                cTPhieuNhap.NgayHH = NgayHH;
                cTPhieuNhap.NgaySX = NgaySX;

                qlNT.SubmitChanges();

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
