using GigHub.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace GigHub.Core.Reposistories
{
    public interface IGigRepository
    {
        IQueryable<Gig> UpcomingGigs();
        bool AttendanceGoingThisGig(int gigId, string userId);
        Gig GetDetailsGigById(int gigId);
        IEnumerable<Gig> GetMyListGigs(string userId);
        Gig GetGigWithAttendees(int gigId);
        Gig GetGigByIdSingle(int id, string userId);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        void Add(Gig gig);
    }
}