using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Logger
{
    public class Datalog : IDatalog
    {
        public int JobId { get; set; }

        public int ContractId { get; set; }

        public int RuleId { get; set; }

        public string status { get; set; }
        public Datalog()
        {

        }
        public Datalog (int JobId, int RuleId, int ContractId, string status)
        {
            this.JobId = JobId;
            this.RuleId = RuleId;
            this.status = status;
            this.ContractId = ContractId;
        }
        public ICollection<Datalog> list { get; set; }

        public Task<ActionResult> AddToLog()
        {
            throw new NotImplementedException();
        }
    }
}
