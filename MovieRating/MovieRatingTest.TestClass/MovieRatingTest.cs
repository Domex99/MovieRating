using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovieRating.Core.ApplicationService.Services;
using MovieRating.Core.DomainService;
using MovieRating.MovieRating.Core.Entity;

namespace Testing
{
    [TestClass]
    public class UnitTest
    {
        [TestInitialize]
        public void setup()
        { }

        [TestMethod]
        public void TestGetAverageRateFromReviewer()
        {
            Mock<MovieRatingService> mt = new Mock<MovieRatingService>();

            Reviews[] returnValue =
              { new Reviews  {Reviewer = 1, Movie = 2, Grade = 3 },
                new Reviews {Reviewer = 1, Movie = 2, Grade = 4 },
                new Reviews {Reviewer = 1, Movie = 3, Grade = 2 },
                new Reviews {Reviewer = 3, Movie = 3, Grade = 2 }
            };

            mt.Setup(mt => mt.GetAllReviews()).Returns(() => value);

            RatingService reviewService = new RatingService(mt.Object);

            double actualResult = reviewService.GetAverageRate(1);

            mt.Verify(mt => mt.GetAllRatings(), Times.Once);

            Assert.IsTrue(actualResult.Count == 1);
            Assert.IsTrue(actualResult.Contains(returnValue[1]));
        }


    }

    [TestMethod]
    public void TestGetNumberOfReviewsFromReviewer()
    {
        Mock<IMovieRatingRepository> mt = new Mock<IMovieRatingRepository>();


        Reviews[] returnValue =
            { new Review  {Reviewer = 1, Movie = 2, Grade = 3 },
                new Review {Reviewer = 2, Movie = 2, Grade = 4 } };

        mt.Setup(mt => mt.GetAllReviews()).Returns(() => value);

        RatingService ratingService = new RatingService(mt.Object);

        int actualResult = ratingService.GetNumberOfReviewsFromReviewer(2);

        mt.Verify(mt => mt.GetAllReviews(), Times.Once);

        Assert.IsTrue(actualResult.Count == 1);
        Assert.IsTrue(actualResult.Contains(returnValue[1]));

    }




    [TestMethod]
    public void TestGetNumberOfRatesByReviewer()
    {
        Mock<IMovieRatingRepository> mt = new Mock<IMovieRatingRepository>();


        Reviews[] returnValue =
            { new Review  {Reviewer = 1, Rate = 2 },
                new Review {Reviewer = 2, Rate = 2} };

        mt.Setup(mt => mt.GetAllReviews()).Returns(() => value);

        RatingService ratingService = new RatingService(mt.Object);

        int actualResult = ratingService.GetNumberOfRatesByReviewer(2);

        mt.Verify(mt => mt.GetAllReviews(), Times.Once);

        Assert.IsTrue(actualResult.Count == 1);
        Assert.IsTrue(actualResult.Contains(returnValue[1]));

    }



}