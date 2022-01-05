using System;
using System.Collections.Generic;

namespace DoctorsOffice.Models
{
  public class Patient
  {
    public Patient()
    {
      this.JoinDoctorPatients = new HashSet<DoctorPatient>();
    }
    public int PatientId { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }
    public virtual ICollection<DoctorPatient> JoinDoctorPatients { get; set; }
  }
}