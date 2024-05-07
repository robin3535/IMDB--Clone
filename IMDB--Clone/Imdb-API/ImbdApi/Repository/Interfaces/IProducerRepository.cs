using System.Collections.Generic;
using ImbdApi.Models.DB;
using ImbdApi.Models.RequestModel;
using ImbdApi.Models.ResponseModel;

namespace ImbdApi.Repository.Interfaces
{
    public interface IProducerRepository
    {
        int Create(ProducerRequest producer);
        void Delete(int id);
        IEnumerable<Producer> Get();
        Producer Get(int id);
        void Update(ProducerRequest producer,int id);
    }
}