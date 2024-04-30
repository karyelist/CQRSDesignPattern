namespace CQRSDesignPattern.CQRSPATTERN.Queries
{
    public class GetProductUpdateByIdQuery
    {
        
        public GetProductUpdateByIdQuery(int Id)
        {
            Id = Id;
        }

        public int Id { get; set; }


    }
}
