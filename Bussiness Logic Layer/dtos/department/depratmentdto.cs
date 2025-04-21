using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic_Layer.dtos.department
{
    public class depratmentdto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string code { get; set; }
        public int id { get; set; }
        public int createdby { get; set; }
        public DateTime createdon { get; set; }
        public int lastmodifiedby { get; set; }
        public DateTime lastmodifiedon { get; set; }
        public bool isdeleted { get; set; }
    }
}
