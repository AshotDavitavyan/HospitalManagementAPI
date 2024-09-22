using Application.DTOs;

namespace Application.Interfaces;

public interface IDoctorService
{
	Task<DoctorDto?> GetByIdAsync(int id);
	Task<List<DoctorListDto>> GetAllAsync();
	Task<int> AddDoctorAsync(DoctorCreateDto doctorCreateDto);
	Task<int?> UpdateDoctorAsync(int id, DoctorUpdateDto doctorUpdateDto);
	Task<int?> DeleteDoctorAsync(int id);
}