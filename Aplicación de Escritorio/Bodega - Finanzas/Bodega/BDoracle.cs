using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.DataAccess.Client;

namespace Bodega
{
    class BDoracle
    {
        string conexionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public OracleConnection Conectar()
        {
            OracleConnection conexion = new OracleConnection(conexionString);
            conexion.Open();
            return conexion;
        }
        public void conectar()
        {
            OracleConnection conexion = new OracleConnection(conexionString);
            conexion.Open();
     
        }
        public int? ValidarUsuario(string email, string password)
        {
            using (OracleConnection conexion = new OracleConnection(conexionString))
            {
                conexion.Open();
                using (OracleCommand cmd = new OracleCommand("SELECT ID_ROLES FROM USUARIO WHERE EMAIL = :email AND CONTRASENA = :password", conexion))
                {
                    cmd.Parameters.Add(new OracleParameter("email", email));
                    cmd.Parameters.Add(new OracleParameter("password", password));

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return null;
                    }
            }
        }
    }
    }
}
