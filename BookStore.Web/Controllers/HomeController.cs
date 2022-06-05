using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStore.Web.Models;
using BookStore.EntityFramworkCore;
using BookStore.Application.User;

namespace BookStore.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUserAppService _userAppService;

    public HomeController(ILogger<HomeController> logger, IUserAppService userAppService)
    {
        _logger = logger;
        _userAppService = userAppService;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.User = await _userAppService.Get("100", "123456");
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
