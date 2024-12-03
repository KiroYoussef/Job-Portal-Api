using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime BirthDate { get; set; } = DateTime.MinValue;
        public string Gender { get; set; }



    }
}
