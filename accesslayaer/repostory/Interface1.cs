using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Logic_Layer.models;

namespace accesslayaer.repostory
{
    internal interface Interface1
    {
        IEnumerable<department> GetDepartments();   //getaall
        department getbyid(int id);

        int update(department entity);
        int delate(department delete);

        int add (department entity);    

    }
}
