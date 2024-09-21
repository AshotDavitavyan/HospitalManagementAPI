using Application.DTOs;
using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class DoctorService : IDoctorService
{
	private readonly IDoctorRepository _doctorRepository;
	private readonly ISpecializationRepository _specializationRepository;
	private readonly IRegionRepository _regionRepository;
	private readonly ICabinetRepository _cabinetRepository;
	
	public DoctorService(IDoctorRepository doctorRepository, ISpecializationRepository specializationRepository, IRegionRepository regionRepository, ICabinetRepository cabinetRepository)
	{
		_doctorRepository = doctorRepository;
		_specializationRepository = specializationRepository;
		_regionRepository = regionRepository;
	}
	public async Task<DoctorDto> GetByIdAsync(int id)
	{
		Doctor doctor = await _doctorRepository.GetByIdAsync(id);
		if (doctor == null) return null;
		return new DoctorDto()
		{
			Id = doctor.Id,
			FullName = doctor.FullName,
			CabinetId = doctor.CabinetId,
			RegionId = doctor.RegionId,
			SpecializationId = doctor.SpecializationId
		};
	}

	public async Task<List<DoctorListDto>> GetAllAsync()
	{
		List<DoctorListDto> doctorDtos = new();
		List<Doctor> doctors = await _doctorRepository.GetAllAsync();

		foreach (Doctor doctor in doctors)
		{
			doctorDtos.Add(new DoctorListDto()
			{
				Id = doctor.Id,
				FullName = doctor.FullName,
				CabinetNumber = _cabinetRepository.GetByIdAsync(doctor.CabinetId).Result.Number,
				RegionName = _regionRepository.GetByIdAsync(doctor.RegionId).Result.Name,
				SpecializationName = _specializationRepository.GetByIdAsync(doctor.SpecializationId).Result.Name
			});
		}

		return doctorDtos;
	}

	public async Task AddDoctorAsync(DoctorCreateDto doctorCreateDto)
	{
		await _doctorRepository.AddAsync(new Doctor
		{
			FullName = $"{doctorCreateDto.FirstName} {doctorCreateDto.LastName} {doctorCreateDto.MiddleName}",
			CabinetId = doctorCreateDto.CabinetId,
			RegionId = doctorCreateDto.RegionId,
			SpecializationId = doctorCreateDto.SpecializationId
		});
	}

	public async Task UpdateDoctorAsync(int id, DoctorUpdateDto doctorUpdateDto)
	{
		await _doctorRepository.UpdateAsync(new Doctor
		{
			Id = id,
			FullName = $"{doctorUpdateDto.FirstName} {doctorUpdateDto.LastName} {doctorUpdateDto.MiddleName}",
			CabinetId = doctorUpdateDto.CabinetId,
			RegionId = doctorUpdateDto.RegionId,
			SpecializationId = doctorUpdateDto.SpecializationId
		});
	}

	public async Task DeleteDoctorAsync(int id)
	{
		await _doctorRepository.DeleteAsync(await _doctorRepository.GetByIdAsync(id));
	}
}