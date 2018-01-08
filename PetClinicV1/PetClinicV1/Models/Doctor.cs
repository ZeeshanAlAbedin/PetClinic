using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PetClinicV1.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        public string D_FirstName { get; set; }
        public int D_LastName { get; set; }
        public String D_Specialization { get; set; }
    }

    public class DoctorContext : DbContext
    {
        public DoctorContext()
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
    }
}