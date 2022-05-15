using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
  public class CiudadesDAO : Conexion
  {
    public List<Tuple<string, string>> TraerCiudades()
    {
      var vl_oRetorno = new List<Tuple<string, string>>();
      try
      {
        using (var conection = GetConnection())
        {
          conection.Open();
          using (var cmd = new SqlCommand("SPTraerCiudades", conection))
          {
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
              while (rdr.Read())
              {
                vl_oRetorno.Add(Tuple.Create(rdr.GetString(0), rdr.GetString(1)));
              }
            }
          }
        }
        return vl_oRetorno;
      }
      catch (Exception ex)
      {

        throw ex;
      }
    }
  }
}
