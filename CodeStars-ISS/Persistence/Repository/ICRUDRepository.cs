using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public interface ICRUDRepository<E>
    {
        E get(int id);
        IEnumerable<E> getAll();
        E save(E item);
        void remove(int id);
        void update(int id, E newItem);


    }
}
