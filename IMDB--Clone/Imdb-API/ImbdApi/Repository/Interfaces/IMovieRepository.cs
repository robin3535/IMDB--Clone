using System.Collections.Generic;
using ImbdApi.Models.DB;
using ImbdApi.Models.RequestModel;
using ImbdApi.Models.ResponseModel;

namespace ImbdApi.Repository.Interfaces
{
    public interface IMovieRepository
    {
        int Create(MovieRequest movie);
        void Delete(int id);
        Movie Get(int id);
        IEnumerable<Movie> Get();
        void Update(MovieRequest movie, int id);
    }
}