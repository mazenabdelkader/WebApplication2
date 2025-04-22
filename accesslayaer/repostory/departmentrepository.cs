using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesslayaer.data;
using accesslayaer.models.departmentmodule;
using accesslayaer.repostory.interfaces;
using Microsoft.EntityFrameworkCore;

namespace accesslayaer.repostory
{
    public class departmentrepository : idepartmentrepository
    {
        private readonly dbcontext _dbcontext;
        public departmentrepository(dbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }   
        public int add(department entity)
        {


            _dbcontext.department.Add(entity);
            return _dbcontext.SaveChanges(); 
        }

        public int delete(department entity)
        {
            _dbcontext.Remove(entity);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<department> getall(bool withtracking = false)
        {
            if (withtracking)
            { 
            return _dbcontext.department.ToList();
            }
            else
            {
                return _dbcontext.department.AsNoTracking().ToList();   
            }
        }

        public department getbyid(int id)
        {
           return _dbcontext.department.Find(id);   
        }

        public int update(department entity)
        {
             _dbcontext.Update(entity); 
            return _dbcontext.SaveChanges();
        }
    }
}
