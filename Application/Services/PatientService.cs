using Application.DTOs;
using Application.Interfaces;

namespace Application.Services;

public class PatientService : IPatientService
{
	public readonly IUnitOfWork _unitOfWork;
	public 
	public Task<PatientDto> GetByIdAsync(int id)
	{
		
	}

	public Task<IEnumerable<PatientListDto>> GetPatientAsync(string sortBy, int page, int pageSize)
	{
		throw new NotImplementedException();
	}

	public Task AddPatientAsync(PatientCreateDto patientCreateDto)
	{
		throw new NotImplementedException();
	}

	public Task UpdatePatientAsync(int id, PatientUpdateDto patientUpdateDto)
	{
		throw new NotImplementedException();
	}

	public Task DeletePatientAsync(int id)
	{
		throw new NotImplementedException();
	}
}