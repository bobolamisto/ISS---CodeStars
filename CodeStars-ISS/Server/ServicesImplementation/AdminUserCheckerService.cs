using Model.Domain;
using Model.DTOModels;
using Persistence.Repository;
using services.Services;

namespace Server.ServicesImplementation
{
    public class AdminUserCheckerService : IAdminUserChekerService
    {
        public UserDTO AcceptNewUser(UserDTO userDto)
        {
            using (var uow = new UnitOfWork())
            {
                if (!userDto.Validation.Equals("Waiting"))
                    return null;
                var userRepo = uow.getRepository<User>();
                var user = userRepo.get(userDto.Id);
                user.Validation = AccountState.Validated;
                uow.saveChanges();
                userDto.Validation = "Validated";
                return userDto;
            }
        }

        public UserDTO RejectNewUser(UserDTO userDto)
        {
            using (var uow = new UnitOfWork())
            {
                if (!userDto.Validation.Equals("Waiting"))
                    return null;
                var userRepo = uow.getRepository<User>();
                var user = userRepo.get(userDto.Id);
                user.Validation = AccountState.Unvalidated;
                uow.saveChanges();
                userDto.Validation = "Unvalidated";
                return userDto;
            }
        }
    }
}
