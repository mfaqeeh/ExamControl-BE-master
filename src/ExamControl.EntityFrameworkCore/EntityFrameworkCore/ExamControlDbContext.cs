using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ExamControl.Authorization.Roles;
using ExamControl.Authorization.Users;
using ExamControl.MultiTenancy;
using ExamControl.Models;

namespace ExamControl.EntityFrameworkCore
{
    public class ExamControlDbContext : AbpZeroDbContext<Tenant, Role, User, ExamControlDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<ObserveSetting> ObserveSettings { get; set; }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<CustomSessin> CustomSessins { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<BookingStatus> BookingStatuses { get; set; }
        public DbSet<AcademicRank> AcademicRanks { get; set; }
        public DbSet<MemberType> MemberTypes { get; set; }
        public DbSet<SessionType> SessionTypes { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<CancelReason> CancelReasons { get; set; }

        public DbSet<CRN> CRNs { get; set; }
        public ExamControlDbContext(DbContextOptions<ExamControlDbContext> options)
            : base(options)
        {
            
    }
    }
}
