
using System.ComponentModel.DataAnnotations;

namespace MVCApi.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Size { get; set; }
    }
}
