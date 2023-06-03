namespace Phacmarcity_ADO.NET
{
    partial class Frm_DrugSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label19 = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDoanhThuThuoc = new System.Windows.Forms.DataGridView();
            this.pnlSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.DarkCyan;
            this.label19.Location = new System.Drawing.Point(120, 369);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 28);
            this.label19.TabIndex = 254;
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtDoanhThu.Location = new System.Drawing.Point(9, 38);
            this.txtDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(142, 27);
            this.txtDoanhThu.TabIndex = 235;
            this.txtDoanhThu.TextChanged += new System.EventHandler(this.txtDoanhThu_TextChanged);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.txtDoanhThu);
            this.pnlSearch.Location = new System.Drawing.Point(28, 149);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(156, 74);
            this.pnlSearch.TabIndex = 256;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 236;
            this.label2.Text = "Tổng Doanh Thu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(518, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(329, 50);
            this.label16.TabIndex = 249;
            this.label16.Text = "Doanh Thu Thuốc";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 691);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 22);
            this.panel2.TabIndex = 245;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 87);
            this.panel1.TabIndex = 240;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(430, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy Managerment Version 1.0";
            // 
            // dgvDoanhThuThuoc
            // 
            this.dgvDoanhThuThuoc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDoanhThuThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThuThuoc.GridColor = System.Drawing.Color.White;
            this.dgvDoanhThuThuoc.Location = new System.Drawing.Point(219, 149);
            this.dgvDoanhThuThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDoanhThuThuoc.Name = "dgvDoanhThuThuoc";
            this.dgvDoanhThuThuoc.RowHeadersWidth = 51;
            this.dgvDoanhThuThuoc.RowTemplate.Height = 29;
            this.dgvDoanhThuThuoc.Size = new System.Drawing.Size(961, 430);
            this.dgvDoanhThuThuoc.TabIndex = 244;
            this.dgvDoanhThuThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhThuThuoc_CellClick);
            this.dgvDoanhThuThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhThuThuoc_CellContentClick);
            // 
            // Frm_DrugSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 713);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDoanhThuThuoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_DrugSales";
            this.Text = "Frm_DrugSales";
            this.Load += new System.EventHandler(this.Frm_DrugSales_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDoanhThuThuoc;
        private System.Windows.Forms.Label label2;
    }
}