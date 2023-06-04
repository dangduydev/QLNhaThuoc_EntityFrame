using Phacmarcity_ADO.NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phacmarcity_ADO.NET.ENUM;
using Phacmarcity_ADO.NET.Class;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLProduce_Product
    {
        public DataTable LayPhieuXuat()
        {
            QLNhaThuocEntities qlntEntity = new QLNhaThuocEntities();
            var tps =
                    from px in qlntEntity.PhieuXuats
                    join ctpx in qlntEntity.CTPhieuXuats on px.MaPX equals ctpx.MaPX
                    select new
                    {
                        px.MaPX,
                        px.MaNhanVien,
                        px.MaKhachHang,
                        ctpx.MaThuoc,
                        ctpx.SoLuong,
                        ctpx.DonGia,
                        px.NgayXuat
                    };

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu xuất");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Mã thuốc");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Đơn giá");
            dt.Columns.Add("Ngày xuất");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaPX, p.MaNhanVien, p.MaKhachHang, p.MaThuoc, p.SoLuong, p.DonGia, p.NgayXuat);
            }

            return dt;
        }


        public List<PhieuXuatDTO> TimKiemPhieuXuat(string input, string key)
        {
            QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
            List<PhieuXuatDTO> phieuXuatList = null;

            switch (input)
            {
                case nameof(Cls_Enum.OptionPhieuXuat.MaPX):
                case nameof(Cls_Enum.OptionPhieuXuat.MaNhanVien):
                case nameof(Cls_Enum.OptionPhieuXuat.MaKhachHang):
                    phieuXuatList = (from px in qlNT.PhieuXuats
                                     join ctpx in qlNT.CTPhieuXuats on px.MaPX equals ctpx.MaPX
                                     where (input == nameof(Cls_Enum.OptionPhieuXuat.MaPX)
                                     && px.MaPX.ToString().Contains(key))
                                           || (input == nameof(Cls_Enum.OptionPhieuXuat.MaNhanVien) && px.MaNhanVien.ToString().Contains(key))
                                           || px.MaKhachHang.ToString().Contains(key)
                                     select new PhieuXuatDTO
                                     {
                                         MaPX = px.MaPX,
                                         MaNhanVien = px.MaNhanVien,
                                         MaKhachHang = px.MaKhachHang,
                                         NgayXuat = (DateTime)px.NgayXuat,
                                         MaThuoc = ctpx.MaThuoc,
                                         SoLuong = (int)ctpx.SoLuong,
                                         DonGia = ctpx.DonGia.ToString()
                                     }).ToList();

                    break;
                case nameof(Cls_Enum.OptionPhieuXuat.NgayXuat):
                    DateTime ngayXuat;
                    if (DateTime.TryParse(key, out ngayXuat))
                    {
                        phieuXuatList = (from px in qlNT.PhieuXuats
                                         join ctpx in qlNT.CTPhieuXuats on px.MaPX equals ctpx.MaPX
                                         where px.NgayXuat == ngayXuat
                                         select new PhieuXuatDTO
                                         {
                                             MaPX = px.MaPX,
                                             MaNhanVien = px.MaNhanVien,
                                             MaKhachHang = px.MaKhachHang,
                                             NgayXuat = (DateTime)px.NgayXuat,
                                             MaThuoc = ctpx.MaThuoc,
                                             SoLuong = (int)ctpx.SoLuong,
                                             DonGia = ctpx.DonGia.ToString()
                                         }).ToList();
                    }
                    else
                    {
                        phieuXuatList = new List<PhieuXuatDTO>();
                    }
                    break;
                case nameof(Cls_Enum.OptionPhieuXuat.SoLuong):
                case nameof(Cls_Enum.OptionPhieuXuat.MaThuoc):
                case nameof(Cls_Enum.OptionPhieuXuat.DonGia):
                    phieuXuatList = (from px in qlNT.PhieuXuats
                                     join ctpx in qlNT.CTPhieuXuats on px.MaPX equals ctpx.MaPX
                                     where (input == nameof(Cls_Enum.OptionPhieuXuat.SoLuong) && ctpx.SoLuong.ToString().Contains(key))
                                     || (input == nameof(Cls_Enum.OptionPhieuXuat.MaThuoc) && ctpx.MaThuoc.ToString().Contains(key))
                                     || (input == nameof(Cls_Enum.OptionPhieuXuat.DonGia) && ctpx.DonGia.ToString().Contains(key))
                                     select new PhieuXuatDTO
                                     {
                                         MaPX = px.MaPX,
                                         MaNhanVien = px.MaNhanVien,
                                         MaKhachHang = px.MaKhachHang,
                                         NgayXuat = (DateTime)px.NgayXuat,
                                         MaThuoc = ctpx.MaThuoc,
                                         SoLuong = (int)ctpx.SoLuong,
                                         DonGia = ctpx.DonGia.ToString()
                                     }).ToList();
                    break;

                default:
                    phieuXuatList = new List<PhieuXuatDTO>();
                    break;
            }

            return phieuXuatList;
        }


        public bool ThemPhieuXuat(string MaPX, string MaNhanVien, string MaKhachHang, DateTime NgayXuat, string MaThuoc, int SoLuong, decimal DonGia, ref string err)
        {
            try
            {
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();

                // Kiểm tra trùng mã phiếu nhập
                if (qlNT.PhieuXuats.Any(px => px.MaPX == MaPX))
                {
                    err = "Mã phiếu nhập đã tồn tại.";
                    return false;
                }

                // Tạo mới phiếu nhập và chi tiết phiếu nhập
                PhieuXuat phieuXuat = new PhieuXuat
                {
                    MaPX = MaPX,
                    MaNhanVien = MaNhanVien,
                    MaKhachHang = MaKhachHang,
                    NgayXuat = NgayXuat
                };

                CTPhieuXuat cTPhieuXuat = new CTPhieuXuat
                {
                    MaPX = MaPX,
                    MaThuoc = MaThuoc,
                    SoLuong = SoLuong,
                    DonGia = DonGia
                };

                // Thêm phiếu nhập và chi tiết phiếu nhập
                qlNT.PhieuXuats.Add(phieuXuat);
                qlNT.CTPhieuXuats.Add(cTPhieuXuat);
                qlNT.SaveChanges();


                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }


        public bool XoaPhieuXuat(ref string err, string MaPhieuXuat)
        {
            try
            {
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();

                var phieuXuat = (from px in qlNT.PhieuXuats
                                 where px.MaPX == MaPhieuXuat
                                 select px).SingleOrDefault();

                var cTPhieuXuat = (from ctpx in qlNT.CTPhieuXuats
                                   where ctpx.MaPX == MaPhieuXuat
                                   select ctpx).SingleOrDefault();

                qlNT.PhieuXuats.Attach(phieuXuat);
                qlNT.CTPhieuXuats.Attach(cTPhieuXuat);

                qlNT.PhieuXuats.Remove(phieuXuat);
                qlNT.CTPhieuXuats.Remove(cTPhieuXuat);
                qlNT.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool CapNhatPhieuXuat(string MaPX, string MaNhanVien, string MaKhachHang, DateTime NgayXuat, string MaThuoc, int SoLuong, decimal DonGia, ref string err)
        {
            try
            {
                QLNhaThuocEntities qlNT = new QLNhaThuocEntities();
                var khQuery = (from px in qlNT.PhieuXuats
                               where px.MaPX == MaPX
                               select px).SingleOrDefault();

                khQuery.MaNhanVien = MaNhanVien;
                khQuery.MaKhachHang = MaKhachHang;
                khQuery.NgayXuat = NgayXuat;


                var cTPhieuXuat = (from ctpx in qlNT.CTPhieuXuats
                                   where ctpx.MaPX == MaPX
                                   select ctpx).SingleOrDefault();

                cTPhieuXuat.MaThuoc = MaThuoc;
                cTPhieuXuat.SoLuong = SoLuong;
                cTPhieuXuat.DonGia = DonGia;

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
