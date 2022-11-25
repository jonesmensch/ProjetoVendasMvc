using System.Collections.Generic;
using WebSalesMvc.Data;
using WebSalesMvc.Models;
using System.Linq;

namespace WebSalesMvc.Services
{
    public class SellerService
    {
        private readonly WebSalesMvcContext _context;

        public SellerService(WebSalesMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
