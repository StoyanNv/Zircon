﻿namespace Zircon.Services.Mapping
{
    using AutoMapper;
    using Common.User.BindingModels;
    using Common.User.ViewModels;
    using Models;
    using Zircon.Common.Admin.BindingModels;
    using Zircon.Common.Admin.ViewModels;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<User, UserConciseViewModel>();
            this.CreateMap<User, UserDetailsViewModel>();
            this.CreateMap<Address, UserDetailsViewModel>();
            this.CreateMap<UserDetailsViewModel, UserDetailsViewModel>()
                .ForAllMembers(o => o.Condition((source, destination, member) => member != null));

            this.CreateMap<AddAndEditProductBindingModel, Product>();
            this.CreateMap<Product, AddAndEditProductBindingModel>();

            this.CreateMap<AddCategoryBindingModel, Category>();
            this.CreateMap<Product, ProductDetailsVIewModel>();
            this.CreateMap<AddGiftCardBindingModel, GiftCard>();
            this.CreateMap<Product, IndexProductsCardViewModel>();
            this.CreateMap<Category, AllCategoriesViewModel>();
            this.CreateMap<ShopingCartViewModel, Product>();
            this.CreateMap<AddAddressBindingModel, Address>();
            this.CreateMap<Address, AddAddressBindingModel>();
        }
    }
}