using Suleyman.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suleyman.Bussines.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart,Product product);
        void Remove(Cart cart, int productid);
        List<CartLine> List(Cart cart);
    }
}
