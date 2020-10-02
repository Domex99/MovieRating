
using System;
using System.Collections.Generic;

using MovieRating.Core.Entity;

namespace MovieRating.Infrastructure.Data.Repositories
{
    public class FakeMovieRatingRepository
    {

        private static List<Rating> _ratings = new List<Rating>();

        public FakeMovieRatingRepository()
        {

        }
        static FakeMovieRatingRepository()
        {
            InitRating();

        }


        private static void InitRating()
        {
            Rating rating1 = new Rating() { ReviewerId = 1, MovieId = 2, Grade = 5, Date = DateTime.Now };
            Rating rating2 = new Rating() { ReviewerId = 2, MovieId = 1, Grade = 5, Date = DateTime.Now };
            Rating rating3 = new Rating() { ReviewerId = 3, MovieId = 2, Grade = 5, Date = DateTime.Now };
            _ratings.Add(rating1);
            _ratings.Add(rating2);
            _ratings.Add(rating3);
        }


        public static List<Rating> ReadAllRatings()
        {
            return _ratings;
        }





        /*  public static Rating AddRating(int reviewerId, int movieId,int grade,DateTime Date) {
              Rating ratingToAdd = new Rating() { ReviewerId = reviewerId,MovieId = movieId ,Grade= grade ,Date = Date };
              _ratings.Add(ratingToAdd);
              return ratingToAdd;
          }*/
    }
}
