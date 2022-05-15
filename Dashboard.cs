using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AviatTur
{
  public partial class Dashboard : Form
  {

    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

    private static extern IntPtr CreateRoundRectRgn
     (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse

     );

    public Dashboard()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        if (lblPerfil.Text.Equals("Administrador"))
        {
          btnDashbord_Click(sender, e);
        }
        else
        {
          btnAnalytics_Click(sender, e);
          btnDashbord.Visible = false;

        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al cargar la forma" + ex);
      }
    }

    private void btnDashbord_Click(object sender, EventArgs e)
    {
      try
      {
        pnlNav.Height = btnDashbord.Height;
        pnlNav.Top = btnDashbord.Top;
        pnlNav.Left = btnDashbord.Left;
        btnDashbord.BackColor = Color.FromArgb(46, 51, 73);

        lbltitle.Text = "Programar Vuelos";
        this.pnlFormLoader.Controls.Clear();
        Administracion frmAviatTur_vrb = new Administracion() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        frmAviatTur_vrb.FormBorderStyle = FormBorderStyle.None;
        this.pnlFormLoader.Controls.Add(frmAviatTur_vrb);
        frmAviatTur_vrb.Show();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al cargar la forma" + ex);
      }
    }

    private void btnAnalytics_Click(object sender, EventArgs e)
    {
      try
      {
        pnlNav.Height = btnAnalytics.Height;
        pnlNav.Top = btnAnalytics.Top;
        btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

        lbltitle.Text = "Estado De Vuelos";
        this.pnlFormLoader.Controls.Clear();
        Reporte frmAnalytics_vrb = new Reporte(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        frmAnalytics_vrb.FormBorderStyle = FormBorderStyle.None;
        this.pnlFormLoader.Controls.Add(frmAnalytics_vrb);
        frmAnalytics_vrb.Show();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al cargar la forma" + ex);
      }
    }



    private void btnDashbord_Leave(object sender, EventArgs e)
    {
      btnDashbord.BackColor = Color.FromArgb(24, 30, 54);
    }

    private void btnAnalytics_Leave(object sender, EventArgs e)
    {
      btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
    }


    private void button1_Click_1(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }



    private void button2_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Maximized;
    }



    public void btnDetalle_Click(object sender, EventArgs e, string pi_sIdVuelo, bool pi_sRegresar = false)
    {
      try
      {
        if (!pi_sRegresar)
        {
          lbltitle.Text = "Detalle Vuelos";
          this.pnlFormLoader.Controls.Clear();
          Detalle frmAnalytics_vrb = new Detalle(this, pi_sIdVuelo) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
          frmAnalytics_vrb.FormBorderStyle = FormBorderStyle.None;
          this.pnlFormLoader.Controls.Add(frmAnalytics_vrb);
          frmAnalytics_vrb.Show();
        }
        else
        {
          pnlNav.Height = btnDashbord.Height;
          pnlNav.Top = btnDashbord.Top;
          pnlNav.Left = btnDashbord.Left;
          btnDashbord.BackColor = Color.FromArgb(46, 51, 73);

          lbltitle.Text = "Programar Vuelos";
          this.pnlFormLoader.Controls.Clear();
          Reporte frmAviatTur_vrb = new Reporte(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
          frmAviatTur_vrb.FormBorderStyle = FormBorderStyle.None;
          this.pnlFormLoader.Controls.Add(frmAviatTur_vrb);
          frmAviatTur_vrb.Show();
        }


      }
      catch (Exception ex)
      {
        MessageBox.Show("Se ha prensentado un error al cargar el formulario" + ex);
      }
    }

    public void test_method(object sender, System.EventArgs e, string pi_sIdVuelo, bool pi_sRegresar = false)
    {
      btnDetalle_Click(sender, e, pi_sIdVuelo, pi_sRegresar);
    }
  }
}
