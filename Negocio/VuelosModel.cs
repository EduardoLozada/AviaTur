
using Datos;
using System;
using System.Collections;
using System.Data;

namespace Negocio
{
  public class VuelosModel
  {
    VuelosDAO vuelosDAO = new Datos.VuelosDAO();

    public DataTable MostrarVuelos()
    {
      DataTable vl_oTablaVuelos = new DataTable();
      vl_oTablaVuelos = vuelosDAO.MostrarVuelos();
      return vl_oTablaVuelos;
    }

    public ArrayList traerDetalle(double pi_dIdValue )
    {
      ArrayList arr = new ArrayList();
      arr = vuelosDAO.TraerDetalle(pi_dIdValue);
      return arr;
    }

    public void InsertarVuelo(object pi_iCiudadO, object pi_iCiudadD,DateTime pi_sFecha, DateTime pi_sHoraS , DateTime pi_sHorraL, object pi_sEstado)
    {
      vuelosDAO.InsertarVuelo(Convert.ToString(pi_iCiudadO), Convert.ToString(pi_iCiudadD), Convert.ToString(pi_sFecha),Convert.ToString(pi_sHoraS),Convert.ToString(pi_sHorraL), Convert.ToInt32(pi_sEstado));     
    }

    public void ActualizarVuelo(DateTime pi_sFecha, DateTime pi_sHoraS, DateTime pi_sHorraL, object pi_sEstado,double pi_dIdVuelo)
    {
      vuelosDAO.ActualizarVuelo( Convert.ToString(pi_sFecha), Convert.ToString(pi_sHoraS), Convert.ToString(pi_sHorraL), Convert.ToInt32(pi_sEstado) , pi_dIdVuelo);
    }

    

  }
}
