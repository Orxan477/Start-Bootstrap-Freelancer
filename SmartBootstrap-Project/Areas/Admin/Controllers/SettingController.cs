using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartBootstrap_Project.DAL;
using SmartBootstrap_Project.Models;
using SmartBootstrap_Project.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace SmartBootstrap_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        public AppDbContext _context { get;}
        public SettingController(AppDbContext context)
        {
          _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
               Settings=await _context.Settings.ToListAsync(),
            };
            return View(homeVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Setting dbSetting = await _context.Settings
                                                  .Where(p => p.Id == id)
                                                  .FirstOrDefaultAsync();
            if (dbSetting == null) NotFound();
            _context.Remove(dbSetting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int id)
        {
            Setting setting = _context.Settings.Find(id);
            if (setting == null) NotFound();
            return View(setting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Setting setting)
        {
            if (!ModelState.IsValid) return View();

            if (setting.Id == id) BadRequest();
            Setting dbSetting = await _context.Settings
                                                  .Where(p => p.Id == id)
                                                  .FirstOrDefaultAsync();

            if (dbSetting == null) return NotFound();
            dbSetting.Value = setting.Value;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
