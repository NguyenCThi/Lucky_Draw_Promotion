using Lucky_Draw_Promotion.DTO;

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
    }
    public interface IProductService
    {
        Task<ProductCategoryViewDTO> GetProductById(int id);
        Task<int> EditProductById(int id, EditProductDTO request);
        Task<int> DeleteProductById(int id);
        Task<int> AddNewProduct(AddNewProductDTO request);
    }
}
