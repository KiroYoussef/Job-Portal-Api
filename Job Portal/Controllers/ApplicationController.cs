using EntityModels.Dto;
using EntityModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;
using Repository.Repository;

namespace Jop_Portal.Controllers
{
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationRepository _ApplicationRepository;


        public ApplicationController(IApplicationRepository ApplicationRepository)
        {
            _ApplicationRepository = ApplicationRepository;

        }


        [HttpPost("~/api/AddApplication")]
        public ActionResult AddApplication(ApplicationDto Application)
        {
            return Ok(_ApplicationRepository.AddApplication(Application));
        }
    }
}
