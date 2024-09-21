using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class CabinetRepository : ICabinetRepository
{
	private readonly HospitalDbContext _context;
	
	public CabinetRepository(HospitalDbContext context)
	{
		_context = context;
	}
	public async Task<Cabinet> GetByIdAsync(int doctorCabinetId)
	{
		return await _context.Cabinets.FindAsync(doctorCabinetId);
	}
}