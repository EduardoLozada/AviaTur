using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace AviatTur
{

  public partial class Login : Form
  {

    public Login()
    {
      InitializeComponent();
    }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    private void txtUsuario_Enter(object sender, EventArgs e)
    {
      if (txtUsuario.Text == "USUARIO")
      {
        txtUsuario.Text = "";
        txtUsuario.ForeColor = Color.Black;
      }
    }

    private void txtUsuario_Leave(object sender, EventArgs e)
    {
      if (txtUsuario.Text == "")
      {
        txtUsuario.Text = "USUARIO";
        txtUsuario.ForeColor = Color.DimGray;
      }
    }

    private void txtContraseña_Enter(object sender, EventArgs e)
    {
      if (txtContraseña.Text == "CONTRASEÑA")
      {
        txtContraseña.Text = "";
        txtContraseña.ForeColor = Color.Black;
        txtContraseña.UseSystemPasswordChar = true;
      }
    }

    private void txtContraseña_Leave(object sender, EventArgs e)
    {
      if (txtContraseña.Text == "")
      {
        txtContraseña.Text = "CONTRASEÑA";
        txtContraseña.ForeColor = Color.DimGray;
        txtContraseña.UseSystemPasswordChar = false;
      }
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnMinimizar_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);

    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void validar()
    {
      string vl_sNombre = "";
      string vl_sPerfil = "";
      string vl_sRutaFoto = "";
      string vl_sfullPath = System.Reflection.Assembly.GetAssembly(typeof(Login)).Location;
      if (vl_sfullPath.Contains("bin"))
        vl_sRutaFoto = "../../Imagenes/" + txtUsuario.Text + ".png";
      else
        vl_sRutaFoto = "Imagenes/" + txtUsuario.Text + ".png";
      try
      {
        if (!txtUsuario.Text.Equals("USUARIO"))
        {
          if (!txtContraseña.Text.Equals("CONTRASEÑA"))
          {
            UserModel userModel = new UserModel();
            var vl_bvalidaLogin = userModel.LoginUser(txtUsuario.Text, txtContraseña.Text, ref vl_sNombre, ref vl_sPerfil);
            if (vl_bvalidaLogin)
            {

              Dashboard form1 = new Dashboard();
              form1.LblUsername.Text = vl_sNombre;
              form1.lblPerfil.Text = vl_sPerfil;
              if (File.Exists(vl_sRutaFoto))
              {
                form1.pbFoto.Image = Image.FromFile(vl_sRutaFoto);
              }
              form1.Show();
              this.Hide();
            }
            else
            {
              MsgError("Usuario o contraseña incorrecto ");
              txtContraseña.Text = "";
              txtContraseña.Focus();
            };
          }
          else MsgError("Por favor ingrese su contraseña");
        }
        else MsgError("Por favor ingrese su usuario");
      }
      catch (Exception ex)
      {
        MessageBox.Show("Se presento un error al intentar validar los datos , Por favor verifique la conexion en el archivo app.config " );
      }
    }

    private void btnAcceder_Click(object sender, EventArgs e)
    {
      validar();
    }

    private void MsgError(string pi_sMessage)
    {
      lblError.Text = pi_sMessage;
      lblError.Visible = true;
    }

    private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int)e.KeyChar == (int)Keys.Enter)
      {
        validar();
      }
    }
  }
}
