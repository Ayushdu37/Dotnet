using System.ComponentModel.DataAnnotations;

namespace OneToManyEF.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string City { get; set; }

        // One customer can have many orders
        public List<Order> Orders { get; set; }
    }
}
