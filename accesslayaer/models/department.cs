﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.models.departmentmodule;

namespace Bussiness_Logic_Layer.models
{
    public class department:BaseEntity
    {
        public string Name { get; set; }    
        public string Description { get; set; } 
        public string code { get; set; }    
        
    }
}
