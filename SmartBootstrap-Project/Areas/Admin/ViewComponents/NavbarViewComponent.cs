using Microsoft.AspNetCore.Mvc;

namespace SmartBootstrap_Project.Areas.Admin.ViewComponents
{
    public class NavbarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
