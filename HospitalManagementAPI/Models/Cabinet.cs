namespace HospitalManagementAPI.Models;

public class Cabinet
{
	public int CabinetID { get; set; }
	public string Number { get; set; }
	
	public ICollection<Doctor> Doctors { get; set; }
}