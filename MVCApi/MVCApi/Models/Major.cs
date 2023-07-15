using System.ComponentModel.DataAnnotations;

namespace MVCApi.Models
{
    public class Major
    {
        [Key]
        public int Id { get; set; }
        public string School { get; set; }
        public int YearsToComplete { get; set; }    


    }
}
