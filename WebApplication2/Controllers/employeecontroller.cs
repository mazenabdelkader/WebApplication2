using accesslayaer.models.employee;
using accesslayaer.models.enums;
using accesslayaer.repostory;
using Bussiness_Logic_Layer.dtos.employee;
using Bussiness_Logic_Layer.services;
using Microsoft.AspNetCore.Mvc;
using PL.Models;

namespace PL.Controllers
{
    public class employeecontroller(iemployeeservice iemployeeservice) : Controller
    {
        public IActionResult Index()
        {
            var emloyees=iemployeeservice.getall();
            return View(emloyees);
        }
        [HttpGet]
        public IActionResult create() => View();
        [HttpPost]
        public IActionResult create(createdemployeedto createdemployeedto)
        {
    return View();


        }
        [HttpGet]
        public IActionResult details(int? id)
        {

            if (id is null) return BadRequest();

            var employee = iemployeeservice.getall(id.HasValue);
            if (employee is null) return NotFound();

            return View(employee);

        }
        [HttpGet]  
        public IActionResult edit(int? id) 
        {

            if (!id.HasValue) return BadRequest();

            var employee = iemployeeservice.getbyid(id.Value);
            if (employee is null) return NotFound();
            var employeeViewModel = new EmployeeModel()
            {

                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Email = employee.Email,

                HiringDate = employee.HiringDate,
                IsActive = employee.IsActive,
                PhoneNumber = employee.PhoneNumber,
                Salary = employee.Salary,
                EmployeeType = Enum.Parse<EmployeeType>(employee.EmployeeType),
                Gender = Enum.Parse<Gender>(employee.Gender)

            };
            return View(employeeViewModel);

        }

    }
}
