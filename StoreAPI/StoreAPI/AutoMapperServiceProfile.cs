using AutoMapper;
using StoreAPI.Contracts;
using StoreAPI.Models;

namespace StoreAPI
{
    public class AutoMapperServiceProfile : Profile
    {
        public AutoMapperServiceProfile()
        {
            CreateMap<CustomerModel, Customer>();
            CreateMap<OrderModel, Order>();
            CreateMap<ProductModel, Product>();
        }
    }
}
