using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;
using Persistence.Repository;

namespace services.Services
{
    public class UserService : IUserService
    {
        IEncryption _ecrypt;
        public UserService()
        {
            _ecrypt = new Ecryption();
        }
        public User findUser(int id)
        {
            using (var uow=new UnitOfWork())
            {
                User user = uow.getRepository<User>().get(id);
                return user;
            }
        }
        
        public User createAccount(User user)
        {
            
            using ( var uow = new UnitOfWork())
            {
                var repo = uow.getRepository<User>();
                var u = repo.get(user.Id);
                if (u!=null)
                    return null;
                user.Password = _ecrypt.generateHash(user.Password);
                repo.save(user);
                uow.saveChanges();
                return user;
            }
        }

        public User removeAccount(int idUser)
        {
            using (var uow = new UnitOfWork())
            {
                var user = uow.getRepository<User>().get(idUser);
                var repo = uow.getRepository<User>();
                if (user != null)
                {
                    repo.remove(idUser);
                    uow.saveChanges();
                    return user;
                }
                return user;
            }
        }

        public Boolean logIn(string username, string password)
        {
            using (var uow = new UnitOfWork())
            {
                var u = uow.getRepository<User>().getAll().FirstOrDefault(x=>x.Username == username && _ecrypt.verifiyHash(password,x.Password));
                if(u!=null)
                    return true;
                return false;
            }
        }

        public User updateAccount(User user)
        {
            using (var uow = new UnitOfWork())
            {
                var repo = uow.getRepository<User>();
                var u = repo.get(user.Id);
                if (u == null)
                    return null;
                user.Password = _ecrypt.generateHash(user.Password);
                repo.update(user.Id,user);
                uow.saveChanges();
                return user;
            }
        }
    }
}
