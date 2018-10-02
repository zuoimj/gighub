using System.Linq;
using GigHub.Core.Models;

namespace GigHub.Core.Reposistories
{
    public interface IFollowingRepository
    {
        bool UserFollowingThisArtist(Gig gig, string userId);
        IQueryable<Following> GetListArtistsFollowings(string userId);
    }
}