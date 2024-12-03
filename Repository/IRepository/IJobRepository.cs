using EntityModels.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IJobRepository
    {
        List<JobListDto> GetJobList();
        JobListDto GetJobDetail(int JobId);

    }
}
