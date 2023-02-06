namespace AdminApp.Models.DTO
{
    public class GetProductDTO
    {
        public GetProductDTO(Product product)
        {
            Name = product.Name;
            Price= product.Price;
            Description= product.Description;
            Rating= product.Rating;
            Category = product.Category.Name;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public string Category { get; set; }
    }
}
