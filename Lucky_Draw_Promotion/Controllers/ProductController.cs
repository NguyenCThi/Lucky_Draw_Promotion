using ClosedXML.Excel;
using Lucky_Draw_Promotion.DTO;
using Lucky_Draw_Promotion.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace Lucky_Draw_Promotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("/product1/{id}")]
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await _productService.GetProductById(id);
            if(product.GiftName == null && product.Description == null & product.CreatedDate == null)
            {
                return BadRequest("This product not exist.");
            }
            return Ok(product);
        }
        [HttpPut("/product/edit/{id}")]
        public async Task<ActionResult> EditProductById(int id, [FromForm]EditProductDTO request)
        {
            var productId = await _productService.EditProductById(id, request);
            if(productId == 0)
            {
                return BadRequest("Error appear when edit product.");
            }
            if(productId == -1)
            {
                return BadRequest("Product not found.");
            }
            var product = await _productService.GetProductById(productId);
            return Ok(product);
        }
        [HttpDelete("/product/delete/{id}")]
        public async Task<ActionResult> DeleteProductById(int id)
        {
            var productDeleteCheck = await _productService.DeleteProductById(id);
            if( productDeleteCheck == 0)
            {
                return BadRequest("Error appear when delete product.");
            }
            else if(productDeleteCheck == 1)
            {
                return BadRequest("Product not found.");
            }
            else
            {
                return Ok("Product delete success.");
            }
        }
        [HttpPost("/product/add-new-product")]
        public async Task<ActionResult> AddNewProduct([FromForm]AddNewProductDTO request)
        {
            var productId = await _productService.AddNewProduct(request);
            if(productId == 0)
            {
                return BadRequest("Error appear when create new product.");
            }
            var product = await _productService.GetProductById(productId);
            return Ok(product);
        }
        [HttpPost("/product/excel-all-product")]
        public async Task<ActionResult> GetAllProductToExcel()
        {
            var streamExport = await _productService.ExportAllProduct();
            var content = streamExport.ToArray();
            var filename = "AllProduct.xlsx";
            return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", filename);
        }
        [HttpPost("/product/import-excel")]
        public async Task<ActionResult> ImportExcelProudct(IFormFile file)
        {
            var checkWhatHappen = await _productService.ImportProduct(file);
            if(checkWhatHappen == 0)
            {
                return BadRequest("Please input .xlsx extension.");
            }
            else{
                return Ok("Add products success.");
            }
            
        }
    }
}
