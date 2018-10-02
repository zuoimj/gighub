using GigHub.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace GigHub.Persistence.EntityConfigurations
{
    public class AttendancesConfiguration : EntityTypeConfiguration<Attendance>
    {
        public AttendancesConfiguration()
        {
            HasKey(a => new { a.GigId, a.AttendeeId });
        }
    }
}