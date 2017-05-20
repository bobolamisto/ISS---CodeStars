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
    public class User_ConferenceConverterService : IModelConverterService<User_Conference, User_ConferenceDTO>
    {
        public User_ConferenceDTO convertToDTOModel(User_Conference model)
        {
            User_ConferenceDTO dto = new User_ConferenceDTO();
            dto.Id = model.Id;
            dto.Role = model.Role.ToString();
            dto.UserId = model.UserId;
            dto.ConferenceId = model.ConferenceId;
            return dto;
        }

        public User_Conference convertToPOCOModel(User_ConferenceDTO model)
        {
            User_Conference poco = new User_Conference();
            poco.Id = model.Id;
            poco.Role = (UserRole) Enum.Parse(typeof(UserRole),model.Role,true);
            poco.UserId = model.UserId;
            poco.ConferenceId = model.ConferenceId;
            return poco;
        }
    }
}
