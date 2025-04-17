using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.data;
using Bussiness_Logic_Layer.models;

namespace accesslayaer.repostory
{
    public class departmentrepository(dbcontext dbcontext):generic_reposirory<department>(dbcontext),idepartmentrepository
    {
      

    }
}
