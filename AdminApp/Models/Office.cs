using System.ComponentModel.DataAnnotations;

namespace AdminApp.Models
{
    public class Office
    {
        public Office(int id, string city, string country, string address, DateTime createDateTime, DateTime updateDateTime)
        {
            Id = id;
            City = city;
            Country = country;
            Address = address;
            CreateDateTime = createDateTime;
            UpdateDateTime = updateDateTime;
        }

        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public virtual List<Staff> Staff { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
