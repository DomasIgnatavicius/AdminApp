using System.ComponentModel.DataAnnotations;

namespace AdminApp.Models
{
    public class Category
    {
        public Category(int id, string name, DateTime createDateTime, DateTime updateDateTime)
        {
            Id = id;
            Name = name;
            CreateDateTime = createDateTime;
            UpdateDateTime = updateDateTime;
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
