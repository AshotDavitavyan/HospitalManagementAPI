
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class DoctorRepository : IDoctorRepository
{
	private readonly HospitalDbContext _context;
	
	public DoctorRepository(HospitalDbContext context)
	{
		_context = context;
	}
	
	public async Task<List<Doctor>> GetAllAsync()
	{
		return await _context.Doctors.ToListAsync();
	}

	public async Task<Doctor?> GetByIdAsync(int id)
	{
		return await _context.Doctors.FindAsync(id);
	}

	public async Task AddAsync(Doctor doctor)
	{
		await _context.Doctors.AddAsync(doctor);
		await _context.SaveChangesAsync();
	}

	public async Task UpdateAsync(Doctor doctor)
	{
		_context.Doctors.Update(doctor);
		await _context.SaveChangesAsync();
	}

	public async Task DeleteAsync(Doctor doctor)
	{
		var doctorToDelete = await _context.Doctors.FindAsync(doctor.Id);
		_context.Doctors.Remove(doctorToDelete);
	}
}