using System.Collections.Generic;
using ImbdApi.Models.DB;
using ImbdApi.Models.RequestModel;
using ImbdApi.Models.ResponseModel;

namespace ImbdApi.Repository.Interfaces
{
    public interface IReviewRepository
    {
        int Create(ReviewRequest review,int movieId);
        void Delete(int id);
        IEnumerable<Review> GetReviewsByMovieId(int movieId);
        Review Get(int id);
        void Update(ReviewRequest review,int id);
    }
}