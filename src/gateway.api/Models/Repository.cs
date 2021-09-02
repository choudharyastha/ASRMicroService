using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Models
{
    public class Repository
    {
        
        public List<Job> GetJobs()
        {

            var context = new Microcontext();
            return context.Job.ToList();
                                             
        }

        public List<Rule> GetRules()
        {

            var context = new Microcontext();
            return context.Rule.ToList();

        }
    }
}

