using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EntityModels.Dto
{
    public class RegisterDto
    {
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Role { get; set; }
        public string phoneNumber { get; set; }
        public string gender { get; set; } 
        public DateTime birthday { get; set; }
    }

}

