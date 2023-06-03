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
        DBMain db = null;

        public List<PhieuXuatDTO> LayPhieuXuat()
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();

            List<PhieuXuatDTO> phieuXuatList = (from px in qlNT.PhieuXuats
                                                join ctpx in qlNT.CTPhieuXuats on px.MaPX equals ctpx.MaPX
                                                select new PhieuXuatDTO
                                                {
                                                    MaPX = px.MaPX,
                                                    MaNhanVien =px.MaNhanVien,
                                                    MaKhachHang = px.MaKhachHang,
                                                    NgayXuat = (DateTime)px.NgayXuat,
                                                    MaThuoc = ctpx.MaThuoc,
                                                    SoLuong = (int)ctpx.SoLuong,
                                                    DonGia = ctpx.DonGia.ToString()
                                                }).ToList();

            return phieuXuatList;
        }
        public bool ThemPhieuXuat(string MaPX,
            string MaNhanVien,
            string MaKhachHang,
            string MaThuoc,
            int SoLuong,
            decimal DonGia, DateTime NgayXuat,
            ref string err)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();

                // Kiểm tra trùng mã phiếu xuất
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

                // Thêm phiếu xuất và chi tiết phiếu xuất
                qlNT.PhieuXuats.InsertOnSubmit(phieuXuat);
                qlNT.CTPhieuXuats.InsertOnSubmit(cTPhieuXuat);
                qlNT.SubmitChanges();

                // Cập nhật số lượng thuốc
                var thuoc = qlNT.Thuocs.SingleOrDefault(th => th.MaThuoc == MaThuoc);
                if (thuoc != null)
                {
                    thuoc.SoLuong -= SoLuong;
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


        public List<PhieuXuatDTO> TimKhiemPhieuXuat(string input, string key)
        {
            QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
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
            }

            return phieuXuatList;
        }

        public bool CapNhatPhieuXuat(string MaPX, string MaNhanVien, string MaKhachHang, string MaThuoc, int SoLuong, decimal DonGia, DateTime NgayXuat, ref string err)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                var khQuery = (from kh in qlNT.PhieuXuats
                               where kh.MaPX == MaPX
                               select kh).SingleOrDefault();

                khQuery.MaNhanVien = MaNhanVien;
                khQuery.MaKhachHang = MaKhachHang;
                khQuery.NgayXuat = NgayXuat;


                var cTPhieuXuat = (from ct in qlNT.CTPhieuXuats
                                   where ct.MaPX == MaPX
                                   select ct).SingleOrDefault();

                cTPhieuXuat.MaThuoc = MaThuoc;
                cTPhieuXuat.SoLuong = SoLuong;
                cTPhieuXuat.DonGia = DonGia;


                qlNT.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool XoaPhieuXuat(ref string err, string MaPX)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();

                var phieuXuat = from px in qlNT.PhieuXuats
                                where px.MaPX == MaPX
                                select px;

                var cTPhieuXuat = from ctpx in qlNT.CTPhieuXuats
                                  where ctpx.MaPX == MaPX
                                  select ctpx;

                qlNT.PhieuXuats.DeleteAllOnSubmit(phieuXuat);
                qlNT.CTPhieuXuats.DeleteAllOnSubmit(cTPhieuXuat);
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
