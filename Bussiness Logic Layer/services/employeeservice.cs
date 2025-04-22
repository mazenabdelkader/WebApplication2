using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.repostory.interfaces;
using Bussiness_Logic_Layer.dtos.employee;
using Demo.Buisness.DataTransferObject.Employees;

namespace Bussiness_Logic_Layer.services
{
    public class employeeservice(iemployeerepository iemployeerepository) : iemployeeservice
    {
        public int createemployee(createdemployeedto employee)
        {
            throw new NotImplementedException();
        }

        public bool deleteemployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<employeedto> getall(bool withtracking = false)
        {
           var employees= iemployeerepository.getall(withtracking).Select(e => new employeedto
           {
               Id = e.id,
               Name = e.Name,
               Email = e.Email,
               PhoneNumber = e.PhoneNumber,
               Salary = e.Salary,
               EmployeeType= e.EmployeeType,
               IsActive=e.IsActive
           });
            return employees;
        }

        public EmployeeDetailsDto? getbyid(int id)
        {

            var employees = iemployeerepository.getbyid(id);
            if (employees == null) return null;
            else
            {
                var returnedemployee = new EmployeeDetailsDto()
                {
                    Id = employees.id,
                    Name = employees.Name,
                    Email = employees.Email,
                    PhoneNumber = employees.PhoneNumber,
                    Salary = employees.Salary,
                    EmployeeType = employees.EmployeeType,
                    IsActive = employees.IsActive,
                
                    CreatedBy=1,
                    CreatedOn = DateTime.Now,
                    LastModifiedBy=1

                };  

            return returnedemployee;
            }
        }

        public int updateemployee(UpdatedEmployeeDto employee)
        {
            throw new NotImplementedException();
        }
    }
}
