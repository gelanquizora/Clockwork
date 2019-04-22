using System;

namespace Clockwork.API.Models
{
    public class ServerDateTimeRequestDto
    {
        public string IpAddress { get; set; }

        public DateTimeOffset ServerDateTime { get; set; }
    }
} 