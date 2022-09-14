using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class ShoppingListData : IShoppingListData
    {
        private readonly ISqlDataAccess _db;

        public ShoppingListData(ISqlDataAccess db)
        {
            _db = db;
        }
        
        public Task<List<ShoppingListModel>> GetShoppingLists()
        {
            string sql = "SELECT * FROM Master.ShoppingList";
            return _db.LoadData<ShoppingListModel, dynamic>(sql, new { });
        }

        public Task InsertShoppingList(ShoppingListModel shoppingList)
        {
            throw new NotImplementedException();
        }
    } 
}
