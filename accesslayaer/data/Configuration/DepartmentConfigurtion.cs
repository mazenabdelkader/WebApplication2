using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.models.departmentmodule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace accesslayaer.data.Configuration
{
    public class DepartmentConfigurtion : IEntityTypeConfiguration<department>
    {
        public void Configure(EntityTypeBuilder<department> builder)
        {
            builder.Property(d => d.id).UseIdentityColumn(10, 10);
            builder.Property(d => d.Name).HasColumnType("varchar(max)");
            builder.Property(d => d.code).HasColumnType("varchar(max)");
            builder.Property(d => d.createdon).HasDefaultValueSql("GETDATE");
            builder.Property(d => d.lastmodifiedon).HasComputedColumnSql("GETDATE");


        }
    }



}
