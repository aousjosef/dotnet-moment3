using System.ComponentModel.DataAnnotations;

namespace Moment_3.Models
{
    public class Book
    {

        public int Id { get; set; }

        public string? Title { get; set; }

        [Display(Name = "Publication date")]
        public DateOnly PubDate { get; set; }

        public string? Genre { get; set; }


        [Display(Name = "Avaliable")]
        public bool? IsAvaliable { get; set; } = true;

        public int AuthorId { get; set; }

        public Author? Author { get; set; }
    }
}
