using CQRSDesignPattern.CQRSPATTERN.Results;
using CQRSDesignPattern.Dal;

namespace CQRSDesignPattern.CQRSPATTERN.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                Id = x.Id,
                Price = x.Price,
                ProductName = x.Name,
                StockQuantity = x.Stock
            }).ToList() ;

            return values;
        }
    }
}
