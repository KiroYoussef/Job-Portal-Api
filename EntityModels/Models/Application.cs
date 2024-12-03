using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Models
{
    public class Application
    {
        [Key]

        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime InsertDate { get; set; } = DateTime.Now;




        [ForeignKey("Job")]
        public int JobId { get; set; }
        public virtual Job Job { get; set; }
    }
}
