using Clockwork.API.Entities; 
using System.Collections.Generic; 

namespace Clockwork.API.Services
{
    public interface IClockworkRepository
    {
        IEnumerable<ServerDateTimeRequest> GetServerDateTimeRequests();
        ServerDateTimeRequest AddServerDateTimeRequest(ServerDateTimeRequest serverDateTimeRequest);
        int Save();
    }
} 
