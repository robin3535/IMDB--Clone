using System.Collections.Generic;
using ImbdApi.Models.DB;
using ImbdApi.Models.RequestModel;
using ImbdApi.Models.ResponseModel;
using Microsoft.AspNetCore.JsonPatch;

namespace ImbdApi.Repository.Interfaces
{
    public interface IActorRepository
    {
        int Create(ActorRequest actor);
        void Delete(int id);
       IEnumerable<Actor> Get();
        Actor Get(int id);
        IEnumerable<Actor> GetActorByMovieId(int movieId);
        void Update(ActorRequest actor,int id);
        void UpdatePatch(JsonPatchDocument actorPatch,int id);  
    }
}