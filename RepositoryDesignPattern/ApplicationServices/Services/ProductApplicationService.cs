using RepositoryDesignPattern.ApplicationServices.Dtos.ProductDtos;
using RepositoryDesignPattern.ApplicationServices.Services.Contracts;
using RepositoryDesignPattern.Models.DomainModels.ProductAggregates;
using RepositoryDesignPattern.Models.Services.Contracts;

namespace RepositoryDesignPattern.ApplicationServices.Services
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductRepository _productRepository;

        public ProductApplicationService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Delete(Delete_Product_Dto product_Dto)
        {
            if (product_Dto == null)
                throw new ArgumentNullException(nameof(product_Dto));

            if (product_Dto.Id == Guid.Empty)
                throw new ArgumentException("Invalid ID");

            var product = await _productRepository.SelectById(product_Dto.Id);
            if (product == null)
                throw new InvalidOperationException("Product not found");

            await _productRepository.Delete(product);
        }

        public  async Task<GetById_Product_Dto> Get(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Invalid ID");

            var product = await _productRepository.SelectById(id);
            if (product == null)
                throw new InvalidOperationException("Product not found");

            return new GetById_Product_Dto
            {
                Id = product.Id,
                Title = product.Title,
                Price = product.Price
            };
        }

        public async Task<List<GetAll_Product_Dto>> GetAll()
        {
            var products = await (_productRepository.SelectAll());

            if (products == null || !products.Any()) 
            { 
                return new List<GetAll_Product_Dto>();
            }

            var getAll_Product_Dto= new List<GetAll_Product_Dto>();

            foreach (var product in products)
            {
                var dto = new GetAll_Product_Dto
                {
                    Id = product.Id,
                    Title = product.Title,
                    Price = product.Price,
                };
                getAll_Product_Dto.Add(dto);
            }
            return getAll_Product_Dto;
        }

        public async Task Post(Post_Product_Dto product_Dto)
        {
            if (product_Dto == null)
                throw new ArgumentNullException(nameof(product_Dto));

            if (string.IsNullOrWhiteSpace(product_Dto.Title))
                throw new ArgumentException("Title is required");

            if (product_Dto.Price <= 0)
                throw new ArgumentException("Price must be greater than zero");

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Title = product_Dto.Title,
                Price = product_Dto.Price
            };

            await _productRepository.Insert(product);
        }

        public async Task Put(Put_Product_Dto product_Dto)
        {
            if (product_Dto == null)
                throw new ArgumentNullException(nameof(product_Dto));

            if (product_Dto.Id == Guid.Empty)
                throw new ArgumentException("Invalid ID"); 

            var product = await _productRepository.SelectById(product_Dto.Id);
            if (product == null)
                throw new InvalidOperationException("Product not found");

            product.Title = product_Dto.Title;
            product.Price = product_Dto.Price;

            await _productRepository.Update(product);
        }
    }
}
