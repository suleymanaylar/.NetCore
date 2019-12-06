using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Suleyman.Entities.Concrete;
using Suleyman.WebUI.ExtensionMethod;

namespace Suleyman.WebUI.Session
{
    public class CartSessionService : ICartSessionService
    {
        private IHttpContextAccessor _contextAccessor;

        public CartSessionService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public Cart GetCart()
        {
            Cart checkToCart = _contextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (checkToCart==null)
            {
                _contextAccessor.HttpContext.Session.SetObject("cart",new Cart());
                checkToCart= _contextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return checkToCart;
        }

        public void SetCart(Cart cart)
        {
            _contextAccessor.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
