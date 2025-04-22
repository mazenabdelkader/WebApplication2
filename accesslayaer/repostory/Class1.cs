using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.models.departmentmodule;
using accesslayaer.repostory.interfaces;

namespace accesslayaer.repostory
{
    public class Class1 : IDepartmentRepository

    {
        public int add(department entity)
        {
            throw new NotImplementedException();
        }

        public int delate(department delete)
        {
            throw new NotImplementedException();
        }

        public department getbyid(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<department> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public int update(department entity)
        {
            throw new NotImplementedException();
        }
        public void test ()
        {
            GetDepartments();
        }
}
    
}
