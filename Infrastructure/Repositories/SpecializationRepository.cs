using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class SpecializationRepository : ISpecializationRepository
{
	private HospitalDbContext _context;
	public SpecializationRepository(HospitalDbContext context)
	{
		_context = context;
	}
	public async Task<Specialization> GetByIdAsync(int doctorSpecializationId)
	{
		return await _context.Specializations.FindAsync(doctorSpecializationId);
	}
}