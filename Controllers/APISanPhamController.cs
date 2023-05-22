using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopLapMoBile.Models;
using ShopLapMoBile.Models.APISanPhamQG;
using System.Numerics;

namespace ShopLapMoBile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class APISanPhamController : ControllerBase
    {
        QlbanValiContext db=new QlbanValiContext();

        [HttpGet("{maquocgia}")]
        
        public IEnumerable<SanPham> GetAllSP(string maquocgia)
        {
            var listSanPham = (from b in db.TDanhMucSps 
                               where b.MaNuocSx == maquocgia
                               select new SanPham

                               {
                                   MaSp= b.MaSp,
                                   MaNuocSx=b.MaNuocSx,
                                   TenSp=b.TenSp,
                                   AnhDaiDien=b.AnhDaiDien

                               }).ToList();
            return listSanPham;
        }
    }
    
    }

