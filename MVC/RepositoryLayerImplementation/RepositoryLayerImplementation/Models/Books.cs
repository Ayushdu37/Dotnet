using System.ComponentModel.DataAnnotations;

namespace RepositoryLayerImplementation.Models
{
    public class Book
    {
        public int Id { get; set; }

        //[MaxLength(15)]
        public string FullName { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public float Price { get; set; }
    }
}
