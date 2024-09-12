namespace HospitalManagementAPI.Models;

public class Specialization
{
	public int SpecializationID { get; set; }
	public string Name { get; set; }
	
	public ICollection<Doctor> Doctors { get; set; }
}