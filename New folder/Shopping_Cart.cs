using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Shopping_Cart
    {
        [Key] //Primary Key
        public int id_S { get; set; }
        //list s_c_i
        public List<Shopping_Cart_Item> Shopping_Cart_Item { get; set; }
    }
}
