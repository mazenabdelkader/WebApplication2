﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic_Layer.dtos.department
{
    internal class UpdatedDepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;

        public DateOnly DateOfCreation { get; set; }


    }
}
