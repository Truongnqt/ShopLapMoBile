using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopLapMoBile.Models;
using System.Diagnostics;
using X.PagedList;

namespace ShopLapMoBile.Controllers
{
    public class HomeController : Controller
    {
        private readonly QlbanValiContext qlbanValiContext=new QlbanValiContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int ? page)
        {
            int pageNumber = page == null || page < 1 ? 1 : page.Value;
            int pageSize = 4;
            var lstsanpham = qlbanValiContext.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp);
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }
        public IActionResult GetSanPhamByMaQuocGia()
        {
            return View();    
        }
        [HttpGet]
        public IActionResult ThhemSanPham()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}