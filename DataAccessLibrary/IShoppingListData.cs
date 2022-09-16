using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IShoppingListData
    {
        Task<List<ShoppingListModel>> GetShoppingLists();
        Task InsertShoppingList(ShoppingListModel shoppingList);
        
    }
}