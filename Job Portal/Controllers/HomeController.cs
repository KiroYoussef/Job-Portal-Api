using EntityModels.Dto;
using EntityModels.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;

namespace Jop_Portal.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IJobRepository _JobRepository;
         public  HomeController(IJobRepository JobRepository)
        {
            _JobRepository = JobRepository;
        }

        [HttpGet("~/api/GetJobsList")] 
        public ActionResult GetJobsList()
        {
            return Ok(_JobRepository.GetJobList());
        }
    }
}
