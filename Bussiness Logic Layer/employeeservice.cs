using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.repostory;

namespace Bussiness_Logic_Layer
{
    public class employeeservice(iemployeerepository iemployeerepository) : iemployeeservice
    {
        public IEnumerable<employeedto> getall(bool withtracking = false)
        {
            throw new NotImplementedException();
        }
    }
}
