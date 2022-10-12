using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _531Project1.Models;

namespace _531Project1.Controllers;

public class HomeController : Controller
{
    private ScottDbContext _context { get; set; }
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, ScottDbContext c)
    {
        _logger = logger;
        _context = c;
    }

    public IQueryable<Scott> Scotts => _context.michael;

    public IActionResult Index()
    {

        ViewBag.test = Scotts.ToList();
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

