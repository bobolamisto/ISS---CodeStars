using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;
using services;

using Server;
using Server.ServicesImplementation;
using Model.POCOModels;
using Model.DTOModels;

namespace UserTests
{
    [TestClass]
    public class ReviewServiceTest
    {
        [TestInitialize]
        public void Initialize()
        {
            EffortProviderFactory.ResetDb();

        }

        public void PrepareData()
        {
            using (var model = new DatabaseContext())
            {
                model.Users.Add(new User { Id = 2, Username = "User11", FirstName = "First11", LastName = "Last11", Password = "password1", Email = "test1@gmail.com", WebPage = "test1.com", Admin = true, ConferenceParticipations = null });
                model.Users.Add(new User { Id = 10, Username = "User10", FirstName = "First10", LastName = "Last10", Password = "password1", Email = "test1@gmail.com", WebPage = "test1.com", Admin = true, ConferenceParticipations = null });

                model.Sections.Add(new Section { Id = 25, Title = "titlu", StartDate = new DateTime(2018, 10, 25), EndDate = new DateTime(2018, 10, 30),   ChairId = 10, ConferenceId = 55 });

                model.Proposals.Add(new Proposal { Id = 1, Title = "Title", Subject = "subject", Abstract = "abstract", FullPaper = "full paper", Keywords = "keyword1", Collaborators = "Colab1", ParticipationId = 25, SectionId = 25, ProposalState = ProposalState.Accepted });

                model.Conferences.Add(new Conference { Id = 55, Name = "name", StartDate = new DateTime(2018, 10, 25), EndDate = new DateTime(2018, 10, 30), Domain = "domain", MainDescription = "md", Edition = 1, Price = 25, AbstractDeadline = new DateTime(2018, 09, 20), FullPaperDeadline = new DateTime(2018, 09, 25), State = ConferenceState.Proposed });

                model.ConferenceParticipations.Add(new User_Conference { Id = 25, Role = UserRole.Listener, ConferenceId = 55, UserId = 2 });

                model.Reviews.Add(new Review { Id = 1, Mark = Model.Domain.Mark.Accept, Recommendation = "recommendation", ProposalId = 1, ReviewerId = 2 });
                model.Reviews.Add(new Review { Id = 2, Mark = Model.Domain.Mark.Accept, Recommendation = "recommendation2", ProposalId = 1, ReviewerId = 10 });


                model.SaveChanges();
                
            }
        }

        [TestMethod]
        public void getReviewTest()
        {
            PrepareData();
            var reviewService = new ReviewService();

            var review1 = reviewService.getReview(1);
            
            Assert.AreEqual("recommendation", review1.Recommendation);
            Assert.AreEqual(Mark.Accept.ToString(), review1.Mark.ToString());
            Assert.AreEqual(1, review1.ProposalId);

            var review2 = reviewService.getReview(2);

            Assert.AreEqual(1, review2.ProposalId);
            Assert.AreEqual("recommendation2", review2.Recommendation);
            Assert.AreEqual(Mark.Accept.ToString(), review2.Mark.ToString());

        }

        [TestMethod]
        public void GetAllReviewsTest()
        {
            
            var reviewService = new ReviewService();
            Assert.AreEqual(0, reviewService.getAll().ToList().Count());
            PrepareData();
            Assert.AreEqual(2, reviewService.getAll().ToList().Count());
        }

        [TestMethod] 
        public void FindAllForProposalTest()
        {
            var rs = new ReviewService();
            //int revNr = rs.getAllForProposal(1).ToList().Count();
            PrepareData();
            Assert.AreEqual(2, rs.getAllForProposal(1).ToList().Count());

        }

        [TestMethod]
        public void RemoveReviewTest()
        {
            var rs = new ReviewService();
            PrepareData();
            Assert.AreEqual(2, rs.getAll().ToList().Count());
            rs.removeReview(2);
            Assert.AreEqual(1, rs.getAll().ToList().Count());
            rs.removeReview(1);
            Assert.AreEqual(0, rs.getAll().ToList().Count());
        }

        [TestMethod]
        public void AddReviewTest()
        {
            var rs = new ReviewService();
            PrepareData();
            ReviewDTO revdto = new ReviewDTO
            {
                Id = 256,
                Mark="Accept",
                Recommendation="recomm",
                ProposalId=1,
                ReviewerId=1

            };
            ReviewDTO revDtoNew = new ReviewDTO
            {
                Id = 256,
                Mark = "Accept",
                Recommendation = "recommendations",
                ProposalId = 1,
                ReviewerId = 1
            };

            Assert.AreEqual(2, rs.getAll().ToList().Count());
            rs.addReview(revdto);
            Assert.AreEqual(3, rs.getAll().ToList().Count());
           
        }

        [TestMethod]
        public void UpdateReviewTest()
        {

            var rs = new ReviewService();
            PrepareData();
            var review = rs.getReview(1);
            Assert.AreEqual("recommendation", review.Recommendation);
            review.Recommendation = "rec";
            rs.updateReview(review);
            Assert.AreEqual("rec", review.Recommendation);


        }
    }
}
