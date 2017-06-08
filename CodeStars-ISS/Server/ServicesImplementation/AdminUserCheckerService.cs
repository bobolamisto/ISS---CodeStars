using Model.Domain;
using Model.DTOModels;
using Persistence.Repository;
using server.ServicesImplementation;
using services.Services;

namespace Server.ServicesImplementation
{
    public class AdminUserCheckerService : IAdminUserChekerService
    {
        private IUserService userService;
        public AdminUserCheckerService()
        {
            userService = new UserService();
        }
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
                userDto.Validation = AccountState.Unvalidated.ToString();
                userService.updateAccount(userDto);
                uow.saveChanges();
                return userDto;
            }
        }
    }
}
