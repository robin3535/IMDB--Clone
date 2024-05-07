using AutoMapper;
using ImbdApi.Models.DB;
using ImbdApi.Models.RequestModel;
using ImbdApi.Models.ResponseModel;

namespace ImbdApi.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Actor, ActorResponse>().ReverseMap();
            CreateMap<Actor, ActorRequest>().ReverseMap();
            CreateMap<Genre, GenreResponse>().ReverseMap();
            CreateMap<Producer, ProducerResponse>().ReverseMap();
            CreateMap<Review, ReviewResponse>().ReverseMap();
        }
    }
}
