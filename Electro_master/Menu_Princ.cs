using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electro_master
{
    public partial class Menu_Princ : Form
    {
        public Menu_Princ()
        {
            InitializeComponent();
        }

        private void Menu_Princ_Load(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock frm = new frmStock();
            frm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.Show();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            FrmResumen frm = new FrmResumen();
            frm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
        }
    }
}
