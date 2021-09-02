using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Models
{
    public class Job
    {
        
        [Key]
        public int JobId { get; set; }

        public string ContractId { get; set; }

        public string Status { get; set; }

        public DateTime PeriodEndDate { get; set; }

        public virtual ICollection<Rule> Rules { get; set; }

    }
}
