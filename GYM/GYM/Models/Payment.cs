using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GYM.Models
{
    public class Payment
    {
        [Key]
        public int PayId { get; set; }
        public decimal Dues { get; set; } //aidat
        public DateTime? DuesTime { get; set; }
        public string TCNo { get; set; }

        //[ForeignKey("Student")]
        //public int StudentID { get; set; }

        //public virtual Student Student { get; set; }
    }
}