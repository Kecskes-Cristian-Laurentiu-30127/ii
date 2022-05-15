using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Client
    {
        [Key] //Primary Key
        public int id_C{ get; set; }
        [Required]
        public string Nume { get; set; }
        [Required]
        public int Varsta { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public DateTime SignUpDate { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        //lista de orders
        public List<Order> Orders { get; set; }

        //Shoping_Cart fk [Index(IsUnique=true)]
        public int Shopping_CartId { get; set; }
        [ForeignKey("Shoping_CartId")]
        public Shopping_Cart Shopping_Cart { get; set; }
    }
}
