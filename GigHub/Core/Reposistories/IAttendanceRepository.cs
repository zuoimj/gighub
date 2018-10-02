using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.Reposistories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetFutureAttendances(string userId);
    }
}