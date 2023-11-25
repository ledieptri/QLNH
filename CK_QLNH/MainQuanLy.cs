using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK_QLNH
{
    public partial class MainQuanLy : Form
    {
        public MainQuanLy()
        {
            InitializeComponent();
        }

        private void buttonQuanLyNV_Click(object sender, EventArgs e)
        {
            QuanLyNV_UC qlnhanvien = new QuanLyNV_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(qlnhanvien);
        }

        private void buttonQLBan_Click(object sender, EventArgs e)
        {
            QLBan_UC qlban = new QLBan_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(qlban);
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            ThongKe_UC thongke = new ThongKe_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(thongke);
        }

        private void buttonQLMon_Click(object sender, EventArgs e)
        {
            QLMon_UC qlmon = new QLMon_UC();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(qlmon);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void MainQuanLy_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

      
    }
}
