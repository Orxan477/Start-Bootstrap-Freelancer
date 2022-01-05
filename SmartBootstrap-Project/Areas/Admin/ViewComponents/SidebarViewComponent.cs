using Microsoft.AspNetCore.Mvc;

namespace SmartBootstrap_Project.Areas.Admin.ViewComponents
{
    public class SidebarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
