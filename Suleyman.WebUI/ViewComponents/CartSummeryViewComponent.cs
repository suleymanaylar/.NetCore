using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Suleyman.Bussines.Abstract;
using Suleyman.WebUI.Models;
using Suleyman.WebUI.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suleyman.WebUI.ViewComponents
{
    public class CartSummeryViewComponent : ViewComponent
    {
        private ICartSessionService cartService;

        public CartSummeryViewComponent(ICartSessionService _cartService)
        {
            cartService = _cartService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummeryViewModel
            {
                Cart =cartService.GetCart()
            };

            return View(model);
        }
    }
}
