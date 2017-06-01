using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTests
{
    [TestClass]
    public class ConferenceModelTests
    {
        [TestMethod]

        public void TestConference()
        {
            //arrange
            ConferenceDTO conference1 = new ConferenceDTO
            {
                Id = 11,
                Name = "Conferinta1",
                StartDate = new DateTime(2015, 05, 15),
                EndDate = new DateTime(2015, 05, 16),
                Domain = "domeniu",
                MainDescription="descriere",
                Edition=5,
                Price=25,
                AbstractDeadline=new DateTime(2015,05,5),
                FullPaperDeadline=new DateTime(2015,05,6),
                
            };

            var expectedId = 11;
            var expectedName = "Conferinta1";
            var expectedDomain = "domeniu";
            var expectedMainDescription = "descriere";
            var expectedEdition = 5;
            var expectedPrice = 25;

            int actualId = 11;
            string actualName = "Conferinta1";
            string actualDomain = "domeniu";
            string actualMainDescription = "descriere";
            int actualEdition = 5;
            int actualPrice = 25;

            //assert
            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedDomain, actualDomain);
            Assert.AreEqual(expectedMainDescription, actualMainDescription);
            Assert.AreEqual(expectedEdition, actualEdition);
            Assert.AreEqual(expectedPrice, actualPrice);

        }
    }
}
