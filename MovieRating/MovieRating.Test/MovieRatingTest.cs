using System;
using System.Collections.Generic;
using System.Text;
using MovieRating.Core.ApplicationService;
using MovieRating.Core.ApplicationService.Services;
using MovieRating.Core.Entity;
using Xunit;

namespace MovieRating.Test
{
    public class MovieRatingServicesTest
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        public void GetReviewsFromReviewerWithCorrectValues(int reviewerId, int count)
        {
            FakeMovieRatingRepo fakeRepo = new FakeMovieRatingRepo();
            fakeRepo.AddRating(new Rating() { ReviewerId = 2, MovieId = 1, Grade = 5, Date = DateTime.Now });
            fakeRepo.AddRating(new Rating() { ReviewerId = 3, MovieId = 2, Grade = 5, Date = DateTime.Now });
            fakeRepo.AddRating(new Rating() { ReviewerId = 3, MovieId = 2, Grade = 5, Date = DateTime.Now });
            IMovieRatingService service = new MovieRatingService(fakeRepo);

            int actual = service.GetReviewsByReviewer(reviewerId);

            Assert.Equal(count, actual);
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(3, 2.5)]

        public void GetAverageRateFromReviewerWithCorrectValues(int reviewerId, double average)
        {
            FakeMovieRatingRepository fakeRepo = new FakeMovieRatingRepository();
            fakeRepo.AddRating(new Rating() { ReviewerId = 2, MovieId = 1, Grade = 1, Date = DateTime.Now });
            fakeRepo.AddRating(new Rating() { ReviewerId = 3, MovieId = 1, Grade = 4, Date = DateTime.Now });
            fakeRepo.AddRating(new Rating() { ReviewerId = 3, MovieId = 2, Grade = 1, Date = DateTime.Now });
            IMovieRatingService service = new MovieRatingService(fakeRepo);

            double actual = service.AverageRatingByReviewer(reviewerId);

            Assert.Equal(average, actual);
        }
    }
}
