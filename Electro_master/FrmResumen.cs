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

namespace Electro_master
{
    public partial class FrmResumen : Form
    {
        public FrmResumen()
        {
            InitializeComponent();
        }
        string conexion = "Server=.\\SQLEXPRESS;Database=ElectroMaster_Reportes;Integrated Security=true;";
        private void FrmResumen_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = @"SELECT NombreProducto, SUM(Cantidad) AS StockTotal
                                 FROM StockSucursal
                                 GROUP BY NombreProducto";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvResumen.DataSource = dt;
                dgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
