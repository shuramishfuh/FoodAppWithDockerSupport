using FoodApp.DTO.DTO;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.RestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuServiceRepository _repository;

        public MenuController(IMenuServiceRepository repository)
        {
            _repository = repository;
        }

        // GET api/menu
        [HttpGet]
        public ActionResult<IEnumerable<MenuDTO>> GetAllMenusWithResturantId(int id)
        {
            var menus = _repository.GetAllMenusWithResturantId(id);

            if (!menus.Any())
            {
                return NotFound();
            }

            return Ok(menus);
        }

        // GET api/menu/{id}
        [HttpGet("{id}")]
        public ActionResult<MenuDTO> GetMenuById(int id)
        {
            var menu = _repository.GetMenuById(id);

            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }

        // POST api/menu
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult<MenuDTO> CreateMenu(MenuDTO menu)
        {
            if (menu == null)
            {
                return BadRequest();
            }

            var createdMenu = _repository.CreateMenu(menu);

            if (createdMenu == null)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetMenuById), new { id = createdMenu.Id }, createdMenu);
        }

        // PUT api/menu/{id}
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<MenuDTO> UpdateMenu(int id, MenuDTO menu)
        {
            if (menu == null || id != menu.Id)
            {
                return BadRequest();
            }

            var existingMenu = _repository.GetMenuById(id);

            if (existingMenu == null)
            {
                return NotFound();
            }

            var updatedMenu = _repository.UpdateMenu(menu);

            if (updatedMenu == null)
            {
                return BadRequest();
            }

            return Ok(updatedMenu);
        }

        // DELETE api/menu/{id}
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteMenu(int id)
        {
            var existingMenu = _repository.GetMenuById(id);

            if (existingMenu == null)
            {
                return NotFound();
            }

            _repository.DeleteMenu(id);

            return NoContent();
        }
    }
}
