using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Suleyman.Bussines.Abstract;
using Suleyman.Entities.Concrete;
using Suleyman.WebUI.Models;
using Suleyman.WebUI.Session;


namespace Suleyman.WebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService cartSession;
        private ICartService cartService;
        private IProductService productService;

        public CartController(ICartSessionService _cartSession, ICartService _cartService, IProductService _productService)
        {
            cartService = _cartService;
            cartSession = _cartSession;
            productService = _productService;
        }
        public ActionResult AddToCart(int productid)
        {
            var EklenenProduct = productService.GetById(productid);
            var cart = cartSession.GetCart();

            cartService.AddToCart(cart,EklenenProduct);

            cartSession.SetCart(cart);
            TempData.Add("mesage", "urun eklendı");

            return RedirectToAction("index","Product");
            
        }
        public ActionResult List()
        {
            var cart = cartSession.GetCart();
            CartSummeryViewModel model = new CartSummeryViewModel
            {
                Cart = cart
            };

            return View(model);
        }

        public ActionResult Remove(int productid)
        {
            var cart = cartSession.GetCart();
            cartService.Remove(cart, productid);
            cartSession.SetCart(cart);

            TempData.Add("mesage", "urun Silindi");
            return RedirectToAction("List");
        }
        public ActionResult Complete()
        {
            ShippingDetailsViewModel model = new ShippingDetailsViewModel
            {
                ShippingDetails =new ShippingDetails()
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("mesage", String.Format("Urun Siparişi Tamamlandı. {0}", shippingDetails.FirstName));
            return View();

        }
    }
}