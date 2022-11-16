using Microsoft.AspNetCore.Mvc;

namespace web.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;

    private readonly ContextDB _context;

    public HomeController(ILogger<HomeController> logger, ContextDB db)
    {
        // _logger = logger;
        _context = db;
    }

    public IActionResult Index()
    {
        return LocalRedirect("/index.html");
    }

    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }

    // public int getCount()
    // {
    //     return _context.TestDrives.Count();
    // }

    public void submitForm(TestDrive testdrive)
    {
        _context.TestDrives.Add(testdrive);
        _context.SaveChanges();
    }
}
