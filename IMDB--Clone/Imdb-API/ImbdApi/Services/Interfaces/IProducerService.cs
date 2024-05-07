
using ImbdApi.Models.DB;
using ImbdApi.Models.RequestModel;
using ImbdApi.Models.ResponseModel;
using System.Collections.Generic;

namespace ImbdApi.Services.Interfaces
{
    public interface IProducerService
    {
        IEnumerable<ProducerResponse> Get();
        ProducerResponse Get(int id);
        int Create(ProducerRequest producer);
        void Update(ProducerRequest producer, int id);
        void Delete(int id);
    }
}
