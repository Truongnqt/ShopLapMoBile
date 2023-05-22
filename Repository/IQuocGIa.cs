using ShopLapMoBile.Models;

namespace ShopLapMoBile.Repository
{
    public interface IQuocGIa
    {
        TQuocGium Add(TQuocGium quocgia);
        TQuocGium Update(string mamuoc);
        TQuocGium Delete(string manuoc);
        TQuocGium GetQuocGia(string manuoc);
        IEnumerable<TQuocGium> GetAllQuocGia();
    }
}
