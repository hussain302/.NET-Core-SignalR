using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRChat.Hubs;
using System.Threading.Tasks;

namespace ChatService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ChatHub hub;

        public TestController(ChatHub hub)
        {
            this.hub = hub;
        }

        [Route("TestAPI")]
        [HttpGet]
        public async Task<IActionResult> TestAPI()
        {

            await hub.SendMessage("Hello");
            return Ok("Chat API Called successfully");
        }
    }
}
