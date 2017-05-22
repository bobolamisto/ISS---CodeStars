using Model.DTOModels;

namespace services.Services
{
    public interface IAdminUserChekerService
    {
        UserDTO AcceptNewUser(UserDTO userDto);

        UserDTO RejectNewUser(UserDTO userDto);
    }
}
