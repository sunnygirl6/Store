﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Store.Core.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Product> Products { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
