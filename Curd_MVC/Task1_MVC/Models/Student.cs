using System.ComponentModel.DataAnnotations;

namespace Task1_MVC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]

        public string Name { get; set; }
        [Range(19, 25, ErrorMessage = "Age must be between 19 and 25")]
        public int age { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string adress { get; set; }
        [Required]
        [Range (1,4)]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
      
    }
}
