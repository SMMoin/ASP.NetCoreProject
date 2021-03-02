using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;


namespace ASPDotNetCoreProject_Moin.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required]
        
        public string Name { get; set; }


        public string Address { get; set; }


        [Required]
        public string CellPhone { get; set; }  


        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string UrlImage { get; set; }

        [NotMapped]
        public IFormFile ImageUrl { get; set; }

    }
}
