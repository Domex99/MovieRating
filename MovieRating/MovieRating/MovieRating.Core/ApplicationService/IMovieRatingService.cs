using System;
using System.Collections.Generic;
using MovieRating.Core.Entity;

namespace MovieRating.Core.ApplicationService
{
    public interface IMovieRatingService
    {

        int GetReviewsByReviewer(int reviewerId);
        double AverageRatingByReviewer(int reviewer);
        int GetCountOfGradesByReviewer(int reviewer, int grade);
        int GetCountOfMovieReviews(int movie);
        double AverageRatingOnMovie(int movie);
        int GetCountOfMovieByGrade(int movie, int grade);
        List<int> GetTopGradedMovies();
        List<int> GetTopReviewers();
        List<Rating> GetTopMovies(int number);
        List<Rating> GetMoviesByReviewer(int reviewer);
        List<Rating> GetReviewersByMovie(int movie);
    }
}
