using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
  public class EstadosDAO : Conexion
  {
    public List<Tuple<int, string>> TraerEstados()
    {
      try
      {
        var vl_oRetorno = new List<Tuple<int, string>>();
        using (var conection = GetConnection())
        {
          conection.Open();
          using (var cmd = new SqlCommand("SPTraerEstados", conection))
          {
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
              while (rdr.Read())
              {
                vl_oRetorno.Add(Tuple.Create(rdr.GetInt32(0), rdr.GetString(1)));
              }
            }
          }
        }
        return vl_oRetorno;
      }
      catch (Exception ex)
      {
        System.Diagnostics.Trace.WriteLine("EstadosDAO.TraerEstados  ERROR:" + ex.Message);
        throw ex;
      }

    }
  }
}
