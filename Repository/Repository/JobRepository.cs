using EntityModels.Dto;
using EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class JobRepository: IJobRepository
    {
        private readonly AppDbContext _context;

        public JobRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<JobListDto> GetJobList()
        {
            List<JobListDto> Jobs = new List<JobListDto>();
            var AllJobs = _context.Jobs.Include(j => j.Company).Include(j => j.Application).ToList();
            foreach (var job in AllJobs )
            {
                JobListDto jobDto = new JobListDto()
                {
                    Id = job.Id,
                    Title = job.Title,
                    Description = job.Description,
                    Status = job.status,
                    SalaryRange = job.SalaryRange,
                    Type = job.Type,
                    InsertDate = job.InsertDate,
                    JobRequirements = job.JobRequirements?.Split(',').ToArray(), 
                    CompanyName = _context.Companies.Where(c=>c.Id== job.CompanyId).Select(c=>c.Name).FirstOrDefault().ToString(), // Assuming Company has a Name property
                    InsertUser = job.InsertUser,
                    
                };

                Jobs.Add(jobDto);
            }

            return Jobs;
        }
        public JobListDto GetJobDetail(int JobId)
        {
            var JobDetails = _context.Jobs.Where(j => j.Id == JobId).FirstOrDefault();
            var company = _context.Companies.Where(c => c.Id == JobDetails.CompanyId).FirstOrDefault();
            JobDto job = new JobDto()
                {
                    Id = JobDetails.Id,
                    Title = JobDetails.Title,
                    Description = JobDetails.Description,
                    Status = JobDetails.status,
                    SalaryRange = JobDetails.SalaryRange,
                    Type = JobDetails.Type,
                    InsertDate = JobDetails.InsertDate,
                    JobRequirements = JobDetails.JobRequirements?.Split(',').ToArray(),
                    CompanyName = company.Name, // Assuming Company has a Name property
                    InsertUser = JobDetails.InsertUser,
                    CompanyDescription = company.Description,
                    CompanyLocation= company.Location


            };

         

            return job;
        }
    }
}
