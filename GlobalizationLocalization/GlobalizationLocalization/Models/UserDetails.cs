using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GlobalizationLocalization.LocalResources;

namespace GlobalizationLocalization.Models
{
    public class UserDetails
    {
        [Display(Name = "Username", ResourceType = typeof(Resource))]
        public string Username { get; set; }

        [Display(Name = "Firstname", ResourceType = typeof(Resource))]
        public string Firstname { get; set; }

        [Display(Name = "Surname", ResourceType = typeof(Resource))]
        public string Surname { get; set; }
    }
}