using System.ComponentModel.DataAnnotations;

namespace Task1_MVC.Models
{
    public class Department
    {
        [Required]
        [Range(1, 4)]
        public int DepartmentId { get; set; } 
        [Required]
        public string DepartmentName { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}
