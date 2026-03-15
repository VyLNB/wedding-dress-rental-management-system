using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique.GUI.User
{
    public partial class DonThueStaff : UserControl
    {
        public DonThueStaff()
        {
            InitializeComponent();
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            donThue_toolstrip_panel.Controls.Clear();
            KhachHangToolstrip_item khachHangPg = new KhachHangToolstrip_item();
            khachHangPg.Dock = DockStyle.Fill;
            donThue_toolstrip_panel.Controls.Add(khachHangPg);
        }

        private void DonThueStaff_Load(object sender, EventArgs e)
        {
            donThue_toolstrip_panel.Controls.Clear();
            KhachHangToolstrip_item khachHangPg = new KhachHangToolstrip_item();
            khachHangPg.Dock = DockStyle.Fill;
            donThue_toolstrip_panel.Controls.Add(khachHangPg);


        }

        private void donThueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            donThue_toolstrip_panel.Controls.Clear();
            DonThueToolstrip_item donThuePg = new DonThueToolstrip_item();
            donThuePg.Dock = DockStyle.Fill;
            donThue_toolstrip_panel.Controls.Add(donThuePg);
        }

        private void danhSachDonThue_Click(object sender, EventArgs e)
        {
            donThue_toolstrip_panel.Controls.Clear();
            DonThueToolstrip_item donThuePg = new DonThueToolstrip_item();
            donThuePg.Dock = DockStyle.Fill;
            donThue_toolstrip_panel.Controls.Add(donThuePg);
        }
    }
}
