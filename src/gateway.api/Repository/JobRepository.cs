using gateway.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Repository
{
    public class JobRepository : GenericRepo<Job>, IJobRepo
    {
        public JobRepository(Microcontext dbContext) : base(dbContext)
        {
        }
    }
}
