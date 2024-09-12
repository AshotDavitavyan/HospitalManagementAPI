namespace HospitalManagementAPI.Models;

public class Region
{
	public int RegionID { get; set; }
	public string Number { get; set; }
	
	public ICollection<Doctor> Doctors { get; set; }
	public ICollection<Patient> Patients { get; set; }
}