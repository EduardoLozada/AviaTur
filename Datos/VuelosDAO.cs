using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Datos
{
  public class VuelosDAO : Conexion
  {
    public DataTable MostrarVuelos(string pi_sTextoBuscar = "")
    {
      try
      {
        DataTable vl_oTablaVuelos = new DataTable();
        using (var conection = GetConnection())
        {
          conection.Open();
          using (var cmd = new SqlCommand("SPTraerVuelos", conection))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@piTextoBuscar", pi_sTextoBuscar);
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
              if (rdr.HasRows)
              {
                vl_oTablaVuelos.Load(rdr);
              }
            }
          }
        }
        return vl_oTablaVuelos;
      }
      catch (Exception ex)
      {
        System.Diagnostics.Trace.WriteLine("VuelosDAO.MostrarVuelos ERROR:" + ex.Message);
        throw ex;
      }
    }

    public ArrayList TraerDetalle(double pi_dIdVuelo)
    {
      try
      {
        ArrayList vl_oRetorno = new ArrayList();
        using (var conection = GetConnection())
        {
          conection.Open();
          using (var cmd = new SqlCommand("SPTraerDetalle", conection))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@piIdVuelo", pi_dIdVuelo);
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
              while (rdr.Read())
              {
                vl_oRetorno.Add(rdr["Id Vuelo"]);
                vl_oRetorno.Add((string)rdr["Ciudad Origen"]);
                vl_oRetorno.Add((string)rdr["Origen"]);
                vl_oRetorno.Add((string)rdr["AeropuertoO"]);
                vl_oRetorno.Add((string)rdr["Ciudad Destino"]);
                vl_oRetorno.Add((string)rdr["AeropuertoD"]);
                vl_oRetorno.Add((string)rdr["Destino"]);
                vl_oRetorno.Add(rdr["Fecha"]);
                vl_oRetorno.Add(rdr["Hora Salida"]);
                vl_oRetorno.Add(rdr["Hora Llegada"]);
                vl_oRetorno.Add(rdr["Estado"]);
              }
            }
          }
        }
        return vl_oRetorno;
      }
      catch (Exception ex)
      {
        System.Diagnostics.Trace.WriteLine("VuelosDAO.TraerDetalle ERROR:" + ex.Message);
        throw ex;
      }
    }

    public void InsertarVuelo(string pi_iCiudadO, string pi_iCiudadD, string pi_sFecha, string pi_sHoraS, string pi_sHorraL, int pi_sEstado)
    {
      try
      {
        using (var conection = GetConnection())
        {
          conection.Open();
          using (var cmd = new SqlCommand("SPinsertarVuelos", conection))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@piIATAOrigen", pi_iCiudadO);
            cmd.Parameters.AddWithValue("@piIATADestino", pi_iCiudadD);
            cmd.Parameters.AddWithValue("@piFecha", pi_sFecha);
            cmd.Parameters.AddWithValue("@piHoraSalida", pi_sHoraS);
            cmd.Parameters.AddWithValue("@piHoraLlegada", pi_sHorraL);
            cmd.Parameters.AddWithValue("@piESOCodigo", pi_sEstado);
            cmd.ExecuteNonQuery();
          }
        }
      }
      catch (Exception ex)
      {
        System.Diagnostics.Trace.WriteLine("VuelosDAO.InsertarVuelo ERROR:" + ex.Message);
        throw ex;
      }

    }
    public void ActualizarVuelo(string pi_sFecha, string pi_sHoraS, string pi_sHorraL, int pi_sEstado, double pi_dIdVuelo)
    {
      try
      {
        using (var conection = GetConnection())
        {
          conection.Open();
          using (var cmd = new SqlCommand("SPActualizarVuelos", conection))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@piFecha", pi_sFecha);
            cmd.Parameters.AddWithValue("@piHoraSalida", pi_sHoraS);
            cmd.Parameters.AddWithValue("@piHoraLlegada", pi_sHorraL);
            cmd.Parameters.AddWithValue("@piESOCodigo", pi_sEstado);
            cmd.Parameters.AddWithValue("@IdVuelo", pi_dIdVuelo);
            cmd.ExecuteNonQuery();
          }
        }
      }
      catch (Exception ex)
      {
        System.Diagnostics.Trace.WriteLine("VuelosDAO.ActualizarVuelo ERROR:" + ex.Message);
        throw ex;
      }
    }
  }
}
