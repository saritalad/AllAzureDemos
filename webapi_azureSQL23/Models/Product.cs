namespace webapi_azureSQL23.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public Decimal? Price { get; set; }
        public DateTime mfd { get; set; }
    }
}
