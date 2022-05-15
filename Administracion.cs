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
  public partial class Administracion : Form
  {

    VuelosModel vuelosModel = new VuelosModel();
    CiudadesModel ciudadesModel = new CiudadesModel();
    EstadosModel estadosModel = new EstadosModel();
    private double vl_dIdVuelo = 0;
    private bool vl_bEditar = false;
    public Administracion()
    {
      InitializeComponent();
    }


    private void mostrarVuelos(string pi_sTextoBuscar = "")
    {
      dtgVuelos.DataSource = vuelosModel.MostrarVuelos(pi_sTextoBuscar);
    }
    private void cargarDatos()
    {
      try
      {
        List<Tuple<string, string>> vl_oDataReader;
        List<Tuple<string, string>> vl_oDataReader1;
        List<Tuple<int, string>> vl_oDataReader2;
        vl_oDataReader = ciudadesModel.TraerCiudades();
        vl_oDataReader1 = ciudadesModel.TraerCiudades();
        cmbCiudadO.ValueMember = "Item1";
        cmbCiudadO.DisplayMember = "Item2";
        cmbCiudadO.DataSource = vl_oDataReader;

        cmbCiudadD.ValueMember = "Item1";
        cmbCiudadD.DisplayMember = "Item2";
        cmbCiudadD.DataSource = vl_oDataReader1;


        vl_oDataReader2 = estadosModel.TraerEstados();
        cmbEstado.ValueMember = "Item1";
        cmbEstado.DisplayMember = "Item2";
        cmbEstado.DataSource = vl_oDataReader2;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Se ha presentado un error al cargar los datos " + ex);
      }
      
    }

    private void frmAnalytics_Load(object sender, EventArgs e)
    {
      cargarDatos();
      mostrarVuelos();

    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      try
      {

        if (cmbCiudadO.SelectedValue != null & cmbCiudadD.SelectedValue != null & cmbEstado.SelectedValue != null)
        { 
          if (!cmbCiudadO.SelectedValue.ToString().Equals(cmbCiudadD.SelectedValue.ToString())) {
            if (dtpFecha.Value.Date < DateTime.Now.Date)
            {
              lblError.Text = "Error la Fecha para la que desea Programar el vuelo \n ya paso ";
              lblError.Visible = true;
            }
            else if (cmbEstado.SelectedText !="Cancelado"  && (dtpFecha.Value.Date == DateTime.Now.Date && dtpHoras.Value.Hour < DateTime.Now.Hour) || (dtpFecha.Value.Date == DateTime.Now.Date && dtpHoraL.Value.Hour < DateTime.Now.Hour))
            {
              lblError.Text = "Error la Hora para la que desea Programar el vuelo ya paso ";
              lblError.Visible = true;
            }
            else
            {
              if (!vl_bEditar)
              {
                vuelosModel.InsertarVuelo(cmbCiudadO.SelectedValue, cmbCiudadD.SelectedValue, dtpFecha.Value, dtpHoras.Value, dtpHoraL.Value, cmbEstado.SelectedValue);
                MessageBox.Show("Vuelo Programado Correctamente ");
                mostrarVuelos();
              }
              else
              {
                vuelosModel.ActualizarVuelo(dtpFecha.Value, dtpHoras.Value, dtpHoraL.Value, cmbEstado.SelectedValue, vl_dIdVuelo);
                MessageBox.Show("Vuelo Reprogramado Correctamente ");
                mostrarVuelos();
              }
            }
          }
          else
            MessageBox.Show("La ciudad de origen y destino no pueden ser iguales");
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al adicionar o modificar datos" + ex);
      }
    }

    private void btnReprogramar_Click(object sender, EventArgs e)
    {
      try
      {
        if (dtgVuelos.SelectedRows.Count > 0)
        {
          if (dtgVuelos.CurrentRow.Cells["Estado"].Value.ToString() == "Programado")
          {
            vl_bEditar = true;
            cmbCiudadO.SelectedValue = dtgVuelos.CurrentRow.Cells["Origen"].Value.ToString();
            cmbCiudadD.SelectedValue = dtgVuelos.CurrentRow.Cells["Destino"].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(dtgVuelos.CurrentRow.Cells["Fecha"].Value.ToString());
            dtpHoras.Value= Convert.ToDateTime(dtgVuelos.CurrentRow.Cells["Hora Salida"].Value.ToString());
            dtpHoraL.Value = Convert.ToDateTime(dtgVuelos.CurrentRow.Cells["Hora Llegada"].Value.ToString());
            vl_dIdVuelo = Convert.ToDouble(dtgVuelos.CurrentRow.Cells["Id Vuelo"].Value.ToString());
          }
          else
            MessageBox.Show("Solo se pueden reprogramar vuelos en estado Programado ");
        }
        else
          MessageBox.Show("Por favor seleccione el vuelo a reprogramar");
      }
      catch (Exception ex)
      {
        MessageBox.Show("Se presento un error al reprogramar el vuelo " + ex);

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
  }
}
