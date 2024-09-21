using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class RegionRepository : IRegionRepository
{
	private readonly HospitalDbContext _context;
	
	public RegionRepository(HospitalDbContext context)
	{
		_context = context;
	}
	public async Task<Region> GetByIdAsync(int patientRegionId)
	{
		return await _context.Regions.FindAsync(patientRegionId);
	}
}