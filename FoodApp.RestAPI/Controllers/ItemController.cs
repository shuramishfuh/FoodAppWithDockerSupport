using FoodApp.DTO.DTO;
using FoodApp.Models.Models;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.RestAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemServiceRepository _repository;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ItemController(IItemServiceRepository repository, IWebHostEnvironment hostEnvironment)
        {
            _repository = repository;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetById(int id)
        {
            var item = _repository.GetItemById(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult<ItemDTO> Create([FromForm] ItemDTO itemDto, IFormFile image)
        {
            if (itemDto == null)
            {
                return BadRequest();
            }

            // Check if the image is valid
            if (image != null)
            {
                var uniqueFileName = GetUniqueFileName(image.FileName);
                var uploads = Path.Combine(_hostEnvironment.ContentRootPath, "uploads");
                var filePath = Path.Combine(uploads, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }

                itemDto.ImageUrl = $"uploads/{uniqueFileName}";
            }

            var createdItem = _repository.CreateItem(itemDto);

            if (createdItem == null)
            {
                return BadRequest();
            }

            return Ok();
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public IActionResult Update([FromForm] ItemDTO itemDto, IFormFile? image)
        {
            if (itemDto == null || image is null)
            {
                return BadRequest();
            }

            // Check if the image is valid
            if (image != null)
            {
                var uniqueFileName = GetUniqueFileName(image.FileName);
                var uploads = Path.Combine(_hostEnvironment.ContentRootPath, "uploads");
                var filePath = Path.Combine(uploads, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }

                itemDto.ImageUrl = $"uploads/{uniqueFileName}";
            }

            var itemToUpdate = _repository.GetItemById(itemDto.Id);
            if (itemToUpdate == null)
            {
                return NotFound();
            }

            var updatedItem = _repository.UpdateItem(itemDto);

            if (updatedItem == false)
            {
                return BadRequest();
            }

            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var itemToDelete = _repository.GetItemById(id);

            if (itemToDelete == null)
            {
                return NotFound();
            }

            _repository.DeleteItem(id);
            return NoContent();
        }

        private static string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_" + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
    }
}
