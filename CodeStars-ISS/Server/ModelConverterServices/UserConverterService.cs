using Model.Domain;
using Model.DTOModels;
using services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelConverterServices
{
    public class UserConverterService : IModelConverterService<User, UserDTO>
    {
        public UserDTO convertToDTOModel(User model)
        {
            UserDTO dto = new UserDTO();
            dto.Id = model.Id;
            dto.Username = model.Username;
            dto.Password = model.Password;
            dto.FirstName = model.FirstName;
            dto.LastName = model.LastName;
            dto.Email = model.Email;
            dto.WebPage = model.WebPage;
            dto.Admin = model.Admin;
            dto.Validation = model.Validation.ToString();
            return dto;
        }

        public User convertToPOCOModel(UserDTO model)
        {
            User poco = new User();
            poco.Id = model.Id;
            poco.Username = model.Username;
            poco.Password = model.Password;
            poco.FirstName = model.FirstName;
            poco.LastName = model.LastName;
            poco.Email = model.Email;
            poco.WebPage = model.WebPage;
            poco.Admin = model.Admin;
            poco.Validation = (AccountState)Enum.Parse(typeof(AccountState), model.Validation, true);
            return poco;
        }

        public IEnumerable<UserDTO> convertToDTOList(IEnumerable<User> users)
        {
            return users.Select(convertToDTOModel).ToList();
        }
    }
}
