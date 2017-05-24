using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Domain;
using Model.DTOModels;
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

        private void PrepareData()
        {
            using (var model = new DatabaseContext())
            {
                model.Conferences.Add(new Conference { Id = 1, Name = "nume1", StartDate = new DateTime(2015, 10, 05), EndDate = new DateTime(2015, 10, 07), Domain = "domeniu1", MainDescription = "descriere1", Edition = 11, Price = 21, AbstractDeadline = new DateTime(2015, 10, 02), FullPaperDeadline = new DateTime(2015, 10, 03) });
                model.Conferences.Add(new Conference { Id = 2, Name = "nume2", StartDate = new DateTime(2017, 01, 24), EndDate = new DateTime(2017, 01, 25), Domain = "domeniu2", MainDescription = "descriere2", Edition = 12, Price = 22, AbstractDeadline = new DateTime(2017, 01, 19), FullPaperDeadline = new DateTime(2017, 01, 20) });


                model.SaveChanges();
            }
        }

        [TestMethod]
       // public void TestConferenceServiceAddConf()
       // {
         //   ConferenceDTO conferenceToAdd = new ConferenceDTO
          //  {
            //    Id = 1,
             //   Name = "Nume",
              //  Edition = 11,
               // StartDate = "12.05.2015",
               // EndDate = "13.05.2015",
                //Domain = "Domeniu",
               // AbstractDeadline = "10.05.2015",
               // FullPaperDeadline = "11.05.2015",
               // MainDescription = "Descriere",
                //Price = 25,
               // State = "Accepted"
            //};

           // var _confService = new ServerService();
          //  Assert.AreEqual(0, _confService.findAll().ToList().Count);
           // var confSaved = _confService.createAccount(confToAdd);
        //    Assert.AreEqual(1, _confService.findAll().ToList().Count);
        //}
    }
}
