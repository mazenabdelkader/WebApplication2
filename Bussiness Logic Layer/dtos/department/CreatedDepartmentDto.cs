﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Buisness.DataTransferObject.Departments
{
    public class CreatedDepartmentDto
    {
        [Required]
        public string Code { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        [Display(Name = "Date Of Creation")]
        public DateOnly DateOfCreation { get; set; }


    }
}
