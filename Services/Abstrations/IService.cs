using System;
using System.Threading.Tasks;
using AspNetCoreTemplate.Model.v1_0;

namespace AspNetCoreTemplate.Services.Abstrations
{
    public interface IService
    {
        Task<Address> Get(Guid id);
         Task<DataFrame<Address>> Find(SearchRequest request);
         Task Add(Address address);
         Task Delete(Guid id);
    }
}