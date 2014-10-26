using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC01.Models
{
    public class ContactUser
    {
        public String firstName {get; set;}
        public String lastName { get; set; }
        public String eMail { get; set; }
        public DateTime dateOfBirth { get; set; }
    }
}