using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDotNetCoreProject_Moin.Models 
{
    [Table("Books")]
    public class Books 
    {
        [Key]
        public long ID { get; set; }

        [Required, Display(Name = "Book Name")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] BookImage { get; set; } 

        [DataType(DataType.Date)]

        public DateTime PublishedDate { get; set; } 

        [Required]
        public long Quantity { get; set; }

        [ForeignKey("BookCategory")]
        public long BookCategoryID { get; set; } 


        public virtual BookCategory BookCategory { get; set; } 
    }
}
