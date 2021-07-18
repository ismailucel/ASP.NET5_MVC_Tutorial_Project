using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky_Tutorial.Models
{
    public class ApplicationType //table
    {
        //columns
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       
    }
}
