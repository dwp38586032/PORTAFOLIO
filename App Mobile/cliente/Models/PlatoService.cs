using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;

public class PlatoService
    {
        private readonly OracleDatabaseService _databaseService;

        public PlatoService(OracleDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<List<PlatoModel>> GetPlatosAsync()
        {
            var platos = new List<PlatoModel>();


            using (var connection = _databaseService.CreateConnection())
            {
            connection.Open();
            string query = "SELECT ID_PLATO, NOMBRE, PRECIO, RUTA_IMAGEN, TIEMPO_PREPARACION FROM PLATO";
                using (var command = new OracleCommand(query, (OracleConnection)connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            platos.Add(new PlatoModel
                            {
                                IdPlato = reader.GetInt32("ID_PLATO"),
                                Nombre = reader["NOMBRE"].ToString(),
                                Precio = (decimal)reader["PRECIO"],
                                TiempoPreparacion = reader["TIEMPO_PREPARACION"].ToString(),
                                Imagen = reader["RUTA_IMAGEN"].ToString(),

                            });
                        }
                    }
                }
            }

            return platos;
        }
    }

