using Microsoft.EntityFrameworkCore;
using HospitalManagementAPI.Models;

namespace HospitalManagementAPI.Data;

public class HospitalDbContext : DbContext
{
	public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
	{
	}
	
	public DbSet<Doctor> Doctors { get; set; }
	public DbSet<Patient> Patients { get; set; }
	public DbSet<Cabinet> Cabinets { get; set; }
	public DbSet<Specialization> Specializations { get; set; }
	public DbSet<Region> Regions { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Doctor>()
			.HasOne<Cabinet>()
			.WithMany(c => c.Doctors)
			.HasForeignKey(d => d.CabinetID)
			.OnDelete(DeleteBehavior.Restrict);
		
		modelBuilder.Entity<Doctor>()
			.HasOne<Specialization>()
			.WithMany(s => s.Doctors)
			.HasForeignKey(d => d.SpecializationID)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<Doctor>()
			.HasOne<Region>()
			.WithMany(r => r.Doctors)
			.HasForeignKey(d => d.RegionID)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<Patient>()
			.HasOne<Region>()
			.WithMany(r => r.Patients)
			.HasForeignKey(p => p.RegionID)
			.OnDelete(DeleteBehavior.Restrict);
		
		
		base.OnModelCreating(modelBuilder);
	}
}