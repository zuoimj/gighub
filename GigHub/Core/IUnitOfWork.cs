using GigHub.Core.Reposistories;

namespace GigHub.Core
{
    public interface IUnitOfWork
    {
        IGigRepository Gigs { get; }
        IGenreRepository Genres { get; }
        IAttendanceRepository Attendances { get; }
        IFollowingRepository Followings { get; }
        void Complete();
    }
}