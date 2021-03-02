using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using ASPDotNetCoreProject_Moin.MoinValidation;

namespace ASPDotNetCoreProject_Moin.ViewModels 
{
    public class TeacherViewModel:EditImageViewModel 
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        [MoinValidation]
        public string TeacherName { get; set; } 

        [Required]
        [StringLength(100)]
        public string Designation { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        
        public string ContactNo { get; set; }

        public string Email { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }

      


      
    }
}
