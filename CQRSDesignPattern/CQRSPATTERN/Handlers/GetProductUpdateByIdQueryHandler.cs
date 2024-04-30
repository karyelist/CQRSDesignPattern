using CQRSDesignPattern.CQRSPATTERN.Queries;
using CQRSDesignPattern.CQRSPATTERN.Results;
using CQRSDesignPattern.Dal;

namespace CQRSDesignPattern.CQRSPATTERN.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context _context;
        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery getProductUpdateByIdQuery)
        {

            var values = _context.Products.Find(getProductUpdateByIdQuery.Id);
            return new GetProductUpdateQueryResult
            {
                Description = values.Description,
                Id = values.Id,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock
            };
        }
    }
}
