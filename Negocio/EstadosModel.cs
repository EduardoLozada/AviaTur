
using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
  public class EstadosModel
  {
    EstadosDAO EstadosDAO = new EstadosDAO();

    public List<Tuple<int, string>> TraerEstados()
    {
      List<Tuple<int, string>> vl_oDataReader;
      vl_oDataReader = EstadosDAO.TraerEstados();
      return vl_oDataReader;
    }
  }
}
