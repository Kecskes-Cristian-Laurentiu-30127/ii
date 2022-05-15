using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Shopping_Cart_Item
    {
        [Key] //Primary Key
        public int id_SCI { get; set; }
        [Required]
        public string Quantity { get; set; }
        //Product_id_p fk
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        //shopping_card_id_sc fk
        public int Shopping_CartId { get; set; }
        [ForeignKey("Shopping_CartId")]
        public Shopping_Cart Shopping_Cart { get; set; }

    }
}
