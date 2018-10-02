using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.ViewModels
{
    public class FolloweeViewModel
    {
        public string Heading { get; set; }
        public IEnumerable<Following> ArtistFollow { get; set; }
    }
}