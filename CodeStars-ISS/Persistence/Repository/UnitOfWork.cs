using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting;
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
            string errors = "";
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (DbEntityValidationResult entityErr in dbEx.EntityValidationErrors)
                {
                    foreach (DbValidationError error in entityErr.ValidationErrors)
                    {
                        errors += String.Format("{0} : Error: {1} \n",
                        error.PropertyName, error.ErrorMessage);
                    }
                }
            }
            finally
            {
                if (errors != "")
                    throw new Exception(errors);
            }
        }

    }
}
