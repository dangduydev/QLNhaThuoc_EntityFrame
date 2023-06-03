using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phacmarcity_ADO.NET
{
    public partial class Frm_ReportPhieuNhap : Form
    {
        public Frm_ReportPhieuNhap()
        {
            InitializeComponent();
        }

        private void Frm_ReportPhieuNhap_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.Fill(this.dsPhieuNhapReport.DataTable1, maPNToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
