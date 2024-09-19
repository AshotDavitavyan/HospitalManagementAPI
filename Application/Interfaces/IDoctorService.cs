using Application.DTOs;

namespace Application.Interfaces;

public interface IDoctorService
{
	Task<DoctorDto> GetByIdAsync(int id);
	Task<IEnumerable<DoctorListDto>> GetDoctorAsync(string sortBy, int page, int pageSize);
	Task AddDoctorAsync(DoctorCreateDto doctorCreateDto);
	Task UpdateDoctorAsync(int id, DoctorUpdateDto doctorUpdateDto);
	Task DeleteDoctorAsync(int id);
}