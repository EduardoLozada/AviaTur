using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
  public abstract class Conexion
  {
    
    private readonly string ConnectionString;
      public Conexion()
    {
      ConnectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    }    
    protected  SqlConnection GetConnection()
    {
      return new SqlConnection(ConnectionString);
    }
  }
}
