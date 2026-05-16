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
using System.Windows.Forms.DataVisualization.Charting;

namespace Electro_master
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        string conexion = "Server=.\\SQLEXPRESS;Database=ElectroMaster_Reportes;Integrated Security=true;";
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            CargarVentas();
            CargarStock();
        }

        private void CargarVentas()
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = @"SELECT Sucursal, SUM(Total) TotalVentas
                                 FROM Ventas GROUP BY Sucursal";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chartVentas.Series.Clear();
                chartVentas.Series.Add("Ventas");
                chartVentas.Series[0].ChartType = SeriesChartType.Column;

                foreach (DataRow row in dt.Rows)
                {
                    chartVentas.Series[0].Points.AddXY(
                        row["Sucursal"].ToString(),
                        Convert.ToDouble(row["TotalVentas"])
                    );
                }
            }
        }

        private void CargarStock()
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = @"SELECT Sucursal, SUM(Cantidad) Stock
                                 FROM StockSucursal GROUP BY Sucursal";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chartStock.Series.Clear();
                chartStock.Series.Add("Stock");
                chartStock.Series[0].ChartType = SeriesChartType.Pie;

                foreach (DataRow row in dt.Rows)
                {
                    chartStock.Series[0].Points.AddXY(
                        row["Sucursal"].ToString(),
                        Convert.ToDouble(row["Stock"])
                    );
                }
            }
        }
    }
}
