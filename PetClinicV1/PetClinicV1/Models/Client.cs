using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetClinicV1.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string C_FirstName { get; set; }
        public int C_LastName { get; set; }
        public String Pet_Breed  { get; set; }
    }
}