using System.Collections.Generic;
using System.Linq;
using GigHub.Core.Models;
using GigHub.Core.Reposistories;

namespace GigHub.Persistence.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Genre> GetListGenres()
        {
            return _context.Genres.ToList();
        }
    }
}