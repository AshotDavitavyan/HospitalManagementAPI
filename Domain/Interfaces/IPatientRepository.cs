using Domain.Models;

namespace Domain.Interfaces;

public interface IPatientRepository
{
	Task<List<Patient>> GetAllAsync();
	Task<Patient?> GetByIdAsync(int id);
	Task AddAsync(Patient patient);
	Task UpdateAsync(Patient patient);
	Task DeleteAsync(Patient patient);
}