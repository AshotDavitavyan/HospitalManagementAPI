using Microsoft.EntityFrameworkCore;

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
		base.OnModelCreating(modelBuilder);
	}
}