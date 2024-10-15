using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Hostel_Management.Models
{
    public class HostelContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }

        public DbSet<FeeHistory> FeeHistories { get; set; }
        public HostelContext(DbContextOptions<HostelContext> options) : base(options)
        {
        }
    }
}
