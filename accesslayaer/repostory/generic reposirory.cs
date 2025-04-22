using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.data;
using accesslayaer.models.departmentmodule;
using accesslayaer.repostory.interfaces;
using Bussiness_Logic_Layer.models;

namespace accesslayaer.repostory
{
    public class generic_reposirory<T>(dbcontext dbcontext) : Igenericrepository<T> where T : BaseEntity
    {
        private readonly dbcontext db;
        public int add(T t)
        {
            using dbcontext dbcontext = new dbcontext();
            dbcontext.Set<T>().Add(t);
           
            return dbcontext.SaveChanges();
        }

        public int delete(T t)
        {
            using dbcontext dbcontext = new dbcontext();
            dbcontext.Set<T>().Remove(t);
            return dbcontext.SaveChanges();
        }

        public IEnumerable<T> getall(bool withtracking = false)
        {
            using dbcontext dbcontext = new dbcontext();
            return dbcontext.Set<T>().ToList();
        }

        public T getbyid(int id)
        {
            using dbcontext dbcontext = new dbcontext();
            return dbcontext.Set<T>().Find(id);
        }

        public int update(T t)
        {
            using dbcontext dbcontext = new dbcontext();
            dbcontext.Set<T>().Update(t);
            return dbcontext.SaveChanges();
        }
    }
}
