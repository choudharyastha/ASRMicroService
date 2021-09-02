using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Models
{
    public class Rule 
    {
        
        
        [Key]
        public int TaskId { get; set; }

        [ForeignKey("JobId")]
        public int JobId { get; set; }

        public int RuleId { get; set; } 

        public virtual Job job { get; set; }


    }
}
