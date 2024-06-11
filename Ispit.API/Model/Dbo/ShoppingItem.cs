using Ispit.API.Model.Base;
using System.ComponentModel.DataAnnotations;

namespace Ispit.API.Model.Dbo
{
    public class ShoppingItem: ShoppingItemBase
    {
        [Key]
        public int Id { get; set; }
    }
}
