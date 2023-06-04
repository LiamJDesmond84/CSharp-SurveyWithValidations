using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CSharp_SurveyWithValidations.Models;
using System.Security.Cryptography.X509Certificates;

namespace CSharp_SurveyWithValidations.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult Submit(User user)
    {
        if(ModelState.IsValid)
        {
            return View("Submission", user);
        }
        return View("Index");
    }
}
