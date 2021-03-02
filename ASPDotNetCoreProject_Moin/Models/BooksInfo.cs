using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPDotNetCoreProject_Moin.Models 
{
    public class BooksInfo
    {
        [Key]
        public int BookId { get; set; } 

        
        [DisplayName("Author ID")]
        
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only")]
        public string AuthorNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Book Name")]
        [Required(ErrorMessage = "Please input Book name")]
        public string BookName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Author Name")]
        [Required(ErrorMessage = "Please input Author name")]
        public string AuthorName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("ISB Code")]
        [Required(ErrorMessage = "please input your ISB code.")]
        [MaxLength(11)]
        public string ISBCode { get; set; }

        [DisplayName("Book Price")]
        [Required(ErrorMessage = "This Field is Required.")]
        public int Price { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime PublishingDate { get; set; } 
    }
}
