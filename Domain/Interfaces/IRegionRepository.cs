using Domain.Models;

namespace Domain.Interfaces;

public interface IRegionRepository
{
	public Task<Region>GetByIdAsync(int patientRegionId);
}