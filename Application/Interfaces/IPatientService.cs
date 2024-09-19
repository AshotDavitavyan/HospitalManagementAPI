using Application.DTOs;

namespace Application.Interfaces;

public interface IPatientService
{
	Task<PatientDto> GetByIdAsync(int id);
	Task<IEnumerable<PatientListDto>> GetPatientAsync(string sortBy, int page, int pageSize);
	Task AddPatientAsync(PatientCreateDto patientCreateDto);
	Task UpdatePatientAsync(int id, PatientUpdateDto patientUpdateDto);
	Task DeletePatientAsync(int id);
}