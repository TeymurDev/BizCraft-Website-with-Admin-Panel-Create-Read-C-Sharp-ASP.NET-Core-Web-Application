using BizCraftCrudAP.DAL;
using BizCraftCrudAP.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BizCraftCrudAP.Controllers
{
    public class HomeController : Controller
    {
        private readonly BizContext _context;

        public HomeController(BizContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeIndexViewM homeIndexViewM = new HomeIndexViewM
            {
                Teams = _context.Teams
            };
            return View(homeIndexViewM);
        }
    }
}