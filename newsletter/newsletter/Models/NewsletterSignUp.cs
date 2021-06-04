using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newsletter.Models
{
    public class NewsletterSignUp // a model is always singular a business object and models is a list
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}