using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class PagingInfo
    {
        //FIELDS & PROPERTIES

        public int TotalItems { get; set; }

        public int ItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        //CONSTRUCTORS



        //METHODS
        public int TotalPages =>
           (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);

    }
}
