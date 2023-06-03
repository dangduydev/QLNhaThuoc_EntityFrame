using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Phacmarcity_ADO.NET.BS_layer;
using Phacmarcity_ADO.NET.Class;

namespace Phacmarcity_ADO.NET
{
    public partial class Frm_Login : Form
    {
        string err;
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            BLLogin bLLogin = new BLLogin();
            if (bLLogin.kiemTraDangNhap(txtUser.Text, txtPass.Text, ref err))
            {
                Form f = new Frm_Home();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show(err, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
