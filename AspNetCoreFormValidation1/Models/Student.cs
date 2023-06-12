using System.ComponentModel.DataAnnotations;

namespace AspNetCoreFormValidation1.Models
{
    public class Student
    {

        //default error message
        [Required]
        public string Name { get; set; } = string.Empty;

        //custom error message
        [Required(ErrorMessage = "Please enter email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Enter a valid number.")]
        public int? Age { get; set; }
        

    }
}
