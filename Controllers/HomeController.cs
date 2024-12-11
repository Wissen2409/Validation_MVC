using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Validation_MVC.Models;

namespace Validation_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(UserViewModel model)
    {
        //ModelState.İsValid view tarafında konulan validasyona uyulmadığını söyler
        // iki değer verir
        // eğer sonuç true ise, view ekranında konulan validasyona uyulmuştur
        // eğer sonuç false ise, view ekranında konulan validasyona uyulmamıştır

        // Action içerisinde ModelState.Isvalid kullanılarak, istenilen operasyın gerçekleştirilir!!
        if(ModelState.IsValid){

           return RedirectToAction("Privacy","Home");
        }
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
