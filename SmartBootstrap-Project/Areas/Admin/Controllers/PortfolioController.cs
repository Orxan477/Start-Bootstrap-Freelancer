using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartBootstrap_Project.DAL;
using SmartBootstrap_Project.Models;
using SmartBootstrap_Project.Utilities;
using SmartBootstrap_Project.ViewModel;
using SmartBootstrap_Project.ViewModel.PortfolioVM;
using System.Linq;
using System.Threading.Tasks;

namespace SmartBootstrap_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortfolioController : Controller
    {
        private IWebHostEnvironment _env;
        private AppDbContext _context;
        private string _errorMessageValid;
        private int _size;
        public PortfolioController(AppDbContext context, IWebHostEnvironment env)
        {
            _env = env;
            _context = context;
            _size = Setting("Size");
        }
        private int Setting(string key)
        {
            string dbSetting = _context.Settings
                             .Where(s => s.Key == key)
                             .Select(s => s.Value)
                             .FirstOrDefault();
            int option = int.Parse(dbSetting);
            return (option);
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Portfolio = await _context.Portfolios.Where(p => p.IsDeleted == false).ToListAsync(),
            };
            return View(homeVM);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreatePortfolioVM createPortfolioVM)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = await _context.Portfolios
                                        .AnyAsync(p => p.Name.Trim().ToLower() == createPortfolioVM.Name.Trim().ToLower());

            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu ad movcuddur");
                return View();
            }
            if (!CheckImageValid(createPortfolioVM.Photo))
            {
                ModelState.AddModelError("Photo", _errorMessageValid);
                return View();
            }
            string fileName = await createPortfolioVM.Photo.SaveFileAsync(_env.WebRootPath, @"assets\img");
            Portfolio portfolio = new Portfolio
            {
                Name = createPortfolioVM.Name,
                Information = createPortfolioVM.Information,
                Image = fileName,
            };
            await _context.Portfolios.AddAsync(portfolio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        private bool CheckImageValid(IFormFile photo)
        {
            if (photo.CheckSize(_size))
            {
                _errorMessageValid= $"{photo.FileName} adlı şəkilin formatı {_size} kb-dan çoxdur";
                return false;
            }
            if (!photo.CheckType("image/"))
            {
                _errorMessageValid = $"{photo.FileName} adlı şəkilin tipi duzgun deyil";
                return false;
            }
            return true;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Portfolio dbPortfolio = await _context.Portfolios
                                                  .Where(p => p.IsDeleted == false && p.Id == id)
                                                  .FirstOrDefaultAsync();
            if (dbPortfolio == null) NotFound();
            dbPortfolio.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int id)
        {
            Portfolio portfolio =_context.Portfolios.Find(id);
            if (portfolio == null) NotFound();
            return View(portfolio);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id,Portfolio portfolio)
        {
            if (!ModelState.IsValid) return View();

            if (portfolio.Id == id) BadRequest();
            Portfolio dbportfolio = await _context.Portfolios
                                                  .Where(p => p.Id == id)
                                                  .FirstOrDefaultAsync();

            if (!CheckImageValid(portfolio.Photo))
            {
                ModelState.AddModelError("Photo", _errorMessageValid);
                return View();
            }
            string fileName = await portfolio.Photo.SaveFileAsync(_env.WebRootPath, @"assets\img");
            Helper.FileRemove(_env.WebRootPath, "img", dbportfolio.Image);
            dbportfolio.Image = fileName;
            dbportfolio.Name = portfolio.Name;
            dbportfolio.Information = portfolio.Information;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
