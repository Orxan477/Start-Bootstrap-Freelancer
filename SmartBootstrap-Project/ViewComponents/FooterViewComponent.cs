using Microsoft.AspNetCore.Mvc;

namespace SmartBootstrap_Project.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
