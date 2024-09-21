using Application.DTOs;
using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class PatientService : IPatientService
{
	private readonly IPatientRepository _patientRepository;
	private readonly IRegionRepository _regionRepository;
	
	public PatientService(IPatientRepository patientRepository, IRegionRepository regionRepository)
	{
		_patientRepository = patientRepository;
		_regionRepository = regionRepository;
	}
	
	public async Task<PatientDto> GetByIdAsync(int id)
	{
		var patient = await _patientRepository.GetByIdAsync(id);
		if (patient == null) return null;
		return new PatientDto
		{
			Id = patient.Id,
			FirstName = patient.FirstName,
			LastName = patient.LastName,
			MiddleName = patient.MiddleName,
			Address = patient.Address,
			DateOfBirth = patient.DateOfBirth,
			Gender = patient.Gender,
			RegionId = patient.RegionId
		};
	}

	public async Task<List<PatientListDto>> GetAllAsync()
	{
		var patients = await _patientRepository.GetAllAsync();
		var patientDtos = new List<PatientListDto>();

		foreach (var patient in patients)
		{
			patientDtos.Add(new PatientListDto
			{
				Id = patient.Id,
				FullName = $"{patient.FirstName} {patient.LastName} {patient.MiddleName}",
				Address = patient.Address,
				RegionName = _regionRepository.GetByIdAsync(patient.RegionId).Result.Name
			});
		}

		return patientDtos;
	}

	public async Task AddPatientAsync(PatientCreateDto patientCreateDto)
	{
		await _patientRepository.AddAsync(new Patient
		{
			FirstName = patientCreateDto.FirstName,
			LastName = patientCreateDto.LastName,
			MiddleName = patientCreateDto.MiddleName,
			Address = patientCreateDto.Address,
			DateOfBirth = patientCreateDto.DateOfBirth
		});
	}

	public async Task UpdatePatientAsync(int id, PatientUpdateDto patientUpdateDto)
	{
		await _patientRepository.UpdateAsync(new Patient
		{
			Id = id,
			FirstName = patientUpdateDto.FirstName,
			LastName = patientUpdateDto.LastName,
			MiddleName = patientUpdateDto.MiddleName,
			Address = patientUpdateDto.Address,
			DateOfBirth = patientUpdateDto.DateOfBirth
		});
	}

	public async Task DeletePatientAsync(int id)
	{
		await _patientRepository.DeleteAsync(new Patient { Id = id });
	}
}