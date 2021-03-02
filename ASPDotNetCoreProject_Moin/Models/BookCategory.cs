using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDotNetCoreProject_Moin.Models 
{
    [Table("BookCategory")]
    public class BookCategory 
    {
        [Key]
        public long ID { get; set; }

        [Required, Display(Name = "Book Category")]
        public string Name { get; set; }

        public virtual IList<Books> Books { get; set; } 
    }
}
