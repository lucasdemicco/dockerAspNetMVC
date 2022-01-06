using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dockerMvc.Models;

namespace dockerMvc.Controllers;

public class HomeController : Controller
{
    private IRepository repo;
    private string message;

    public HomeController(IConfiguration config, IRepository repository)
    {
        repo = repository;
        message = config["MESSAGE"] ?? "ASP NET Core MVC - Docker";
    }

    public IActionResult Index()
    {
        ViewBag.Message = message;
        return View(repo.Produtos);
    }
}
