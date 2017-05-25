using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using server.ServicesImplementation;
using services.Services;
using Server.ServicesImplementation;

namespace Server
{
    static class ServerServiceBuilder
    {
        public static ServerService MakeServerService()
        {
            var serverService = new ServerService();
            serverService.SetUserService(new UserService());
            serverService.SetUserConferenceService(new UserConferenceService());
            serverService.SetAdminConferencesService(new AdminConferenceService());
            serverService.SetAdminUserCheckerService(new AdminUserCheckerService());
            serverService.SetTicketService(new TicketService());
            serverService.SetEmailService(new EmailService());
            serverService.SetPaperService(new ProposalService());
            return serverService;
        }
    }
}
