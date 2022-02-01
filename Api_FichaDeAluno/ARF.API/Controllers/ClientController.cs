using ARF.Domain;
using ARF.Service;
using Microsoft.AspNetCore.Mvc;

namespace ARF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add(Client client)
        {
            ClientService service = new ClientService();
            service.AddClient(client);

            return StatusCode(201);
        }
    }
}
