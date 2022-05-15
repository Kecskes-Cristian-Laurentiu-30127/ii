using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Product
    {
        [Key] //Primary Key
        public int id_P { get; set; }
        [Required]
        public string Nume { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Descriere { get; set; }
        //oreder_item list
        public List<Order_Item> Order_Item { get; set; }
        //shopping_cart_item list
        public List<Shopping_Cart_Item> Shopping_Cart_Item { get; set; }
        //tot ce ii in comm-uri din tutorial How To Make Foreign Keys
    }
}
