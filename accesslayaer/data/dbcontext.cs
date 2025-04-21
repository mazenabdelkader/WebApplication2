using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.models.employee;
using Bussiness_Logic_Layer.models;
using Microsoft.EntityFrameworkCore;

namespace accesslayaer.data
{
    public class dbcontext:DbContext

    {

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.;database=Mazen;trusted_connection=true;");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<department> department { get; set; }
        public DbSet<employee> Employees { get; set; }

       
    }
}
