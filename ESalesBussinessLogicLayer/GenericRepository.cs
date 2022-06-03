using ESalesDataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESalesBussinessLogicLayer
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        Context db = new Context();
        
        public GenericRepository()
        {

        }
        

        public void Delete(int itemId)
        {
            
            T silinecek = db.Set<T>().Find(itemId);
            db.Set<T>().Remove(silinecek);
            db.SaveChanges();

        }

        public List<T> GetAll()
        {
            
            return db.Set<T>().ToList();
        }

        public T GetById(int itemId)
        {
            return db.Set<T>().Find(itemId);
        }

        public void Insert(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }

        public void Update(T item)
        {
            db.Set<T>().Attach(item);
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        


    }
}
