using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalPlus.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime DateJoined { get; set; }
        public string Speciality { get; set; }

    }
}
