using MovieRating.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating
{
    public interface IRatingAcces
    {
        List<Reviews> GetAll();
    }
}
