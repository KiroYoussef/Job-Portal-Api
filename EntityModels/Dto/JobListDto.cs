using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Dto
{
    public class JobListDto
    {
      
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }
            public DateTime InsertDate { get; set; }
        public string SalaryRange { get; set; }
        public string Type { get; set; }
        public string[] JobRequirements { get; set; }

            public string CompanyName { get; set; }

            public string InsertUser { get; set; }

        


    }
}
