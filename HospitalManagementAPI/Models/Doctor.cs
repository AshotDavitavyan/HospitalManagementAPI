namespace HospitalManagementAPI.Models;

public class Doctor
{
	public int DoctorId { get; set; }
	public string FullName { get; set; }
	public int CabinetID { get; set; }
	public int SpecializationID { get; set; }
	public int RegionID { get; set; }
	
	public Cabinet Cabinet { get; set; }
	public Specialization Specialization { get; set; }
	public Region Region { get; set; }
}