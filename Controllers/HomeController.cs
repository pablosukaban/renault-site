using Microsoft.AspNetCore.Mvc;

namespace web.Controllers;

public class HomeController : Controller
{

    private readonly ContextDB _context;

    public HomeController(ILogger<HomeController> logger, ContextDB db)
    {
        _context = db;
    }

    public IActionResult Index()
    {
        return LocalRedirect("/index.html");
    }

    public IActionResult submitForm(TestDrive testdrive)
    {
        _context.TestDrives.Add(testdrive);
        _context.SaveChanges();

        return LocalRedirect("/testDrive.html");
    }

    public IActionResult showDb() 
    {
        return View(_context.TestDrives.ToList());
    }
}
