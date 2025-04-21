using Bussiness_Logic_Layer.dtos.department;
using Demo.Buisness.DataTransferObject.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Buisness.Services.Departments
{
    public interface IDepartmentServices
    {
        IEnumerable<depratmentdto> GetAllDepartments();
        DepartmentDetailsDto GetDepartmentById(int id);

        int CreatedDepartment(CreatedDepartmentDto department);

        int UpdateDepartment(UpdatedDepartmentDto department);

        bool DeleteDepartment(int id);

    }
}
