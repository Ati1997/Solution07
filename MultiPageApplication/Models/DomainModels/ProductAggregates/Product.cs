using System.ComponentModel.DataAnnotations;

namespace MultiPageApplication.Models.DomainModels.ProductAggregates
{
    public class Product
    {

        [Key] 
        public Guid Id { get; set; }


        public string Title { get; set; }
        public int Quantity { get; set; }
        //public int Price { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
