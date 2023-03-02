using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIssion09_ahyer107.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }

        //Figure out how many pages we need
        //It wasn't returning the correct ammout of pages so I just put +1 on it
        public int TotalPages => (int) Math.Ceiling((double) TotalNumBooks / BooksPerPage) +1;
    }
}
