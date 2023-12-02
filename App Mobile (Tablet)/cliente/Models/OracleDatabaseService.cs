using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client; 
using System.Data;
using Microsoft.Extensions.Configuration;


    public class OracleDatabaseService
    {
        private readonly string _connectionString;
    private readonly OracleDatabaseService _databaseService;

    public OracleDatabaseService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()
        {
            return new OracleConnection(_connectionString);
        }


    public async Task<OrdenPedidoViewModel> ObtenerPedidoPorIdAsync(int id)
    {
        using (var connection = CreateConnection())
        {
            connection.Open();

            var query = "SELECT ID_ORDEN_PEDIDO, CONTENIDO, ESTADO FROM ORDEN_PEDIDO WHERE ID_ORDEN_PEDIDO = :id";

            using (var command = new OracleCommand(query, (OracleConnection)connection))
            {
                command.Parameters.Add(new OracleParameter("id", id));

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        var ordenPedido = new OrdenPedidoViewModel
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("ID_ORDEN_PEDIDO")),
                            Contenido = reader.IsDBNull(reader.GetOrdinal("CONTENIDO")) ? null : reader.GetString(reader.GetOrdinal("CONTENIDO")),
                            Estado = reader.IsDBNull(reader.GetOrdinal("ESTADO")) ? null : reader.GetString(reader.GetOrdinal("ESTADO")),
                        };
                        return ordenPedido;
                    }
                }
            }
        }

        return null;
    }

    public async Task<bool> ActualizarPedidoAsync(OrdenPedidoViewModel pedido)
    {
        using (var connection = CreateConnection())
        {
            connection.Open();

            var query = @"
            UPDATE ORDEN_PEDIDO 
            SET ESTADO = :estado 
            WHERE ID_ORDEN_PEDIDO = :id";

            using (var command = new OracleCommand(query, (OracleConnection)connection))
            {
                command.Parameters.Add(new OracleParameter("estado", pedido.Estado));
                command.Parameters.Add(new OracleParameter("id", pedido.Id));

                var result = await command.ExecuteNonQueryAsync();

                return result == 1;
            }
        }
    }

}

