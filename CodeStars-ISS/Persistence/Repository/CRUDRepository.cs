using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class CRUDRepository<E> : ICRUDRepository<E> where E : class
    {
        private DatabaseContext context;

        public CRUDRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public E save(E item)
        {
            return context.Set<E>().Add(item);
            //context.SaveChanges();
        }

        public IEnumerable<E> getAll()
        {
            return context.Set<E>().ToList();
        }

        public E get(int id)
        {
            return context.Set<E>().Find(id);

        }

        public void remove(int id)
        {
            E existing = get(id);
            context.Set<E>().Remove(existing);
            //context.SaveChanges();
        }

        public void update(int id, E newItem)
        {
            E oldItem = get(id);
            context.Entry(oldItem).CurrentValues.SetValues(newItem);
           // context.SaveChanges();
        }
    }

}
