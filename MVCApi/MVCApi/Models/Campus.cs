using System.ComponentModel.DataAnnotations;

namespace MVCApi.Models
{
    public class Campus
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
