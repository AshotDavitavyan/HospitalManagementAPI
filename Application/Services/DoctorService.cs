using Application.DTOs;
using Application.Interfaces;

namespace Application.Services;

public class DoctorService : IDoctorService
{
	public Task<DoctorDto> GetByIdAsync(int id)
	{
		throw new NotImplementedException();
	}

	public Task<IEnumerable<DoctorListDto>> GetDoctorAsync(string sortBy, int page, int pageSize)
	{
		throw new NotImplementedException();
	}

	public Task AddDoctorAsync(DoctorCreateDto doctorCreateDto)
	{
		throw new NotImplementedException();
	}

	public Task UpdateDoctorAsync(int id, DoctorUpdateDto doctorUpdateDto)
	{
		throw new NotImplementedException();
	}

	public Task DeleteDoctorAsync(int id)
	{
		throw new NotImplementedException();
	}
}