using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_15
{
    public class Contact
    {
        public string Name { get; set; }
        
        public long Phone { get; set; }

        public string Email { get; set; }

        public Contact(string name, long phone, string email) 
        { 
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }
    }

    
}
