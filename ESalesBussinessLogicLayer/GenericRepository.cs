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


        public GenericRepository()
        {

        }


        public void Delete(int itemId)
        {
            using (var context = new Context())
            {
                T silinecek = context.Set<T>().Find(itemId);
                context.Set<T>().Remove(silinecek);
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new Context())
            {
                
                return context.Set<T>().ToList();
            }
            
        }

        public T GetById(int itemId)
        {
            using (var context = new Context())
            {

                return context.Set<T>().Find(itemId);
            }
          
        }

        public void Insert(T item)
        {
            using (var context = new Context())
            {

                context.Set<T>().Add(item);
                context.SaveChanges();
            }
            
        }

        public void Update(T item)
        {
            using (var context = new Context())
            {

                context.Set<T>().Attach(item);
                context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
           
        }



    }
}
