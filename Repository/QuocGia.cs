using ShopLapMoBile.Models;

namespace ShopLapMoBile.Repository
{
    public class QuocGia : IQuocGIa
    {
        private readonly QlbanValiContext _context;
        public QuocGia(QlbanValiContext context)
        {
            {
                this._context = context;
            }


        }

        public TQuocGium Add(TQuocGium quocgia)
        {
            throw new NotImplementedException();
        }

        public TQuocGium Delete(string manuoc)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TQuocGium> GetAllQuocGia()
        {
            return _context.TQuocGia;
        }

            public TQuocGium GetQuocGia(string manuoc)
        {
            throw new NotImplementedException();
        }

        public TQuocGium Update(string mamuoc)
        {
            throw new NotImplementedException();
        }
    }
}

