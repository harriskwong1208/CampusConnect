using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCApi.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
      
        public string? Nationality { get; set; }

      
        public long? Phone { get; set; }
        [Range(2000,2050, ErrorMessage = "Year must be between 2000 and 2050 only!")]
        public int? Year { get; set; }   
        public string? Email { get; set; }  
        public int? MajorId { get; set; }
        public int? CampusId { get; set; }  

        public Major Major { get; set; }
        public Campus Campus { get; set; }
        
    }
}
