using AutoMapper;
using Ispit.API.Model.Binding;
using Ispit.API.Model.Dbo;
using Ispit.API.Model.ViewModel;

namespace Ispit.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ShoppingItem, ShoppingItemViewModel>();
            CreateMap<ShoppingItemBinding, ShoppingItem>();
            CreateMap<ShoppingItemUpdateBinding, ShoppingItem>();
        }
    }
}
