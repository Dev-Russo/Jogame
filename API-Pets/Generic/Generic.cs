using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pets.Generic
{
    interface Generic<T>
    {
        List<T> List();
        T Inserir(T entity);
        T Find(int Id);
        void Delete(int id);
        T Update(T entity);
    }
}
