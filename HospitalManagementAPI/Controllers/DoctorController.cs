using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DoctorController(IDoctorService doctorService) : ControllerBase
{
	[HttpGet]
	public async Task<IActionResult> GetAll()
	{
		var doctors = await doctorService.GetAllAsync();
		return Ok(doctors);
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> Get(int id)
	{
		var doctor = await doctorService.GetByIdAsync(id);
		if (doctor is null) return NotFound();

		return Ok(doctor);
	}
	
	[HttpPost]
	public async Task<IActionResult> AddDoctor(DoctorCreateDto doctor)
	{
		var result = await doctorService.AddDoctorAsync(doctor);
		return CreatedAtAction(nameof(AddDoctor), new { id = result }, doctor);
	}

	[HttpPut("{id}")]
	public async Task<IActionResult> UpdateDoctor(int id, DoctorUpdateDto doctor)
	{
		var result = await doctorService.UpdateDoctorAsync(id, doctor);
		if (result is null) return Conflict();
		return NoContent();
	}

	[HttpDelete]
	public async Task<IActionResult> DeleteDoctor(int id)
	{
		var result = await doctorService.DeleteDoctorAsync(id);
		if (result is null) return NotFound();
		return NoContent();
	}
}