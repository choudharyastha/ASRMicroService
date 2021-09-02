using System;
using System.Collections.Generic;
using System.Text;

namespace Micro.Common.Models
{
    public class StepDescription
    {
        public StepDescription(string Description, bool status)
        {
            this.Description = Description;
            this.Status = status;
        }
        public string Description { get; set; }

        public bool Status { get; set; }

    }
}
