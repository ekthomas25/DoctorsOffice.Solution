using System;
using System.Collections.Generic;

namespace DoctorsOffice.Models
{
  public class Specialty
  {
    public Specialty()
    {
      this.JoinDoctorSpecialties = new HashSet<DoctorSpecialty>();
    }
    public int SpecialtyID { get; set; }
    public string Description { get; set; }

    public virtual ICollection<DoctorSpecialty> JoinDoctorSpecialties{ get; }
  }
}