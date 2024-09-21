namespace Application.DTOs;

public class PatientDto
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string MiddleName { get; set; }
	public string Address { get; set; }
	public DateTime DateOfBirth { get; set; }
	public char Gender { get; set; }
	public int RegionId { get; set; }
}