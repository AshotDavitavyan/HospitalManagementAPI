namespace Application.DTOs;

public class DoctorUpdateDto
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string MiddleName { get; set; }
	public int CabinetId { get; set; }
	public int SpecializationId { get; set; }
	public int RegionId { get; set; }
}