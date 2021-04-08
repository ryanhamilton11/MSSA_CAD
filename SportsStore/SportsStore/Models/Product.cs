using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

//ENTITY FRAMEWORK - CODE FIRST
namespace SportsStore.Models
{
    [Table("Product")]
    public class Product
    {
        //FIELDS & PROPERTIES
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal (8, 2")] //8 total digits, 2 of which are the fraction/decimal.
        public decimal Price { get; set; }
        public string Category { get; set; }


        //CONSTRUCTORS


        //METHODS
    }
}
