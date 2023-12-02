using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

public class PlatoController : Controller
{
    private readonly PlatoService _platoService;

    public PlatoController(PlatoService platoService)
    {
        _platoService = platoService;
    }

    public async Task<IActionResult> Index()
    {
        var platos = await _platoService.GetPlatosAsync();
        return View(platos);
    }
}

