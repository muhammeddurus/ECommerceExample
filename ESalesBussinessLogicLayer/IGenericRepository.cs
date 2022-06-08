using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESalesBussinessLogicLayer
{
    public interface IGenericRepository<T> 
    {
        List<T> GetAll();
        T GetById(int itemId);
        void Insert(T item);
        void Update(T item);
        void Delete(int itemId);
    }
}
