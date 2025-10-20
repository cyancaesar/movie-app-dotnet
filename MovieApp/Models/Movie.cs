using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleasedDate { get; set; }

        // "?" mark this field as `nullable`
        public string? Genre { get; set; }
        
        public decimal Price { get; set; }
    }
}