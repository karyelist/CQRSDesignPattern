using CQRSDesignPattern.CQRSPATTERN.Commands;
using CQRSDesignPattern.Dal;

namespace CQRSDesignPattern.CQRSPATTERN.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.Id);
            values.Name = command.Name;
            values.Price = command.Price;
            values.Status = true;
            values.Stock = command.Stock;
            values.Description = command.Description;

            _context.SaveChanges();

        }
    }
}
