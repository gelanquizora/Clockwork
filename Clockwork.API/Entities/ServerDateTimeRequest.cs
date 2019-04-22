using System;
using System.ComponentModel.DataAnnotations;

namespace Clockwork.API.Entities
{
    public class ServerDateTimeRequest
    {
        [Key]
        public Guid Id { get; set; }

        public string IpAddress { get; set; }

        public DateTimeOffset ServerDateTime { get; set; }

        public DateTime CreatedDateTime { get; set; }
    }
}
