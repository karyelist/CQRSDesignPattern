namespace CQRSDesignPattern.CQRSPATTERN.Queries
{
    public class GetProductByIdQuery
    {
        public GetProductByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
