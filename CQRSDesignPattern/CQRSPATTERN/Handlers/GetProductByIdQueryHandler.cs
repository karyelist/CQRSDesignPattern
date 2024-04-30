using CQRSDesignPattern.CQRSPATTERN.Queries;
using CQRSDesignPattern.CQRSPATTERN.Results;
using CQRSDesignPattern.Dal;

namespace CQRSDesignPattern.CQRSPATTERN.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {

            var values = _context.Set<Product>().Find(query.Id);
            return new GetProductByIdQueryResult { Name = values.Name, Id = values.Id, Price = values.Price, Stock = values.Stock };
        }
    }
}
