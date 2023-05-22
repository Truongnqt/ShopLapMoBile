using Microsoft.AspNetCore.Mvc;
using ShopLapMoBile.Repository;
using System.ComponentModel;

namespace ShopLapMoBile.ViewComponents
{
    public class MenuQuocGiaViewComponent: ViewComponent
    {
        private readonly IQuocGIa iquocgia;
        public MenuQuocGiaViewComponent(IQuocGIa quocGIa) { this.iquocgia = quocGIa; }
        public IViewComponentResult Invoke()
        {
            return View(iquocgia.GetAllQuocGia().OrderBy(x => x.TenNuoc));
        }


    }
}
