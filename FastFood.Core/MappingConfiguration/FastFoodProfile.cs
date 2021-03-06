﻿using FastFood.Core.ViewModels.Categories;
using FastFood.Core.ViewModels.Employees;
using FastFood.Core.ViewModels.Items;
using FastFood.Core.ViewModels.Orders;

namespace FastFood.Core.MappingConfiguration
{
    using AutoMapper;
    using FastFood.Models;
    using ViewModels.Positions;

    public class FastFoodProfile : Profile
    {
        public FastFoodProfile()
        {
            //Positions
            this.CreateMap<CreatePositionInputModel, Position>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.PositionName));

            this.CreateMap<Position, PositionsAllViewModel>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.Name));

            //Categories

            this.CreateMap<CreateCategoryInputModel, Category>()
                .ForMember(x => x.Name, 
                    y => y.MapFrom(s => s.CategoryName));
            
            this.CreateMap<Category, CategoryAllViewModel>();

            //Items
            this.CreateMap<Category, CreateItemViewModel>()
                .ForMember(x=>x.CategoryId,
                    y=>y.MapFrom(s=>s.Id))
                .ForMember(x=>x.CategoryName,
                    y=>y.MapFrom(s=>s.Name));

            this.CreateMap<CreateItemInputModel, Item>()
                .ForMember(x => x.Name,
                    y => y.MapFrom(s => s.Name))
                .ForMember(x => x.Price,
                    y => y.MapFrom(s => s.Price))
                .ForMember(x => x.CategoryId,
                    y => y.MapFrom(s => s.CategoryId));
            
            this.CreateMap<Item, ItemsAllViewModels>()
                .ForMember(x=>x.Category,
                    y=>y.MapFrom(s=>s.Category.Name));


            //Employees

            this.CreateMap<Position, RegisterEmployeeViewModel>()
                .ForMember(x=>x.PositionId,
                    y=>y.MapFrom(s=>s.Id))
                .ForMember(x=>x.PositionName,
                    y=>y.MapFrom(s=>s.Name));

            this.CreateMap<RegisterEmployeeInputModel, Employee>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.Name))
                .ForMember(x => x.Age, y => y.MapFrom(s => s.Age))
                .ForMember(x => x.PositionId, y => y.MapFrom(s => s.PositionId))
                //.ForMember(x => x.Position.Name, y => y.MapFrom(s => s.PositionName))
                .ForMember(x => x.Address, y => y.MapFrom(s => s.Address));

            this.CreateMap<Employee, EmployeesAllViewModel>()
                .ForMember(x=>x.Position,
                    y=>y.MapFrom(s=>s.Position.Name));

            //Orders
            this.CreateMap<CreateOrderInputModel, Order>()
                .ForMember(x => x.Customer, y => y.MapFrom(s => s.Customer))
                .ForMember(x => x.Customer, y => y.MapFrom(s => s.Customer));
        }
    }
}
