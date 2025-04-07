using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer;
using Bussiness_Logic_Layer.models;

namespace Bussiness_Logic_Layer
{
    public class departmentservice(idepartmentrepository idepartmentrepository)
    {
        public IEnumerable<depratmentdto> departmen()
        {
            var department = idepartmentrepository.getall();
            var departmentnoreturn = department.Select(d => new depratmentdto()
            {
                id=d.id,
                Name=d.Name,
                code=d.code,
                createdby=d.createdby,
                createdon=d.createdon,
                Description=d.Description,
                isdeleted=d.isdeleted,  
                lastmodifiedby=d.lastmodifiedby,
                lastmodifiedon=d.lastmodifiedon,    


            });
            return departmentnoreturn;
        }

        public depratmentdto GetDepratmentdtobyid(int id)
        {
            var department=idepartmentrepository.getbyid(id);
            if (department is null) return null;
            else
            {
                var departmenttoreturn =new depratmentdto();
                {
           
                    
                 



              


                };
                return departmenttoreturn;
            }
        }
    }
}
