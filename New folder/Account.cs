using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Account
    {
        [Key] //Primary Key
        public int Id_A { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        //Client_ID fk [Index(IsUnique=true)]
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        /*public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }*/
    }
}
