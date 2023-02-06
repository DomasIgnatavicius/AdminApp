using System.ComponentModel.DataAnnotations;

namespace AdminApp.Models
{
    public class Product
    {
        public Product(){ }
        public Product(int id, string name, double price, string description, double rating, int supply, double yearSalesTotal, int yearTotalSoldUnits,int categoryId, DateTime createDateTime, DateTime updateDateTime)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Rating = rating;
            Supply = supply;
            YearSalesTotal = yearSalesTotal;
            YearTotalSoldUnits = yearTotalSoldUnits;
            CategoryId = categoryId;
            CreateDateTime = createDateTime;
            UpdateDateTime = updateDateTime;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public int Supply { get; set; }
        public double YearSalesTotal { get; set; }
        public int YearTotalSoldUnits { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
