using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Logic_Layer.models;

namespace accesslayaer
{
    public interface idepartmentrepository
    {
        IEnumerable<department> getall(bool withtracking=false);
        department getbyid(int id);
        int update(department department);
        int delete(department department);
        int add(department department);
    }
}
