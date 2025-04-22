using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.models.departmentmodule;
using accesslayaer.models.employee;
using Microsoft.EntityFrameworkCore;

namespace accesslayaer.data
{
    public class dbcontext:DbContext

    {
        public  dbcontext(DbContextOptions<dbcontext> options ) : base(options)
        {

        }   
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
