using System.ComponentModel.DataAnnotations;

namespace Projet_Session.Models
{
    public class Detail_Location
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int productId { get; set; }
        public int OrderId { get; set; }
    }
}
