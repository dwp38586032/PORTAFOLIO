using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



public class TestController : Controller
    {
        private readonly OracleDatabaseService _oracleDatabaseService;

        public TestController(OracleDatabaseService oracleDatabaseService)
        {
            _oracleDatabaseService = oracleDatabaseService;
        }

        public IActionResult prueba()
        {
            try
            {
                using (var connection = _oracleDatabaseService.CreateConnection())
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = "SELECT ESTADO FROM MESA"; 
                    var result = command.ExecuteScalar().ToString();

                    return View("Prueba", result); 
                }
            }
            catch (Exception ex)
            {
                return View("prueba", "Error: " + ex.Message);
            }
        }
        public ActionResult Index()
        {
            return View();
        }


    }

