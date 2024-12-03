using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Dto
{
    public class JobDto: JobListDto
    {
        
        public string CompanyDescription { get; set; }
        public string CompanyLocation { get; set; }
    }
}
