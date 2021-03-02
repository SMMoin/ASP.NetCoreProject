using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDotNetCoreProject_Moin.Models 
{
    public class SpecialCourse 
    {
        [Key]
        public int CourseID { get; set; }


        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Must Be Filled")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be 3-30 char")]
        public string CourseName { get; set; }

        [Display(Name = "Course Duration")]
        [Required(ErrorMessage = "Must Be Filled")]
        public string CourseDuration { get; set; }

        [Display(Name ="Course Fee")]
        [Required]
        public int Fee { get; set; }
       
        [Display(Name ="Starting Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:MMM dd, yyyy}", ApplyFormatInEditMode = false)]
        public DateTime StartingDate { get; set; }

        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
