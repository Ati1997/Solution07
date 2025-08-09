﻿using MultiPageApplication.ApplicationServices.Dtos.ProductDtos;

namespace MultiPageApplication.ApplicationServices.Services.Contracts
{
    public interface IProductApplicationService
    {
        Task<List<GetAll_Product_Dto>> GetAll();
        Task<GetById_Product_Dto> Get(Guid id);


        Task Post(Post_Product_Dto product_Dto);


        Task Put(Put_Product_Dto product_Dto);


        Task Delete(Delete_Product_Dto product_Dto);
    }
}
