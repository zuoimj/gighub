using System.Data.Entity;
using System.Linq;
using GigHub.Core.Models;
using GigHub.Core.Reposistories;

namespace GigHub.Persistence.Repositories
{
    public class FollowingRepository : IFollowingRepository
    {
        private readonly ApplicationDbContext _context;

        public FollowingRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool UserFollowingThisArtist(Gig gig, string userId)
        {
            return _context.Followings
                .Any(a => a.FolloweeId == gig.ArtistId
                          && a.FollowerId == userId);
        }
        public IQueryable<Following> GetListArtistsFollowings(string userId)
        {
            return _context.Followings
                .Where(f => f.FollowerId == userId)
                .Include(f => f.Followee);
        }
    }
}