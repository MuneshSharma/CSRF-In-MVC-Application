using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSRFInMVCApplication.Models
{
    public class CollageInfo
    {
        [Key]
        public int CollageID { get; set; }
        [Required(ErrorMessage = " please Enter Name")]
        public string CollageName { get; set; }
        [Required(ErrorMessage = "pleaes Enter Address")]
        public string CollageAddress { get; set; }
        [Required(ErrorMessage = "please Enter Department")]
        public string CollageDepartment { get; set; }

    }
}