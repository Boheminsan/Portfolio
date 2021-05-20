using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Abstract;
using System.Linq;

namespace Portfolio.WebUI.Models.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private IFooterRepository footer;
        public FooterViewComponent(IFooterRepository _footer)
        {
            footer = _footer;
        }
        public IViewComponentResult Invoke()
        {
            var footers = footer.GetAll().ToList();
            return View(footers);
        }
    }
}