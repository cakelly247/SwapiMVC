using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SwapiMVC.Models;

namespace SwapiMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static Random _random = new Random();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string[] names = {"Chris", "Holly", "Mike", "Steve", "Mary", "Alan", "Jonathan", "Henry"};
        int nameIndex = _random.Next(names.Length);
        string name = names[nameIndex];
        return View(model: name);
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
