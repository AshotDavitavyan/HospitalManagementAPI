using Application.DTOs;

namespace Application.Interfaces;

public interface IPatientService
{
	Task<PatientDto?> GetByIdAsync(int id);
	Task<List<PatientListDto>> GetAllAsync();
	Task<int> AddPatientAsync(PatientCreateDto patientCreateDto);
	Task<int?> UpdatePatientAsync(int id, PatientUpdateDto patientUpdateDto);
	Task<int?> DeletePatientAsync(int id);
}