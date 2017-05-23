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
    public  class ReviewTest
    {

        [TestMethod]
        public void TestReviw()
        {
            Review review = new Review
            {
                Id=1,
                Mark=Mark.Reject,
                Recommendation="see again",
                ProposalId=123,
                ReviewerId=111,


            };

            int expectedId = 1;
            Mark expectedMark = Mark.Reject;
            String expectedRecommendation = "see again";
            int expectedProposalId = 123;
            int expectedReviewerId = 111;

            int actualId = review.Id;
            Mark actualMark = review.Mark;
            String actualRecommendation = review.Recommendation;
            int actualProposalId = review.ProposalId;
            int actualReviewrId = review.ReviewerId;

            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedMark, actualMark);
            Assert.AreEqual(expectedRecommendation, actualRecommendation);
            Assert.AreEqual(actualProposalId, expectedProposalId);
            Assert.AreEqual(expectedReviewerId, actualReviewrId);





        }
    }
}
