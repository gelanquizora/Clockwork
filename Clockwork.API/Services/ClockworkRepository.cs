using System.Collections.Generic;
using System.Linq;
using Clockwork.API.Entities;

namespace Clockwork.API.Services
{
    public class ClockworkRepository : IClockworkRepository
    {
        private ClockworkContext _context;

        public ClockworkRepository(ClockworkContext context)
        {
            _context = context;
        }

        public ServerDateTimeRequest AddServerDateTimeRequest(ServerDateTimeRequest serverDateTimeRequest)
        {
            _context.ServerDateTimeRequest.Add(serverDateTimeRequest);

            return serverDateTimeRequest;
        }

        public IEnumerable<ServerDateTimeRequest> GetServerDateTimeRequests()
        {
            return _context.ServerDateTimeRequest.OrderBy(s => s.CreatedDateTime);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
