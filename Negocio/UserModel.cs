using System;
using Datos;

namespace CapaNegocio
{
  public class UserModel
  {
    UserDAO UserDAO = new UserDAO();
    public bool LoginUser(string pi_User , string pi_sPassword, ref string pi_sUsuNombre, ref string pi_sPerCodigo) {
      return UserDAO.Login(pi_User, pi_sPassword,ref pi_sUsuNombre,ref pi_sPerCodigo);
    }
    

  }
}
