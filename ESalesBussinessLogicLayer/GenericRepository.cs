using ESalesDataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESalesBussinessLogicLayer
{
    public class GenericRepository<T, TContext> : IGenericRepository<T> 
        where T : class, new()
        where TContext : Context, new()
    {

        Context context = new Context();
        public GenericRepository()
        {

        }


        public void Delete(int itemId)
        {
            
                T silinecek = context.Set<T>().Find(itemId);
                context.Set<T>().Remove(silinecek);
                context.SaveChanges();
            
        }

        public List<T> GetAll()
        {
            
                
                return context.Set<T>().ToList();
            
            
        }

        public T GetById(int itemId)
        {
          

                return context.Set<T>().Find(itemId);
            
          
        }

        public void Insert(T item)
        {
            

                context.Set<T>().Add(item);
                context.SaveChanges();
            
            
        }

        public void Update(T item)
        {
          

                context.Set<T>().Attach(item);
                context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            
           
        }



    }
}
