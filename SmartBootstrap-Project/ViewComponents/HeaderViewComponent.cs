using Microsoft.AspNetCore.Mvc;

namespace SmartBootstrap_Project.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
