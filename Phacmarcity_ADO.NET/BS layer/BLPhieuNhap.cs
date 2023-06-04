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
        public DataTable LayPhieuNhap()
        {
            QLNhaThuocEntities qlntEntity = new QLNhaThuocEntities();
            var tps =
                    from pn in qlntEntity.PhieuNhaps
                    join ctpn in qlntEntity.CTPhieuNhaps on pn.MaPN equals ctpn.MaPN
                    select new
                    {
                        pn.MaPN,
                        pn.MaNhanVien,
                        pn.MaNhaCungCap,
                        ctpn.MaThuoc,
                        ctpn.SoLuong,
                        ctpn.DonGia,
                        pn.NgayNhap,
                        ctpn.NgaySX,
                        ctpn.NgayHH
                    };

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu nhập");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Mã nhà cung cấp");
            dt.Columns.Add("Mã thuốc");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Đơn giá");
            dt.Columns.Add("Ngày nhập");
            dt.Columns.Add("Ngày sản xuất");
            dt.Columns.Add("Ngày hết hạn");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaPN, p.MaNhanVien, p.MaNhaCungCap, p.MaThuoc, p.SoLuong, p.DonGia, p.NgayNhap, p.NgaySX, p.NgayHH);
            }

            return dt;
        }


        public List<PhieuNhapDTO> TimKiemPhieuNhap(string input, string key)
        {
            QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
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
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();

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
                qlNT.PhieuNhaps.Add(phieuNhap);
                qlNT.CTPhieuNhaps.Add(cTPhieuNhap);
                qlNT.SaveChanges();

                // Cập nhật số lượng thuốc
                var thuoc = qlNT.Thuocs.SingleOrDefault(th => th.MaThuoc == MaThuoc);
                if (thuoc != null)
                {
                    thuoc.SoLuong += SoLuong;
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


        public bool XoaPhieuNhap(ref string err, string MaPhieuNhap)
        {
            try
            {
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();

                var phieuNhap = (from pn in qlNT.PhieuNhaps
                                 where pn.MaPN == MaPhieuNhap
                                 select pn).SingleOrDefault();

                var cTPhieuNhap = (from ctpn in qlNT.CTPhieuNhaps
                                   where ctpn.MaPN == MaPhieuNhap
                                   select ctpn).SingleOrDefault();

                qlNT.PhieuNhaps.Attach(phieuNhap);
                qlNT.CTPhieuNhaps.Attach(cTPhieuNhap);

                qlNT.PhieuNhaps.Remove(phieuNhap);
                qlNT.CTPhieuNhaps.Remove(cTPhieuNhap);
                qlNT.SaveChanges();
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
            try
            {
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
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

                qlNT.SaveChanges();

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
