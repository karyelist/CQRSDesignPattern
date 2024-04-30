namespace CQRSDesignPattern.CQRSPATTERN.Results
{
    public class GetProductQueryResult
    {
        public int Id { get; set; }

        public int StockQuantity { get; set; }

        public string ProductName { get; set; }
        public string Desc { get; set; }

        public decimal Price { get; set; }


    }
}
