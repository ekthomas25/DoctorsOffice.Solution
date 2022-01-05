using System.Collections.Generic;

namespace DoctorsOffice.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.JoinDoctorPatients = new HashSet<DoctorPatient>();
      this.JoinDoctorSpecialties = new HashSet<DoctorSpecialty>();
    }

    public int DoctorId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public virtual ICollection<DoctorPatient> JoinDoctorPatients { get;}
    public virtual ICollection<DoctorSpecialty> JoinDoctorSpecialties { get;}
  }
}