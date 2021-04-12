using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models.ViewModels
{
    public class ProductListViewModel
    {
        //FIELDS & PROPERTIES

        public IEnumerable<Product> Products { get; set; }

        public PagingInfo PagingInfo { get; set; }

        //CONSTRUCTORS



        //METHODS


    }

}
