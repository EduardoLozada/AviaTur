using Negocio;
using System;
using System.Collections;
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
  public partial class Detalle : Form
  {

    VuelosModel vuelosModel = new VuelosModel();
    CiudadesModel ciudadesModel = new CiudadesModel();
    EstadosModel estadosModel = new EstadosModel();
    private double vl_dIdVuelo = 0;
    private bool vl_bEditar = false;
    Dashboard form11;
    public Detalle(Dashboard FrmPrincipal,string pi_sIdVuelo)
    {
      form11 = FrmPrincipal;
      vl_dIdVuelo =Convert.ToDouble(pi_sIdVuelo);
      InitializeComponent();
    }

   

    private void frmAnalytics_Load(object sender, EventArgs e)
    {
      ArrayList arr = new ArrayList();
      arr = vuelosModel.traerDetalle(vl_dIdVuelo);
      label12.Text = (string)arr[1];
      label13.Text = (string)arr[3];
      label14.Text = (string)arr[2];
      label15.Text = (string)arr[4];
      label16.Text = (string)arr[5];
      label17.Text = (string)arr[6];
      label18.Text = (string)arr[0];
      label19.Text = (string)arr[10];
      label20.Text = (string)arr[7];
      label21.Text = (string)arr[8];
      label22.Text = (string)arr[9];
    }

    private void button1_Click(object sender, EventArgs e)
    {
      form11.test_method(sender, e, null , true);
    }
  }
}
