using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIssion09_ahyer107.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
