using Ispit.API.Model.Binding;
using Ispit.API.Model.ViewModel;

namespace Ispit.API.Services.Interfaces
{
    public interface IShoppingService
    {
        Task<ShoppingItemViewModel> AddShoppingItem(ShoppingItemBinding model);
        Task<bool> DeleteShoppingItem(int id);
        Task<ShoppingItemViewModel> GetShoppingItem(int id);
        Task<List<ShoppingItemViewModel>> GetShoppingItems();
        Task<ShoppingItemViewModel> UpdateShoppingItem(ShoppingItemUpdateBinding model);
    }
}