using System.Net.Http;
using domain.models;
using Microsoft.AspNetCore.Mvc;
using repo;

namespace client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        //Use the unit of work repo
        UnitOfWork UnitOfWork;
        private HttpClient _http = new HttpClient();

        //have constructor injection provide the repo
        public AccountController(UnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        [HttpGet("[action]/{email}")]
        public IActionResult Get(string email)
        {
            System.Console.WriteLine("Calling AccountController Get");
            AccountModel Account = UnitOfWork.AccountRepo.Get(email);
            string testString = " Email = " + email;
            // use the repo
            var inc  = email;
            return Ok(inc);
        }
    }
}