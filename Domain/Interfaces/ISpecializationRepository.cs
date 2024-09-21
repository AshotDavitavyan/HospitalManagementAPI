using Domain.Models;

namespace Domain.Interfaces;

public interface ISpecializationRepository
{
	Task<Specialization> GetByIdAsync(int doctorSpecializationId);
}