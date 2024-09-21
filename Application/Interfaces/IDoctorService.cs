using Application.DTOs;

namespace Application.Interfaces;

public interface IDoctorService
{
	Task<DoctorDto> GetByIdAsync(int id);
	Task<List<DoctorListDto>> GetAllAsync();
	Task AddDoctorAsync(DoctorCreateDto doctorCreateDto);
	Task UpdateDoctorAsync(int id, DoctorUpdateDto doctorUpdateDto);
	Task DeleteDoctorAsync(int id);
}