using MedicalPlus.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalPlus.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public string ApplicationUserId { get; set; }
        public int DoctorID { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Status { get; set; }
        public string Service { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Doctor Doctor { get; set; }

    }
}
