using System;
using Microsoft.AspNetCore.Identity;

namespace CalisanBilgi.Data.DbModel
{
   public class Employe:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxNo { get; set; }
        public DateTime DateOfBirth { get; set; }


    }
}
