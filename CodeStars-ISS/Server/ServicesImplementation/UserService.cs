using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using services.Services;
using Model.Domain;
using Persistence.Repository;
using Model;
using Model.DTOModels;

namespace server.ServicesImplementation
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

        public UserDTO logIn(string username, string password)
        {
            using (var uow = new UnitOfWork())
            {
                var u = uow.getRepository<User>().getAll().FirstOrDefault(x=>x.Username == username && _ecrypt.verifiyHash(password,x.Password));
                if(u==null)
                    return null;
                //dupa ce intra servicul de conversie, o sa shimb
                var userDto = new UserDTO()
                {
                    Admin = u.Admin,
                    Email = u.Email,
                    FirstName = u.FirstName,
                    Id = u.Id,
                    LastName = u.LastName,
                    Password = u.Password
                };
                return userDto;
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

        public IEnumerable<User> findAll()
        {
            using (var uow = new UnitOfWork())
            {
                return uow.getRepository<User>().getAll();
            }
        }
    }
}
