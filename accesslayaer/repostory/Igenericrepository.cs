using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.models.departmentmodule;
using Bussiness_Logic_Layer.models;

namespace accesslayaer.repostory
{
    public interface Igenericrepository<T> where T:BaseEntity
    {
        IEnumerable<T> getall(bool withtracking = false);
        T getbyid(int id);
        int update(T T);
        int delete(T T);
        int add(T T);
    }
}
