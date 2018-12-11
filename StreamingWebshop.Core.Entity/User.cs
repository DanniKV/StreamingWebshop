using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingWebshop.Core.Entity
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        
        public string City { get; set; }
        
        public int ZipCode { get; set; }
        
        public Boolean IsAdmin { get; set; }
    }
}
