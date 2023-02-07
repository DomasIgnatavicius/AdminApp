using AdminApp.Models;
using AdminApp.Models.DTO;
using AdminApp.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepo;
        public ProductController(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet("getproducts")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<GetProductDTO>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<GetProductDTO>> GetProducts()
        {
            return Ok(_productRepo.GetAll()
                .Select(p => new GetProductDTO(p))
                .ToList());
        }

        [HttpPost("createproduct")]
        //[Authorize]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateProductDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CreateProductDTO> CreateProduct(CreateProductDTO productDto)
        {
            if (productDto == null)
            {
                return BadRequest();
            }

            var model = new Product()
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Description = productDto.Description,
                Rating = productDto.Rating,
                CategoryId = productDto.CategoryId,
                CreateDateTime = productDto.CreateDateTime
            };

            _productRepo.Create(model);

            return CreatedAtRoute("createproduct", productDto);
        }

        [HttpDelete("products/deleteproduct/{id:int}")]
        //[Authorize(Roles = "super-admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult DeleteProduct(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var product = _productRepo.Get(d => d.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            _productRepo.Remove(product);

            return NoContent();
        }


        [HttpPut("products/updateproduct/{id:int}")]
        //[Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult UpdateProduct(int id, UpdateProductDTO updateProductDTO)
        {
            if (id == 0 || updateProductDTO == null)
            {
                return BadRequest();
            }

            var foundProduct = _productRepo.Get(d => d.Id == id);

            if (foundProduct == null)
            {
                return NotFound();
            }

            foundProduct.Name = updateProductDTO.Name;
            foundProduct.Description = updateProductDTO.Description;
            foundProduct.Rating = updateProductDTO.Rating;
            foundProduct.Price = updateProductDTO.Price;
            foundProduct.Supply= updateProductDTO.Supply;


            _productRepo.Update(foundProduct);

            return NoContent();
        }
    }
}
