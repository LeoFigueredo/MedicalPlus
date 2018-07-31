using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalPlus.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
        [PersonalData]
        public string Address { get; set; }
        [PersonalData]
        public string Gender { get; set; }
        
    }
}
