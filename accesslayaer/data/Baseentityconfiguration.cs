﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.models.departmentmodule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace accesslayaer.data
{
    public class Baseentityconfiguration<T> : IEntityTypeConfiguration<T> where  T : BaseEntity

    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            
        }
    }
}
