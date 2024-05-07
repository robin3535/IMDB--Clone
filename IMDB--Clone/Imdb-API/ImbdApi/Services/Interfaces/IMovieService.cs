using ImbdApi.Models.DB;
using ImbdApi.Models.RequestModel;
using ImbdApi.Models.ResponseModel;
using System.Collections.Generic;

namespace ImbdApi.Services.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<MovieResponse> Get();
        MovieResponse Get(int id);
        int Create(MovieRequest movie);
        void Update(MovieRequest movie,int id);
        void Delete(int id);
    }
}
