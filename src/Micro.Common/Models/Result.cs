using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Micro.Common.Models
{
    public class Result
    {

        public Result()
        {
            this.StepDescription = new List<StepDescription>();
        }

        public ICollection<StepDescription> StepDescription { get; set; }

        public bool Status { get; set; }
    }
}
