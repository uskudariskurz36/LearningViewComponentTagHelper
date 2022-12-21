using Microsoft.AspNetCore.Mvc;

namespace LearningViewComponentTagHelper.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private List<string> _list = new List<string> { "xxx", "yyy", "zzz", "aaa" };

        public IViewComponentResult Invoke(int count, bool inline = false)
        {
            if (inline)
            {
                return View("Inline", _list.Take(count).ToList());// Inline.cshtml
            }
            else
            {
                return View(_list.Take(count).ToList());    // Default.cshtml
            }

        }
    }
}
