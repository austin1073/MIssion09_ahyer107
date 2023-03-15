using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIssion09_ahyer107.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get; }

        void SavePurchase(Purchase purchase);
    }
}
