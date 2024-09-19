namespace Application.DTOs;

public class PatientUpdateDto
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string SecondName { get; set; }
	public string Surname { get; set; }
	public string Address { get; set; }
	public DateTime DateOfBirth { get; set; }
	public char Gender { get; set; }
	public int RegionId { get; set; }	
}