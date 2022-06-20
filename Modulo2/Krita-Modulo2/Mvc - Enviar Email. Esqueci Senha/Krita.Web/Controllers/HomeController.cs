namespace Krita.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILoginRepository _loginRepository;
    private readonly AppSettings _appSettings;

    public HomeController(ILoginRepository loginRepository, AppSettings appSettings)
    {
        _loginRepository = loginRepository;
        _appSettings = appSettings;
    }
    
    public IActionResult Index()
    {
        return View();
    }
}
