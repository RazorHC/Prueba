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
    public partial class frmStock : Form
    {
        string conexion = "Server=.\\SQLEXPRESS;Database=ElectroMaster_Reportes;Integrated Security=true;";


        public frmStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = @"SELECT NombreProducto, Cantidad 
                                 FROM StockSucursal 
                                 WHERE Sucursal = @Sucursal";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Sucursal", cmbSucursal.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvStock.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para esta sucursal");
                }
            }

        }

        private void frmStock_Load_1(object sender, EventArgs e)
        {
            cmbSucursal.Items.Add("NORTE");
            cmbSucursal.Items.Add("SUR");
            cmbSucursal.Items.Add("CENTRO");

            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.ReadOnly = true;

        }
    }
}
