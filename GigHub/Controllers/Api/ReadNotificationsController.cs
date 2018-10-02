using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;
using GigHub.Core.Models;
using GigHub.Persistence;

namespace GigHub.Controllers.Api
{
    [Authorize]
    public class ReadNotificationsController : ApiController
    {
        private ApplicationDbContext _context;
        public ReadNotificationsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult ReadNoti()
        {
            var userId = User.Identity.GetUserId();
            var userNotification = _context.UserNotifications
                .Where(un => un.UserId == userId && !un.IsRead)
                .ToList();

            userNotification.ForEach(n => n.Read());

            _context.SaveChanges();

            return Ok();
        }

    }
}
