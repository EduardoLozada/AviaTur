
using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
  public class CiudadesModel
  {
    CiudadesDAO CiudadesDAO = new CiudadesDAO();

    public List<Tuple<string, string>> TraerCiudades()
    {
      List<Tuple<string, string>> vl_oDataReader;
      vl_oDataReader = CiudadesDAO.TraerCiudades();
      return vl_oDataReader;
    }
  }
}
