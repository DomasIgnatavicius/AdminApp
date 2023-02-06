using System.ComponentModel.DataAnnotations;

namespace AdminApp.Models
{
    public class Client
    {
        public Client()
        {
        }

        public Client(int id, string name, string lastName, string email, string city, string country, string address, int phoneNr, DateTime createDateTime, DateTime updateDateTime)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            City = city;
            Country = country;
            Address = address;
            PhoneNr = phoneNr;
            CreateDateTime = createDateTime;
            UpdateDateTime = updateDateTime;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public int PhoneNr { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }

    }
}
