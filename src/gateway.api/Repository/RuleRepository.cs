using gateway.api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Rule = gateway.api.Models.Rule;

namespace gateway.api.Repository
{
    public class RuleRepository : GenericRepo<Rule>, IRuleRepo
    {
        public RuleRepository(Microcontext dbContext) : base(dbContext)
        {
        }
    }
}
