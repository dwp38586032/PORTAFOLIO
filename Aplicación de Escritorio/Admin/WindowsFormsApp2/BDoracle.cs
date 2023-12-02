using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp2
{
    public class BDoracle
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

        public bool ValidarUsuario(string email, string password)
        {
            using (OracleConnection conexion = new OracleConnection(conexionString))
            {
                conexion.Open();
                using (OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM usuario WHERE EMAIL = :email AND CONTRASENA = :password", conexion))
                {
                    cmd.Parameters.Add(new OracleParameter("email", email));
                    cmd.Parameters.Add(new OracleParameter("password", password));

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void AgregarMesa(int num_mesa, int capacidad, string descripcion, string estado)
        {
            using (OracleConnection conexion = Conectar())
            {
                string query = "INSERT INTO MESA (NUM_MESA, CAPACIDAD, DESCRIPCION, ESTADO) VALUES (:num_mesa, :capacidad, :descripcion, :estado)";
                OracleCommand cmd = new OracleCommand(query, conexion);

                cmd.Parameters.Add(new OracleParameter("num_mesa", num_mesa));
                cmd.Parameters.Add(new OracleParameter("capacidad", capacidad));
                cmd.Parameters.Add(new OracleParameter("descripcion", descripcion));
                cmd.Parameters.Add(new OracleParameter("estado", estado));

                cmd.ExecuteNonQuery();
            }
        }

        public void BorrarMesa(int idMesa)
        {
            using (OracleConnection conexion = Conectar())
            {
                
                OracleCommand cmd = new OracleCommand("DELETE FROM MESA WHERE ID_MESA = :C", conexion);
                cmd.Parameters.Add(new OracleParameter("id", idMesa));
                cmd.ExecuteNonQuery();
            }
        }

        public void BorrarCliente(int clienteId)
        {
            using (OracleConnection conexion = Conectar())
            {
                string query = "DELETE FROM CLIENTE WHERE ID_CLIENTE = :clienteId";
                OracleCommand cmd = new OracleCommand(query, conexion); 
                cmd.Parameters.Add(new OracleParameter(":ID_CLIENTE", clienteId)); 
                cmd.ExecuteNonQuery();
            }
        }

    }







}
