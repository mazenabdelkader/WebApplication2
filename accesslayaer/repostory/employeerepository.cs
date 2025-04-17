using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.data;
using accesslayaer.models.employee;
using Bussiness_Logic_Layer.models;

namespace accesslayaer.repostory
{
    public class employeerepository(dbcontext dbcontext) : generic_reposirory<employee>(dbcontext), iemployeerepository
    {
        public IQueryable<employee> addresss (string address)
        {
            throw new NotImplementedException();

        }
        
    
    }
}
