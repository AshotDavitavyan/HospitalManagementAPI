using Application.DTOs;

namespace Application.Interfaces;

public interface IPatientService
{
	Task<PatientDto> GetByIdAsync(int id);
	Task<List<PatientListDto>> GetAllAsync();
	Task AddPatientAsync(PatientCreateDto patientCreateDto);
	Task UpdatePatientAsync(int id, PatientUpdateDto patientUpdateDto);
	Task DeletePatientAsync(int id);
}