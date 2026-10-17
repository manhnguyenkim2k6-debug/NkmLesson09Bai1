using Microsoft.AspNetCore.Mvc;

namespace Nkm_Lesson09.Areas.Admins.ViewComponents
{
    [ViewComponent(Name = "NavLeft")]
    public class NavLeftViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}