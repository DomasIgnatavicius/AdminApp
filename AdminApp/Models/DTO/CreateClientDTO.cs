namespace AdminApp.Models.DTO
{
    public class CreateClientDTO
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public int PhoneNr { get; set; }
    }
}
