using System;

namespace Testing
{
    internal class RatingService
    {
        private IMovieRatingRepository @object;

        public RatingService(IMovieRatingRepository @object)
        {
            this.@object = @object;
        }

        internal int GetNumberOfReviewsFromReviewer(int v)
        {
            throw new NotImplementedException();
        }
    }
}