using ClosedXML.Excel;
using Lucky_Draw_Promotion.DTO;
using OfficeOpenXml;

namespace Lucky_Draw_Promotion.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<int> AddNewProduct(AddNewProductDTO request)
        {
            try
            {
                Product product = new Product();
                product.ProductName = request.ProductName;
                product.ProductDescription = request.ProductDescription;
                product.CreatedDate = DateTime.Now;
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return product.ProductId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            
        }

        public async Task<int> DeleteProductById(int id)
        {
            try
            {
                Product? product = await _context.Products.FindAsync(id);
                if (product == null)
                {
                    return 1;
                }
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            
        }

        public async Task<int> EditProductById(int id, EditProductDTO request)
        {
            try
            {
                Product? product = await _context.Products.FindAsync(id);
                if(product == null)
                {
                    return -1;
                }
                product.ProductName = request.ProductName;
                if(request.ProductDescription != null)
                {
                    product.ProductDescription = request.ProductDescription;
                }
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
                return product.ProductId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            
        }

        public async Task<MemoryStream> ExportAllProduct()
        {
            var products = await _context.Products.ToListAsync();
            var productsDTO = new List<ProductCategoryViewDTO>();
            foreach (var product in products)
            {
                ProductCategoryViewDTO dto = new ProductCategoryViewDTO();
                dto.Id = product.ProductId;
                dto.GiftName = product.ProductName;
                dto.Description = product.ProductDescription;
                dto.CreatedDate = String.Format("{0:G}", product.CreatedDate);
                productsDTO.Add(dto);
            }
            using (var package = new XLWorkbook())
            {
                var sheet = package.Worksheets.Add("All products");
                var currentRow = 1;
                sheet.Cell(currentRow, 1).Value = "Id";
                sheet.Cell(currentRow, 2).Value = "Product Name";
                sheet.Cell(currentRow, 3).Value = "Product Description";
                sheet.Cell(currentRow, 4).Value = "Created Date";
                foreach (var product in productsDTO)
                {
                    currentRow++;
                    sheet.Cell(currentRow, 1).Value = product.Id;
                    sheet.Cell(currentRow, 2).Value = product.GiftName;
                    sheet.Cell(currentRow, 3).Value = product.Description;
                    sheet.Cell(currentRow, 4).Value = product.CreatedDate;
                }
                using (var stream = new MemoryStream())
                {
                    package.SaveAs(stream);
                    return stream;
                }
            }
            
        }

        public async Task<ProductCategoryViewDTO> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                ProductCategoryViewDTO productCategoryViewDTO1 = new ProductCategoryViewDTO();
                return productCategoryViewDTO1;
            }
            ProductCategoryViewDTO productCategoryViewDTO = new ProductCategoryViewDTO();
            productCategoryViewDTO.Id = product.ProductId;
            productCategoryViewDTO.GiftName = product.ProductName;
            productCategoryViewDTO.Description = product.ProductDescription;
            productCategoryViewDTO.CreatedDate = String.Format("{0:G}", product.CreatedDate);
            return productCategoryViewDTO;
        }

        public async Task<int> ImportProduct(IFormFile file)
        {
            if (file != null && file.Length > 0 && Path.GetExtension(file.FileName).ToLower() == ".xlsx")
            {
                var list = new List<ImportExcelProductDTO>();
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (var package = new ExcelPackage(stream))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        var rowcount = worksheet.Dimension.Rows;
                        for (int row = 1; row <= rowcount; row++)
                        {
                            list.Add(new ImportExcelProductDTO
                            {
                                ProductName = worksheet.Cells[row, 1].Value == null ? string.Empty : worksheet.Cells[row, 1].Value.ToString().Trim(),
                                ProductDescription = worksheet.Cells[row, 2].Value == null ? string.Empty : worksheet.Cells[row, 2].Value.ToString().Trim(),
                            });
                        }
                        foreach (var item in list)
                        {
                            if (item.ProductName == "")
                            {
                                continue;
                            }
                            else
                            {
                                Product product = new Product();
                                product.ProductName = item.ProductName;
                                product.ProductDescription = item.ProductDescription;
                                product.CreatedDate = DateTime.Now;
                                _context.Products.Add(product);
                                await _context.SaveChangesAsync();
                            }
                        }
                        return 1;
                    }
                }
            }
            else
            {
                return 0;
            }
        }
    }
    public interface IProductService
    {
        Task<ProductCategoryViewDTO> GetProductById(int id);
        Task<int> EditProductById(int id, EditProductDTO request);
        Task<int> DeleteProductById(int id);
        Task<int> AddNewProduct(AddNewProductDTO request);
        Task<MemoryStream> ExportAllProduct();
        Task<int> ImportProduct(IFormFile file);
    }
}
