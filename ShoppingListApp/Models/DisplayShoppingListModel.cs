using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ShoppingListApp.Models
{
    public class DisplayShoppingListModel
    {
        [Required] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string UserId { get; set; }
    }
}