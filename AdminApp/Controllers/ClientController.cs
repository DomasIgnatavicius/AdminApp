using AdminApp.Models;
using AdminApp.Models.DTO;
using AdminApp.Repositories.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepo;
        public ClientController(IClientRepository clientRepo)
        {
            _clientRepo = clientRepo;
        }

        [HttpGet("getclients")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<GetProductDTO>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<GetClientDTO>> GetClients()
        {
            return Ok(_clientRepo.GetAll()
                .Select(p => new GetClientDTO(p))
                .ToList());
        }
        [HttpPost("createclient")]
        //[Authorize]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateProductDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CreateClientDTO> CreateClient(CreateClientDTO clientDto)
        {
            if (clientDto == null)
            {
                return BadRequest();
            }

            var model = new Client()
            {
                Name = clientDto.Name,
                LastName = clientDto.LastName,
                Email = clientDto.Email,
                City = clientDto.City,
                Country = clientDto.Country,
                Address = clientDto.Address,
                PhoneNr = clientDto.PhoneNr
            };

            _clientRepo.Create(model);

            return CreatedAtRoute("createclient", new { id = model.Id }, clientDto);
        }

        [HttpDelete("products/deleteclient/{id:int}")]
        //[Authorize(Roles = "super-admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult DeleteClient(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var client = _clientRepo.Get(d => d.Id == id);

            if (client == null)
            {
                return NotFound();
            }

            _clientRepo.Remove(client);

            return NoContent();
        }

        [HttpPut("products/updateclient/{id:int}")]
        //[Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult UpdateClient(int id, UpdateClientDto updateClientDto)
        {
            if (id == 0 || updateClientDto == null)
            {
                return BadRequest();
            }

            var foundClient = _clientRepo.Get(d => d.Id == id);

            if (updateClientDto == null)
            {
                return NotFound();
            }

            foundClient.Name = updateClientDto.Name;
            foundClient.LastName = updateClientDto.LastName;
            foundClient.Email = updateClientDto.Email;
            foundClient.City = updateClientDto.City;
            foundClient.Country = updateClientDto.Country;
            foundClient.Address = updateClientDto.Address;
            foundClient.PhoneNr = updateClientDto.PhoneNr;

            _clientRepo.Update(foundClient);

            return NoContent();
        }
    }
}
