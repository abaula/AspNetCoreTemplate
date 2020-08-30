using System;

namespace AspNetCoreTemplate.Model.v1_0
{
    public class Address
    {
        public Guid Id { get;set; }
        public City City { get; set; }
        public string PostCode { get; set; }
        public string FullAddress { get; set; }
        public string AddressNote { get; set; }
    }
}