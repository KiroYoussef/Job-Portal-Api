using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels.Models;
using static System.Net.Mime.MediaTypeNames;
using EntityModels.Dto;
using Application = EntityModels.Models.Application;

namespace Repository.Repository
{
    public class ApplicationRepository: IApplicationRepository
    {
        private readonly AppDbContext _context;

        public ApplicationRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool AddApplication(ApplicationDto applicationDto)
        {
            try
            {
                if (applicationDto == null)
                {
                    return false;
                }

                var app = new Application
                {
                    Name = applicationDto.Name,
                    Email = applicationDto.Email, 
                    PhoneNumber = applicationDto.PhoneNumber,
                    JobId = applicationDto.JobId,
                    InsertDate = DateTime.Now
                };

                _context.Applications.Add(app);
                _context.SaveChanges();

                return true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Whrn adding application: {ex.Message}");
                return false; 
            }
        }

    }
}
