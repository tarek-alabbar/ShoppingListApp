﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ShoppingListModel
    {
        public int Id;
        public string Name { get; set; }
        public int UserId { get; set; }
    }
}
