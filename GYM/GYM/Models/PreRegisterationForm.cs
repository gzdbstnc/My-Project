using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GYM.Models
{
    public class PreRegisterationForm
    {
        [Key]
        public int PreID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Branches { get; set; }
        public string Facilities { get; set; }
        public TimeSpan? Session { get; set; }
        public string Coach { get; set; }
        public string Phone { get; set; }

        //public virtual Student Student { get; set; }
    }
}