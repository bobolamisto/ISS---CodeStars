using services.Services;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStars_Iss.Controller
{
    public class UserConferenceController
    {
        private IUserConferenceService service;

        public UserConferenceController(IUserConferenceService service)
        {
            this.service = service;
        }

        public void AddConference(int uId, int cId, string cName, DateTime cStartDate, DateTime cEndDate, string Cdomain, DateTime CabstractDeadline, DateTime cFullPaperDeadline)
        {
            Conference c = new Conference { Id = cId, Name = cName, StartDate = cStartDate, EndDate = cEndDate, Domain = Cdomain, AbstractDeadline = CabstractDeadline, FullPaperDeadline = cFullPaperDeadline };
            service.AddConference(uId, c);
        }

        public IEnumerable<Conference> GetRelevantConferences(int uId, string userRole)
        {
            UserRole role = (UserRole)Enum.Parse(typeof(UserRole), userRole);
            return service.GetRelevantConferences(uId, role);
        }

        public IEnumerable<Conference> GetRelevantConferences(int uId)
        {
            return service.GetRelevantConferences(uId);
        }

        public IEnumerable<Conference> GetAllConferences()
        {
            return service.GetAllConferences();
        }

        public void ModifyDescription(int uId, int cId, string cName, DateTime cStartDate, DateTime cEndDate, string Cdomain, DateTime CabstractDeadline, DateTime cFullPaperDeadline)
        {
            Conference c = new Conference { Id = cId, Name = cName, StartDate = cStartDate, EndDate = cEndDate, Domain = Cdomain, AbstractDeadline = CabstractDeadline, FullPaperDeadline = cFullPaperDeadline };
            service.ModifyDescription(uId, c);
        }
    }
}

