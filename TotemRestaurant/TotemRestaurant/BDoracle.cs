using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.DataAccess.Client;
namespace TotemRestaurant
{
    class BDoracle
    {

        string conexionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        public OracleConnection GetOracleConnection()
        {
            OracleConnection conexion = new OracleConnection(conexionString);
            return conexion;
        }
        public void conectar()
        {
            OracleConnection conexion = new OracleConnection(conexionString);
            conexion.Open();
            System.Windows.Forms.MessageBox.Show("Se ha realizado la conexion");
        }

        public OracleConnection Conectar()
        {
            OracleConnection conexion = new OracleConnection(conexionString);
            conexion.Open();
            return conexion;
        }

        public bool ExisteReserva(string codigoReserva)
        {
            try
            {
                using (OracleConnection conexion = Conectar())
                {
                    string query = "SELECT COUNT(1) FROM RESERVA WHERE CODIGO = :codigoReserva AND ESTADO_RESERVA = 'Reservado'";
                    using (OracleCommand cmd = new OracleCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new OracleParameter("codigoReserva", codigoReserva));

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar la existencia de la reserva: " + ex.Message);
                return false;
            }
        }

        public bool ConfirmarReserva(string codigoReserva)
        {
            try
            {
                using (OracleConnection conexion = Conectar())
                {
                    OracleTransaction trans = conexion.BeginTransaction(); // Iniciar la transacción justo después de abrir la conexión.

                    string query = "UPDATE RESERVA SET ESTADO_RESERVA = 'Confirmada' WHERE CODIGO = :codigoReserva";
                    using (OracleCommand cmd = new OracleCommand(query, conexion))
                    {
                        cmd.Transaction = trans; // Asignar la transacción al comando.
                        cmd.Parameters.Add(new OracleParameter("codigoReserva", codigoReserva));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            trans.Commit(); // Hacer commit si la actualización fue exitosa.
                        }
                        else
                        {
                            trans.Rollback(); // Hacer rollback si no se afectaron filas.
                        }

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al confirmar la reserva: " + ex.Message, ex);
            }

        }



    }
}