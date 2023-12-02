using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
public class GraciasController : Controller
{

    private readonly ReservaService _reservaService;

    public GraciasController(ReservaService reservaService)
    {
        _reservaService = reservaService;
        
    }
    public IActionResult Index()
    {
        return View();
    }





}
