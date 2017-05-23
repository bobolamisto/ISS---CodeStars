
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Domain;

namespace UserTests
{
    [TestClass]
    public class ProposalModelTest
    {
        [TestMethod]

        public void TestProposal()
        {
            //arrange
            Proposal proposal1 = new Proposal
            {
                Id = 1,
                Title = "titlu",
                Subject="subiect",
                Abstract="abstract",
                FullPaper="full",
                Keywords="key",
                ParticipationId=2
            };

            var expectedId = 1;
            var expectedTitle = "titlu";
            var expectedSubject = "subiect";
            var expectedAbstract = "abstract";
            var expectedFullPaper = "full";
            var expectedKeywords = "key";
            var expectedParticipationId = 2;

            int actualId = proposal1.Id;
            string actualTitle = proposal1.Title;
            string actualSubject = proposal1.Subject;
            string actualAbstract = proposal1.Abstract;
            string actualFullPaper = proposal1.FullPaper;
            string actualKeywords = proposal1.Keywords;
            int actualParticipationId = proposal1.ParticipationId;

            //assert
            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedTitle, actualTitle);
            Assert.AreEqual(expectedSubject, actualSubject);
            Assert.AreEqual(expectedAbstract, actualAbstract);
            Assert.AreEqual(expectedFullPaper, actualFullPaper);
            Assert.AreEqual(expectedKeywords, actualKeywords);
            Assert.AreEqual(expectedParticipationId, actualParticipationId);
        }
    }
}
