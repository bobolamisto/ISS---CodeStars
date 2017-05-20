using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOModels
{
    [Serializable]
    public class User_ConferenceDTO
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public int ConferenceId { get; set; }
        public int UserId { get; set; }

        public User_ConferenceDTO() {}
    }
}
