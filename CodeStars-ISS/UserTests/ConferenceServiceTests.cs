using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
//using Model;
using Model.DTOModels;
//using Model.Domain;

using Server.ServicesImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTests
{
    [TestClass]
    public class ConferenceServiceTests
    {
        [TestInitialize]
        public void Initialize()
        {
            EffortProviderFactory.ResetDb();
        }
        //---------------------------------------------------------------------------------------
       // private void PrepareData()
       // {
         //   using (var model = new DatabaseContext())
          //  {
            //    model.Conferences.Add(new ConferenceDTO {Id=1,Name = "nume1", Edition = 11, StartDate = "12.05.2015", EndDate = "14.05.2015", Domain = "domeniu1", AbstractDeadline = "10.05.2015", FullPaperDeadline = "09.05.2015", MainDescription = "descriere1", Price = 111, State = "state1" });
               


              //  model.SaveChanges();
           // }
       // }
   
        //-------------------------------------------------------------------------------------------------
        //pica
       // [TestMethod]
        // public void TestConferenceServiceAddConf()
         //{
           //ConferenceDTO conferenceToAdd = new ConferenceDTO
          //{
           // Id = 1,
          // Name = "Nume",
          // Edition = 11,
          // StartDate = "12.05.2015",
        // EndDate = "13.05.2015",
       // Domain = "Domeniu",
         //AbstractDeadline = "10.05.2015",
         //FullPaperDeadline = "11.05.2015",
         //MainDescription = "Descriere",
        //Price = 25,
        // State = "Accepted"
        //};

       //  var _confService = new ServerService();
        //  Assert.AreEqual(0, _confService.findAll().ToList().Count);
       //  var confSaved = _confService.AddConference(1,conferenceToAdd);
          //  Assert.AreEqual(1, _confService.findAll().ToList().Count);
    //    }



        //-------------------------------------------------------------------------------------------------------------
        //test gettAllConferences
        //pica
       //  [TestMethod]
       // public void TestConferenceServiceGetAll()
      //  {
         //   var confService = new ServerService();
         //   Assert.AreEqual(0, confService.GetAllConferences().ToList().Count);
         //   PrepareData();
         //   Assert.AreEqual(4, confService.GetAllConferences().ToList().Count);

      //  }

        //---------------------------------------------------------------------------------------------------------
    } 
}
