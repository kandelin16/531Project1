using System.ComponentModel.DataAnnotations;

namespace _531Project1.Models
{
    public class Scott
    {

        [Key]
        [Required]
        public int Id { get; set; }
        public string Title { get; set; }    
        public string PictureUrl { get; set; }
        public string Quote { get; set; }
    }
}
