namespace AdminApp.Models.DTO
{
    public class GetClientDTO
    {
        public GetClientDTO(Client client)
        {
            Name = client.Name;
            LastName = client.LastName;
            Email = client.Email;
            City= client.City;
            Country= client.Country;
            Address= client.Address;
            PhoneNr= client.PhoneNr;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public int PhoneNr { get; set; }
    }
}
