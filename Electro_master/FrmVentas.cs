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

    public partial class FrmVentas : Form
    {
        string conexion = "Server=.\\SQLEXPRESS;Database=ElectroMaster_Reportes;Integrated Security=true;";
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = @"SELECT Sucursal, SUM(Total) AS TotalVentas
                                 FROM Ventas
                                 GROUP BY Sucursal";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvVentas.DataSource = dt;
                dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
