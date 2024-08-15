using System.ComponentModel.DataAnnotations;

namespace SimpleProject.Models
{
    public class Coontact
    {

        public int Id { get; set; }
        [MaxLength(5)]
        public string Comment { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
