using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Order
    {
        [Key] //Primary Key
        public int Quantity{ get; set; }
        /*
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime ShippedDate { get; set; }
        [Required]
        public float TotalPrice { get; set; }
        [Required]
        public string Adress { get; set; }
        */
        /*
        Client fk
        [ForeignKey("Client")]
        */
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        /*
        public Client Client { get; set; }
        //lista order_item
        public List<Order_Item> Order_Item { get; set; }*/

    }
}