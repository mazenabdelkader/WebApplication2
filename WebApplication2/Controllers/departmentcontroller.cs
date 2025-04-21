using Bussiness_Logic_Layer.services;
using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class departmentcontroller : Controller

    {
        private readonly departmentservice _departmentservice;

        public departmentcontroller(departmentservice departmentservice)
        {
            _departmentservice = departmentservice;
        }
        public IActionResult index()
        {
            return View();

        }
        public IActionResult create()
        {
            return View();
        }

        public IActionResult delete()
        {
            return View();
        }
    }
}
