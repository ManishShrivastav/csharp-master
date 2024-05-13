using DIDemoLib;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessages messages;

        public MessagesController(IMessages messages)
        {
            this.messages = messages;
        }

        // GET: api/<MessagesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { messages.SayHello(), messages.SayGoodbye() };
        }
    }
}
