using System;

namespace StreamingWebshop.Core.Entity
{
    public class UserInput
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
        
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        
        public string City { get; set; }
        
        public int ZipCode { get; set; }

        public Boolean IsAdmin { get; set; }
    }
}