
using ImbdApi.Models.DB;
using ImbdApi.Models.RequestModel;
using ImbdApi.Models.ResponseModel;
using System.Collections.Generic;

namespace ImbdApi.Services.Interfaces
{
    public interface IGenreService
    {
        IEnumerable<GenreResponse> Get();
        GenreResponse Get(int id);
        int Create(GenreRequest genre);
        IEnumerable<Genre> GetGenreByMovieId(int movieId);
        void Update(GenreRequest genre,int id);
        void Delete(int id);
    }
}
