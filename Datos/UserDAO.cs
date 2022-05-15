using System.Data;
using System.Data.SqlClient;


namespace Datos
{
  public class UserDAO : Conexion
  {
    public bool Login(string pi_sUser,string pi_sPassword, ref string pi_sUsuNombre, ref string pi_sPerCodigo)
    {
      using (var conection = GetConnection())
      {
        conection.Open();
        using (var cmd = new SqlCommand("SPValidaLogin" , conection))
        {                  
          cmd.CommandType = CommandType.StoredProcedure;          
          cmd.Parameters.Add(new SqlParameter("@piUser", pi_sUser));
          cmd.Parameters.Add(new SqlParameter("@piPassword", pi_sPassword));
          
          using (SqlDataReader rdr = cmd.ExecuteReader())
          {            
            while (rdr.Read())
            {
              pi_sUsuNombre = (string)rdr["USUNombre"];
              pi_sPerCodigo = (string)rdr["PERDescripcion"];
              return true;              
            }
            if (rdr.HasRows) {
              return true;
            }
            else
            {
              return false;
            }
          }
        }
      }
    }
  }
}
