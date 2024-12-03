using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public string Description { get; set; }
        public string status { get; set; }
        public string SalaryRange { get; set; }
        public string Type { get; set; }
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public string JobRequirements { get; set; }


        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public string InsertUser { get; set; }
        public virtual ICollection<Application> Application { get; set; }


    }
}
