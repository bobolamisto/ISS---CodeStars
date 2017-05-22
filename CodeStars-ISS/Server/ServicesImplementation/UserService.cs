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
using Server.ModelConverterServices;

namespace server.ServicesImplementation
{
    public class UserService : IUserService
    {
        private IEncryption _ecrypt;
        private UserConverterService converter;

        public UserService()
        {
            _ecrypt = new Ecryption();
            converter = new UserConverterService();
        }
        public UserDTO findUser(int id)
        {
            using (var uow=new UnitOfWork())
            {
                var user = uow.getRepository<User>().get(id);
                return user == null ? null : converter.convertToDTOModel(user);
            }
        }
        
        public UserDTO createAccount(UserDTO userDTO)
        {
            using (var uow = new UnitOfWork())
            {
                var userRepo = uow.getRepository<User>();
                if (userRepo.get(userDTO.Id) != null)
                    return null;
                userDTO.Validation = "Waiting";
                userDTO.Password = _ecrypt.generateHash(userDTO.Password);
                var account = userRepo.save(converter.convertToPOCOModel(userDTO));
                uow.saveChanges();
                userDTO.Id = account.Id;
                return userDTO;
            }
        }

        public UserDTO removeAccount(int idUser)
        {
            using (var uow = new UnitOfWork())
            {
                var repo = uow.getRepository<User>();
                var user = repo.get(idUser);
                if (user == null)
                    return null;
                repo.remove(idUser);
                uow.saveChanges();
                return converter.convertToDTOModel(user);
            }
        }

        public UserDTO logIn(string username, string password)
        {
            using (var uow = new UnitOfWork())
            {
                var user = uow.getRepository<User>().getAll().FirstOrDefault(x=>x.Username == username && _ecrypt.verifiyHash(password,x.Password));
                return user==null ? null : converter.convertToDTOModel(user);
            }
        }

        public UserDTO updateAccount(UserDTO userDTO)
        {
            using (var uow = new UnitOfWork())
            {
                var repo = uow.getRepository<User>();
                var user = repo.get(userDTO.Id);
                if (user == null)
                    return null;
                userDTO.Password = _ecrypt.generateHash(userDTO.Password);
                repo.update(userDTO.Id,converter.convertToPOCOModel(userDTO));
                uow.saveChanges();
                return userDTO;
            }
        }

        public IEnumerable<UserDTO> findAll()
        {
            using (var uow = new UnitOfWork())
            {
                return converter.convertToDTOModel(uow.getRepository<User>().getAll());
            }
        }
    }
}
