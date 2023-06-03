using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phacmarcity_ADO.NET.Model;
using Microsoft.Reporting.WinForms;


namespace Phacmarcity_ADO.NET
{
    public partial class Frm_ReportPhieuXuat : Form
    {

        public Frm_ReportPhieuXuat()
        {
            InitializeComponent();
        }

        private void Frm_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPhieuXuatReport.DataTable1' table. You can move, or remove it, as needed.
/*            this.dataTable1TableAdapter.Fill(this.dsPhieuXuatReport.DataTable1);*/
            // TODO: This line of code loads data into the 'dsPhieuXuatReport.DataTable1' table. You can move, or remove it, as needed.
            /*            this.dataTable1TableAdapter.Fill(this.dsPhieuXuatReport.DataTable1);*/
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
        }


        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.Fill(this.dsPhieuXuatReport.DataTable1, (string)maPXToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
