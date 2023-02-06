namespace AdminApp.Models.DTO
{
    public class CreateProductDTO
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
