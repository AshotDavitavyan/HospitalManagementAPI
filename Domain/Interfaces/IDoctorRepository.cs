using Domain.Models;

namespace Domain.Interfaces;

public interface IDoctorRepository
{
	Task<List<Doctor>> GetAllAsync();
	Task<Doctor?> GetByIdAsync(int id);
	Task AddAsync(Doctor doctor);
	Task UpdateAsync(Doctor doctor);
	Task DeleteAsync(Doctor doctor);
}