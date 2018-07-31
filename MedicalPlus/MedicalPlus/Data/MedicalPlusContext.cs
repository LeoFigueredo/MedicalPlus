using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicalPlus.Data
{
    public class MedicalPlusContext : IdentityDbContext
    {
        public MedicalPlusContext(DbContextOptions<MedicalPlusContext> options)
            : base(options)
        {

         
        }
    }
}
