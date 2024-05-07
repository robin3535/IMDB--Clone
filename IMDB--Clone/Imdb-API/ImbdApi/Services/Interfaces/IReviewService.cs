using System.Collections.Generic;
using ImbdApi.Models.DB;
using ImbdApi.Models.RequestModel;
using ImbdApi.Models.ResponseModel;

namespace ImbdApi.Services.Interfaces
{
    public interface IReviewService
    {
        IEnumerable<ReviewResponse> GetReviewsByMovieId(int movieId);
        ReviewResponse Get(int id);
        int Create(ReviewRequest review,int movieId);
        void Update(ReviewRequest review,int id);
        void Delete(int id);
    }
}
