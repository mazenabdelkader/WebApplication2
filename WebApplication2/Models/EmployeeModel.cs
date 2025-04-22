using accesslayaer.models.enums;
using System.ComponentModel.DataAnnotations;

namespace PL.Models
{
    public class EmployeeModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Max Length Should Be 50")]
        [MinLength(5, ErrorMessage = "Max Length Should Be 5")]
        public string Name { get; set; } = null!;
        //-------------------------------
        [Range(22, 30)]
        public int? Age { get; set; }

        //----------------------------------

        public string? Address { get; set; }
        //---------------------------
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        //-------------------------------
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        //---------------------------
        [Display(Name = "Phone Number")]
        [Phone]
        public string? PhoneNumber { get; set; }

        //------------------------------
        [EmailAddress]
        public string? Email { get; set; }
        //------------------------

        [Display(Name = "Hiring Date")]

        public DateOnly HiringDate { get; set; }

        //-------------------------
        public gender Gender { get; set; }
        public employeetype EmployeeType { get; set; }

        [Display(Name = "Department")]
        public int? DepartmentId { get; set; }

        public IFormFile? Image { get; set; }

    }
}
