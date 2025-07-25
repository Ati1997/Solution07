using Microsoft.EntityFrameworkCore;

namespace RepositoryDesignPattern.ApplicationServices.Dtos.ProductDtos
{
    public class Post_Product_Dto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        //public int Price { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
