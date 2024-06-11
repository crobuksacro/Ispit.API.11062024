using AutoMapper;
using Ispit.API.Context;
using Ispit.API.Model.Binding;
using Ispit.API.Model.Dbo;
using Ispit.API.Model.ViewModel;
using Ispit.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ispit.API.Services.Implementation
{
    public class ShoppingService : IShoppingService
    {
        private ApplicationDbContext db;
        private IMapper mapper;

        public ShoppingService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }


        public async Task<List<ShoppingItemViewModel>> GetShoppingItems()
        {
            var items = await db.ShoppingItems.ToListAsync();
            return items.Select(y => mapper.Map<ShoppingItemViewModel>(y)).ToList();
        }

        public async Task<ShoppingItemViewModel> GetShoppingItem(int id)
        {
            var item = await db.ShoppingItems.FindAsync(id);
            return mapper.Map<ShoppingItemViewModel>(item);
        }

        public async Task<ShoppingItemViewModel> AddShoppingItem(ShoppingItemBinding model)
        {
            var newItem = mapper.Map<ShoppingItem>(model);
            db.ShoppingItems.Add(newItem);
            await db.SaveChangesAsync();
            return mapper.Map<ShoppingItemViewModel>(newItem);
        }

        public async Task<ShoppingItemViewModel> UpdateShoppingItem(ShoppingItemUpdateBinding model)
        {
            var item = await db.ShoppingItems.FindAsync(model.Id);
            if (item == null)
            {
                return null;
            }

            mapper.Map(model, item);
            await db.SaveChangesAsync();
            return mapper.Map<ShoppingItemViewModel>(item);
        }

        public async Task<bool> DeleteShoppingItem(int id)
        {
            var item = await db.ShoppingItems.FindAsync(id);
            if (item == null)
            {
                return false;
            }

            db.ShoppingItems.Remove(item);
            await db.SaveChangesAsync();
            return true;
        }
    }
}
