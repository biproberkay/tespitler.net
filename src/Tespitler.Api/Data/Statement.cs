using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tespitler.Api.Data
{
    public class Statement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name ="Entry")]
        [StringLength(450, ErrorMessage ="Girdiğin Entry 450 karakterden uzun olmamalı!")]
        public string Entry { get; set; }
    }
}
