using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;

namespace Jop_Portal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobRepository _JobRepository;
        public JobController(IJobRepository JobRepository)
        {
            _JobRepository = JobRepository;
        }

        [HttpGet("~/api/GetJobDetail")]
        public ActionResult GetJobDetail(int ID)
        {
            return Ok(_JobRepository.GetJobDetail(ID));
        }
    }
}
