using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.models.employee;
using Bussiness_Logic_Layer.models;

namespace accesslayaer.repostory.interfaces
{
    public interface iemployeerepository
    {
        IEnumerable<employee> getall(bool withtracking = false);
        employee getbyid(int id);
        int update(employee department);
        int delete(employee department);
        int add(employee department);
    }
}
