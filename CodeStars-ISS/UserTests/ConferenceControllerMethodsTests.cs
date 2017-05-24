using services.Services;
using Moq;
using CodeStars_Iss.Controller;
using Server.ServicesImplementation;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserTests
{
    [TestClass]
    public class ConferenceControllerMethodsTests
    {
        //[TestMethod]
        //public void TestConferenceControllerAdd()
        //{
          //  var serverService = new Mock<IServerService>();
            //serverService
              //   .Setup(s => s.AddConference(It.IsAny<int>(), It.IsAny<Model.DTOModels.ConferenceDTO>()))
               //  .Returns(new Model.DTOModels.ConferenceDTO
                // {
                  //   Id = 1,
                    // Name = "Nume",
                    // Edition = 11,
                    // StartDate = "12.05.2015",
                    // EndDate = "13.05.2015",
                    // Domain = "Domeniu",
                    // AbstractDeadline = "10.05.2015",
                    // FullPaperDeadline = "11.05.2015",
                    // MainDescription = "Descriere",
                    // Price = 25,
                    // State = "Accepted"
                 //});
            //var clientController = new ClientController(serverService.Object);

           // var count = clientController.getAllConferences().ToList().Count;
            //clientController.addConference(1,2,"Nume", new System.DateTime(2015,05,12), new System.DateTime(2015,05,13),"domeniu",new  System.DateTime(2015,05,10), new System.DateTime(2015,05,11));
            //Assert.AreEqual(count + 1, clientController.getAllConferences().ToList().Count);

            //}
    
   }
}

