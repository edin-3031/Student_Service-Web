using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class LoginVM
    {
        [StringLength(100,ErrorMessage ="Korisničko ime mora imati najmanje 5 karaktera", MinimumLength =5)]
        public string Username { get; set; }
        [StringLength(100,ErrorMessage ="Šifra mora imati najmanje 5 karaktera",MinimumLength =5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
