using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eGaraz.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Firemen> Firemens { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<MedicalExamination> MedicalExaminations { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<FiremenTrip> FiremenTrips { get; set; }
        public DbSet<VehicleTrip> VehicleTrips { get; set; }
        public DbSet<EquipmentTrip> EquipmentTrips { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Firemen
            builder.Entity<Firemen>()
                .HasOne<Driver>(s => s.Driver)
                .WithOne(s => s.Firemen)
                .HasForeignKey<Driver>(s => s.FiremenId);

            //Equipment
            builder.Entity<Equipment>()
                .HasOne<Vehicle>(s => s.Vehicle)
                .WithMany(s => s.Equipments)
                .HasForeignKey(s => s.VehicleId);

            //Medical Examination
            builder.Entity<MedicalExamination>()
                .HasOne<Firemen>(s => s.Firemen)
                .WithMany(s => s.MedicalExaminations)
                .HasForeignKey(s => s.FiremenId);

            builder.Entity<MedicalExamination>()
                .HasOne<Driver>(s => s.Driver)
                .WithMany(s => s.MedicalExaminations)
                .HasForeignKey(s => s.DriverId);

            //Training
            builder.Entity<Training>()
                .HasOne<Firemen>(s => s.Firemen)
                .WithMany(s => s.Trainings)
                .HasForeignKey(s => s.FiremenId)
                .IsRequired();

            //Many-To-Many
            builder.Entity<FiremenTrip>()
                .HasKey(s => new { s.FiremenId, s.TripId });

            builder.Entity<VehicleTrip>()
                .HasKey(s => new { s.VehicleId, s.TripId });

            builder
                .Entity<EquipmentTrip>().HasKey(s => new { s.EquipmentId, s.TripId });

            base.OnModelCreating(builder);
        }
    }
}
