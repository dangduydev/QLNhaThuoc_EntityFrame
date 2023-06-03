using Phacmarcity_ADO.NET.DB_layer;
using Phacmarcity_ADO.NET.ENUM;
using Phacmarcity_ADO.NET.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Phacmarcity_ADO.NET.BS_layer
{

    class BLLogin
    {

        public bool kiemTraDangNhap(string user, string password, ref string err)
        {
            try
            {
                QLNhaThuocDataContext qlNT = new QLNhaThuocDataContext();
                var taiKhoan = qlNT.TaiKhoans.SingleOrDefault(tk => tk.MaNhanVien == user && tk.MatKhau == password);
                if (taiKhoan != null)
                {
                    var temp = qlNT.NhanViens.SingleOrDefault(nv => nv.MaNhanVien == taiKhoan.MaNhanVien);
                    if (temp != null)
                    {
                        if (StringConvert.ConvertToEnumRole(temp.BoPhan) == nameof(Cls_Enum.OptionRole.QuanLy))
                        {
                            AppSettings.flag_role = true;
                        }
                        else
                        {
                            AppSettings.flag_role = false;
                        }
                        return true;
                    }
                }
                err = "Tên đăng nhập hoặc mật khẩu không đúng";
                return false;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

    }
}

