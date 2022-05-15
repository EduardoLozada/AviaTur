using Negocio;
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

namespace AviatTur
{
  public partial class Reporte : Form
  {

    VuelosModel vuelosModel = new VuelosModel();
    CiudadesModel ciudadesModel = new CiudadesModel();
    EstadosModel estadosModel = new EstadosModel();
    private double vl_dIdVuelo = 0;
    private bool vl_bEditar = false;
    Dashboard form11;
    public Reporte(Dashboard form1)
    {
      form11 = form1;
      InitializeComponent();
    }


    private void mostrarVuelos(string pi_sTextoBuscar="")
    {
      dtgVuelos.DataSource = vuelosModel.MostrarVuelos(pi_sTextoBuscar);
    }

    private void frmAnalytics_Load(object sender, EventArgs e)
    {
      mostrarVuelos();      
    }

    private void dtgVuelos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {

      if (this.dtgVuelos.Columns[e.ColumnIndex].Name == "Estado")
      {
        if (e.Value != null)
        {
          if (e.Value.Equals("Programado"))
          {
            e.CellStyle.ForeColor = Color.Black;
            e.CellStyle.BackColor = Color.LightGreen;
          }
          else if (e.Value.Equals("Abordando"))
          {
            e.CellStyle.BackColor = Color.DarkGreen;
          }
          else
          {
            e.CellStyle.BackColor = Color.Red;
          }
        }
      }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      if (textBox1.Text != "Buscar y/o Filtrar")
        mostrarVuelos(textBox1.Text);
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      if (textBox1.Text == "")
      {
        textBox1.Text = "Buscar y/o Filtrar";
        textBox1.ForeColor = Color.DimGray;
      }
    }

    private void textBox1_Enter(object sender, EventArgs e)
    {
      if (textBox1.Text == "Buscar y/o Filtrar")
      {
        textBox1.Text = "";
        textBox1.ForeColor = Color.Black;
      }
    }

    public void dtgVuelos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      form11.test_method(sender, e, dtgVuelos.CurrentRow.Cells["Id Vuelo"].Value.ToString());

    }
  }
}
