using System.Collections.Generic;
using ImbdApi.Models.DB;
using ImbdApi.Models.RequestModel;
using ImbdApi.Models.ResponseModel;

namespace ImbdApi.Repository.Interfaces
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> Get();
        Genre Get(int id);
        IEnumerable<Genre> GetGenreByMovieId(int movieId);
        int Create(GenreRequest genre);
        void Delete(int id);
        void Update(GenreRequest genre,int id);
    }
}