using System;
using System.Threading.Tasks;
using AspNetCoreTemplate.Model.v1_0;
using AspNetCoreTemplate.Services.Abstrations;
using AspNetCoreTemplate.WebApi.Const;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreTemplate.WebApi.Controllers.v1_0
{
    [ApiController]
    [ApiVersion(ApiVersionConst.V1_0)]
    [Route("v{version:apiVersion}/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly ILogger<AddressController> _logger;
        private readonly IService _service;

        public AddressController(ILogger<AddressController> logger,
            IService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<Address> Get([FromRoute] Guid id)
        {
            _logger.LogTrace(nameof(AddressController.Get));
            return _service.Get(id);
        }

        [HttpGet]
        [Route("find")]
        public Task<DataFrame<Address>> Find([FromQuery] SearchRequest request)
        {
            _logger.LogTrace(nameof(AddressController.Find));
            return _service.Find(request);
        }

        [HttpPost]
        [Route("add")]
        public async Task<CreatedAtActionResult> Add([FromBody] Address address)
        {
            _logger.LogTrace(nameof(AddressController.Add));
            await _service.Add(address);
            
            return CreatedAtAction(nameof(Get), new
            {
                id = address.Id,
                version = ApiVersionConst.V1_0
            },
            null);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<NoContentResult> Delete([FromRoute] Guid id)
        {
            _logger.LogTrace(nameof(AddressController.Delete));
            await _service.Delete(id);

            return NoContent();
        }
    }
}