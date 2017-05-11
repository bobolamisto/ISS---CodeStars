using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class UnitOfWork : IDisposable
    {
        private DatabaseContext context;

        public UnitOfWork()
        {
            context = new DatabaseContext();
        }

        public UnitOfWork(DatabaseContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }

        public CRUDRepository<E> getRepository<E>() where E : class
        {
            return new CRUDRepository<E>(context);
        }

        public void saveChanges()
        {
            context.SaveChanges();
        }

    }
}
