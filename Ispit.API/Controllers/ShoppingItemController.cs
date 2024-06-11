using Ispit.API.Model.Binding;
using Ispit.API.Model.ViewModel;
using Ispit.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ispit.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingItemController : ControllerBase
    {
        private readonly IShoppingService shoppingService;

        public ShoppingItemController(IShoppingService shoppingService)
        {
            this.shoppingService = shoppingService;
        }
        /// <summary>
        /// Ja sam opis ove metode
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<ShoppingItemViewModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ShoppingItemViewModel>>> GetShoppingItems()
        {
            var result = await shoppingService.GetShoppingItems();

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ShoppingItemViewModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<ShoppingItemViewModel>> GetShoppingItems(ShoppingItemBinding model)
        {
            var result = await shoppingService.AddShoppingItem(model);

            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ShoppingItemViewModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<ShoppingItemViewModel>> GetShoppingItem(int id)
        {
            var result = await shoppingService.GetShoppingItems();

            return Ok(result);
        }

        [HttpPut]
        [ProducesResponseType(typeof(ShoppingItemViewModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<ShoppingItemViewModel>> UpdateShoppingItem(ShoppingItemUpdateBinding model)
        {
            var result = await shoppingService.UpdateShoppingItem(model);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteShoppingItem(int id)
        {
            await shoppingService.DeleteShoppingItem(id);

            return Ok();
        }


    }
}
