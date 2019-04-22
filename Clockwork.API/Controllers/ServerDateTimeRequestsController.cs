using Clockwork.API.Entities;
using Clockwork.API.Models;
using Clockwork.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Clockwork.API.Controllers
{
    [Route("api/server-time-requests")]
    public class ServerDateTimeRequestsController : Controller
    {
        private IClockworkRepository _clockworkRepository;

        public ServerDateTimeRequestsController(IClockworkRepository clockworkRepository)
        {
            _clockworkRepository = clockworkRepository;
        }

        [HttpPost]
        public IActionResult CreateServerDateTimeRequest([FromBody] CreateServerDateTimeRequestDto dto)
        {
            TimeZoneInfo cetInfo = TimeZoneInfo.FindSystemTimeZoneById(dto.Timezone);

            var item = new ServerDateTimeRequest()
            {
                IpAddress = this.HttpContext.Connection.RemoteIpAddress.ToString(),
                ServerDateTime = TimeZoneInfo.ConvertTime(DateTimeOffset.Now, cetInfo),
                CreatedDateTime = DateTime.UtcNow
            };

            _clockworkRepository.AddServerDateTimeRequest(item);

            _clockworkRepository.Save();

            return Created("CreateServerDateTimeRequest", item);
        }

        [HttpGet]
        public IActionResult GetServerDateTimeRequests()
        {
            var items = _clockworkRepository.GetServerDateTimeRequests();

            return Ok(items);
        }
    }
}
