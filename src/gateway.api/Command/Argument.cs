using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Command
{
    public class Argument
    {
        public Argument(int jobId, int contractId, int ruleId)
        {
            JobId = jobId;
            ContractId = contractId;
            RuleId = ruleId;
        }

        public int JobId { get; set; }

        public int ContractId { get; set; }

        public int RuleId { get; set; }
    }
}
