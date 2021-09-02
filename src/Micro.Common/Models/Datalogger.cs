using System;
using System.Collections.Generic;
using System.Text;

namespace Micro.Common.Models
{
    public class ASRJobTaskValue : Result
    {
        public ASRJobTaskValue (int JobId, int ContractId, int RuleId, Result results) : base()
        {
            this.JobId = JobId;
            this.ContractId = ContractId;
            this.Results = results;
            this.RuleId = RuleId;
        }
        public int JobId { get; set; }
        public int ContractId { get; set; }

        public int RuleId { get; set; }

        public Result Results { get; set; }
    }
}
