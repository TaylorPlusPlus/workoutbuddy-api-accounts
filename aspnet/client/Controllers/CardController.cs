using System.Collections.Generic;
using System.Net.Http;
using domain.models;
using Microsoft.AspNetCore.Mvc;
using repo;

namespace client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        //Use the unit of work repo
        UnitOfWork UnitOfWork;
        private HttpClient _http = new HttpClient();

        //have constructor injection provide the repo
        public CardController(UnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            System.Console.WriteLine("Calling CardController Get");
            IEnumerable<CardModel> cards  = UnitOfWork.CardRepo.GetAll();

            return Ok(cards);
        }

        [HttpGet("[action]")]
        public IActionResult Test()
        {
            return Ok("Everything Updated Fine");
        }
    }
}