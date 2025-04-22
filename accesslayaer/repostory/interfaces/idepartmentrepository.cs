using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.models.departmentmodule;

namespace accesslayaer.repostory.interfaces
{
    public interface idepartmentrepository
    {
        IEnumerable<department> getall(bool withtracking = false);
        department getbyid(int id);
        int update(department department);
        int delete(department department);
        int add(department department);
    }
}
