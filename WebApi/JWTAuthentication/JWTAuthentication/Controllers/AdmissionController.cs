using JWTAuthentication.Models;
using JWTAuthentication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthentication.Controllers
{
    [ApiController]
    [Route("api/admission")]
    public class AdmissionController : ControllerBase
    {
        private readonly AdmissionService _service;

        public AdmissionController(AdmissionService service)
        {
            _service = service;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddAdmission(Admission admission)
        {
            _service.Add(admission);
            return Ok("Admission added");
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAdmissions()
        {
            return Ok(_service.GetAll());
        }
    }
}
