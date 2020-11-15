using AutoMapper.OData.EFCore.Tests.Data;
using AutoMapper.OData.EFCore.Tests.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper.OData.EFCore.Tests.Mappings
{
    public class ObjectMappings : Profile
    {
        public ObjectMappings()
        {
            int productParameter = 0;

            CreateMap<Address, AddressModel>()
                .ForAllMembers(o => o.ExplicitExpansion());
            CreateMap<Category, CategoryModel>()
                .ForAllMembers(o => o.ExplicitExpansion());
            CreateMap<DataTypes, DataTypesModel>()
                .ForAllMembers(o => o.ExplicitExpansion());
            CreateMap<DerivedCategory, DerivedCategoryModel>()
                .ForAllMembers(o => o.ExplicitExpansion());
            CreateMap<DerivedProduct, DerivedProductModel>()
                .ForMember(o => o.Status, opt => opt.Ignore())
                .ForAllMembers(o => o.ExplicitExpansion());
            CreateMap<DynamicProduct, DynamicProductModel>()
                .ForMember(o => o.Status, opt => opt.Ignore())
                .ForAllMembers(o => o.ExplicitExpansion());
            CreateMap<Product, ProductModel>()
                .ForMember(o => o.Status, opt => opt.Ignore())
                .ForMember(d => d.Parameter, o => o.MapFrom(s => productParameter))
                .ForAllMembers(o => o.ExplicitExpansion());
            CreateMap<ProductWithStatus, ProductModel>()
                .IncludeMembers(o => o.Product);
//                .ForAllMembers(o => o.ExplicitExpansion());
        }
    }
}
