using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using ASPDotNetCoreProject_Moin.MoinValidation;

namespace ASPDotNetCoreProject_Moin.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

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

        //[Required]
        //[DataType(DataType.Date)]
        //[Display(Name = "Written Date")]
        //[TodayAttribute]
        public string ContactNo { get; set; }

        public string Email { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }

     
      

        [Required]
        [Display(Name = "Image")]
        public string ProfilePicture { get; set; }
    }
}
