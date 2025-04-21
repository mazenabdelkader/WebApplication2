using Demo.DataAcess.Entities.Common.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Buisness.DataTransferObject.Employees
{
    public class UpdatedEmployeeDto
    {

        public int Id { get; set; }

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
        public Gender Gender { get; set; }
        public EmployeeType EmployeeType { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public IFormFile? Image { get; set; }



    }
}
