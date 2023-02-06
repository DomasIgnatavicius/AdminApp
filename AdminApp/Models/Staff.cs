using System.ComponentModel.DataAnnotations;

namespace AdminApp.Models
{
    public class Staff
    {
        public Staff(int id, string name,string lastName, string email, string role, int officeId, DateTime createDateTime, DateTime updateDateTime)
        {
            Id= id;
            Name= name;
            LastName= lastName;
            Email= email;
            Role= role;
            OfficeId= officeId;
            CreateDateTime= createDateTime;
            UpdateDateTime= updateDateTime;
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int OfficeId { get; set; }
        public virtual Office Office { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
