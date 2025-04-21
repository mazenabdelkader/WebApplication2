using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.models.employee;
using accesslayaer.models.enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace accesslayaer.data
{
    public class employeeconfiguration : IEntityTypeConfiguration<employee>
    {
        public void Configure(EntityTypeBuilder<employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(p => p.Name).HasColumnType("varchar(50)");
            builder.Property(p => p.Address).HasColumnType("varchar(50)");
            builder.Property(p => p.Salary).HasColumnType("decimal(10,2)");
           // builder.Property(p => p.Gender)
           //.HasConversion(
           // empgender => empgender.ToString(),
           // (returned) => (gender)Enum.Parse(typeof(gender), returned)
           // );

        }
    }
}
