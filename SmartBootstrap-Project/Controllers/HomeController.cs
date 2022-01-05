using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartBootstrap_Project.DAL;
using SmartBootstrap_Project.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace SmartBootstrap_Project.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
            Portfolio=await _context.Portfolios
                                    .Where(p => p.IsDeleted == false)
                                    .ToListAsync(),
            };
            return View(homeVM);
        }
    }
}
