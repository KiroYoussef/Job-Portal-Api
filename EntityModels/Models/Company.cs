using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Location { get; set; }

        public DateTime InsertDate { get; set; } = DateTime.Now;

        public virtual ICollection<Job> Job { get; set; }

        public string InsertUser { get; set; }

    }
}
