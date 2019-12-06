using Suleyman.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suleyman.WebUI.Session
{
   public interface ICartSessionService
    {
        void SetCart(Cart cart);
        Cart GetCart();
    }
}
