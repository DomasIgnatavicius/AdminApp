using System.ComponentModel.DataAnnotations;

namespace AdminApp.Models
{
    public class Transaction
    {
        public Transaction(int id, int clientId, int cost, DateTime createDateTime, DateTime updateDateTime)
        {
            Id = id;
            ClientId = clientId;
            Cost = cost;
            CreateDateTime = createDateTime;
            UpdateDateTime = updateDateTime;
        }

        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int Cost { get; set; }
        public virtual List<Product> Products { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
