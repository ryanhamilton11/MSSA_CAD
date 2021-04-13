using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class ProductListViewModel// Data Transfer Object - DTO
    {
        //FIELDS & PROPERTIES
        public IQueryable<Product> Products { get; set; }

        public PagingInfo PagingInformation { get; set; }

        //CONSTRUCTORS



        //METHODS


    }

}
