using System;
using System.Threading.Tasks;
using AspNetCoreTemplate.Model.v1_0;
using AspNetCoreTemplate.Services.Abstrations;

namespace AspNetCoreTemplate.Services
{
    class Service : IService
    {
        public Task Add(Address address)
        {
            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            return Task.CompletedTask;
        }

        public Task<DataFrame<Address>> Find(SearchRequest request)
        {
            return Task.FromResult(new DataFrame<Address>
            {
                Items = Array.Empty<Address>(),
                HasNext = false
            });
        }

        public Task<Address> Get(Guid id)
        {
            return Task.FromResult(new Address
            {
                Id = id,
                City = new City(),
                PostCode = "",
                FullAddress = "",
                AddressNote = ""
            });
        }
    }
}