using FoodApp.Models.Models;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.RestAPI.Controllers

{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : Controller
    {
        private readonly IAddressServiceRepository Repository;

        public AddressesController(IAddressServiceRepository addressServiceRepository)
        {
            Repository = addressServiceRepository;
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> Details(int id)
        {
            if (id != null)
            {
                var address = Repository.GetAddressWithID(id);
                if (address == null)
                {
                    return NotFound();
                }

                return Ok(address);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] Address address)
        {
            if (address is not null)
            {
                if (Repository.AddAddress(address))
                {
                    Repository.SaveCommit();
                    return Ok(address);
                }

            }
            return BadRequest();
        }


        [HttpPut]
        [Route("Edit")]
        public async Task<IActionResult> Edit([FromBody] Address address)
        {


            if (address is not null)
            {
                try
                {
                    var addr = Repository.UpdateAddress(address);
                    Repository.SaveCommit();
                    return Ok(addr);
                }
                catch { }

            }
            return NotFound();

        }


        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (Repository.DeleteAddressWithId(id))
            {
                Repository.SaveCommit();
                return Ok();
            }

            return NotFound();
        }

    }
}
