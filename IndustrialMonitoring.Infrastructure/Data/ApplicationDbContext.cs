using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IndustrialMonitoring.Core.Entities;

namespace IndustrialMonitoring.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SensorReading> SensorReadings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SensorReading>()
                .HasIndex(s => s.SensorId);

            modelBuilder.Entity<SensorReading>()
                .HasIndex(s => s.Timestamp);
        }
    }
}
