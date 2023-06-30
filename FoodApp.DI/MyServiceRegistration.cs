using FoodApp.DTO.DTO;
using FoodApp.DTO.Interfaces;
using FoodApp.Models.Interfaces;
using FoodApp.Models.Models;
using Microsoft.Extensions.DependencyInjection;

namespace FoodApp.DI
{
    /// <summary>
    /// register interfaces to di
    /// 
    /// Usage: call AddMyServices in the ConfigureServices of project and pass and instance of IServiceCollection  to it 
    /// </summary>
    public static class MyServiceRegistration
    {
        public static IServiceCollection AddMyServices(this IServiceCollection services)
        {
            // register models 
            services.AddScoped<IAddress, Address>();
            services.AddScoped<IAppUser, AppUser>();
            services.AddScoped<ICard, Card>();
            services.AddScoped<IItem, Item>();
            services.AddScoped<IMenu, Menu>();
            services.AddScoped<IOrder, Order>();
            services.AddScoped<IOrderItem, OrderItem>();
            services.AddScoped<IPaypal, Paypal>();
            services.AddScoped<IRestaurant, Restaurant>();
            services.AddScoped<ITokens, Tokens>();


            // register all the dtos 
            services.AddScoped<IAddressDTO, AddressDTO>();
            services.AddScoped<ICreatUserDTO, CreatUserDTO>();
            services.AddScoped<IAppUserDTO, AppUserDTO>();
            services.AddScoped<IAppUserAuthDTO, AppUserAuthDTO>();
            services.AddScoped<ICardDTO, CardDTO>();
            services.AddScoped<IItemDTO, ItemDTO>();
            services.AddScoped<IMenuDTO, MenuDTO>();
            services.AddScoped<IOrderDTO, OrderDTO>();
            services.AddScoped<IOrderItemDTO, OrderItemDTO>();
            services.AddScoped<IPaymentDTO, PaymentDTO>();
            services.AddScoped<IPaymentMethodDTO, PaymentMethodDTO>();
            services.AddScoped<IPaypalDTO, PaypalDTO>();
            services.AddScoped<IRestaurantDTO, RestaurantDTO>();
            services.AddScoped<IStatusDTO, StatusDTO>();


            return services;

        }

    }
}