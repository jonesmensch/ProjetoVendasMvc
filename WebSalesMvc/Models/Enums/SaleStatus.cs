using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSalesMvc.Models.Enums
{
    public enum SaleStatus : int
    {
        Pending, 
        Billed,
        Canceled
    }
}
