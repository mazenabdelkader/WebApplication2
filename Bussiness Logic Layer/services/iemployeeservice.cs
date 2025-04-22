using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.models.employee;
using Bussiness_Logic_Layer.dtos.employee;


namespace Bussiness_Logic_Layer.services
{
    public interface iemployeeservice
    {
        IEnumerable<employeedto> getall(bool withtracking = false);
        EmployeeDetailsDto getbyid(int id);
        int createemployee(createdemployeedto employee);
        int updateemployee(UpdatedEmployeeDto employee);
        bool deleteemployee(int id); 

    }
}
