using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.models.employee;

namespace Bussiness_Logic_Layer
{
    public interface iemployeeservice
    {
        IEnumerable<employeedto> getall(bool withtracking = false);
    }
}
