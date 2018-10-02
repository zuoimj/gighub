using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.Reposistories
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetListGenres();
    }
}