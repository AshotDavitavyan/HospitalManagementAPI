using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class PatientRepository : IPatientRepository
{
	public readonly HospitalDbContext _context;
	
	public PatientRepository(HospitalDbContext context)
	{
		_context = context;
	}

	public async Task<List<Patient>> GetAllAsync()
	{
		return await _context.Patients.ToListAsync();
	}

	public async Task<Patient?> GetByIdAsync(int id)
	{
		return await _context.Patients.FindAsync(id);
	}

	public async Task AddAsync(Patient patient)
	{
		await _context.Patients.AddAsync(patient);
		await _context.SaveChangesAsync();
	}

	public async Task UpdateAsync(Patient patient)
	{
		_context.Patients.Update(patient);
		await _context.SaveChangesAsync();
	}

	public async Task DeleteAsync(Patient patient)
	{
		Patient? patientToDelete = await _context.Patients.FindAsync(patient.Id);
		if (patientToDelete != null)
		{
			_context.Patients.Remove(patientToDelete);
			await _context.SaveChangesAsync();
		}
	}
}