using System;
using System.Collections.Generic;
using MovieRating.Core.DomainService;
using MovieRating.Core.Entity;

namespace MovieRating.Infrastructure.Data.Repositories
{
    public class MovieRatingRepository : IMovieRatingRepository
    {
        public MovieRatingRepository()
        {

        }

        public double AverageRatingByReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public double AverageRatingOnMovie(int movie)
        {
            throw new NotImplementedException();
        }

        public int GetCountOfGradesByReviewer(int reviewer, int grade)
        {
            throw new NotImplementedException();
        }

        public int GetCountOfMovieByGrade(int movie, int grade)
        {
            throw new NotImplementedException();
        }

        public int GetCountOfMovieReviews(int movie)
        {
            throw new NotImplementedException();
        }

        public List<Rating> GetMoviesByReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public List<Rating> GetReviewersByMovie(int movie)
        {
            throw new NotImplementedException();
        }

        public int GetReviewsByReviewer(int reviewerId)
        {
            throw new NotImplementedException();
        }

        public List<int> GetTopGradedMovies()
        {
            throw new NotImplementedException();
        }

        public List<Rating> GetTopMovies(int number)
        {
            throw new NotImplementedException();
        }


        public List<int> GetTopReviewers()
        {
            throw new NotImplementedException();
        }
    }
}
