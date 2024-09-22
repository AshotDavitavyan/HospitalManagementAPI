using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PatientsController(IPatientService patientService) : ControllerBase
{
	[HttpGet]
	public async Task<IActionResult> GetAll()
	{
		var patients=  await patientService.GetAllAsync();
		return Ok(patients);
	}
	
	[HttpGet("{id}")]
	public async Task<IActionResult> Get(int id)
	{
		var patient = await patientService.GetByIdAsync(id);
		if (patient is null)
			return NotFound();
		return Ok(patient);
	}

	[HttpPost]
	public async Task<IActionResult> AddPatient(PatientCreateDto patient)
	{
		var result = await patientService.AddPatientAsync(patient);
		return CreatedAtAction(nameof(AddPatient), new { id = result }, patient);
	}

	[HttpPut("{id}")]
	public async Task<IActionResult> UpdatePatient(int id, PatientUpdateDto patient)
	{
		var result = await patientService.UpdatePatientAsync(id, patient);
		if (result is null) return Conflict();
		return NoContent();
	}
	
	[HttpDelete]
	public async Task<IActionResult> DeletePatient(int id)
	{
		var result = await patientService.DeletePatientAsync(id);
		if (result is null) return NotFound();
		return NoContent();
	}
}