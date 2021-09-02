using gateway.api.Command;
using gateway.api.Models;
using gateway.api.NewServices;
using gateway.api.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api
{
    public class Start : IStart
    {
        private readonly IRuleRepo _rulesRepo;
        private readonly IJobRepo _jobRepo;

        public Start(IRuleRepo rulesRepo, IJobRepo jobRepo)
        {
            _rulesRepo = rulesRepo;
            _jobRepo = jobRepo;
        }


        public Start()
        {
        }

        public async void fetchdata()
        {

            Rule1Service executerule1 = new Rule1Service();
            Rule2Service executerule2 = new Rule2Service();
            Rule3Service executerule3 = new Rule3Service();

            Broker broker = new Broker();

            var jobList = _jobRepo.ListAll();
            var ruleList = _rulesRepo.ListAll();
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            foreach (var job in jobList)
            {
                var rules = ruleList.Where(x => x.JobId == job.JobId).ToList();

                foreach (var rule in rules)
                {
                    switch (rule.RuleId)
                    {
                        case 1:
                            broker.ExecuteRule(new CommandData(new Argument(job.JobId, Convert.ToInt32(job.ContractId), rule.RuleId), executerule1));

                            break;

                        case 2:
                            broker.ExecuteRule(new CommandData(new Argument(job.JobId, Convert.ToInt32(job.ContractId), rule.RuleId), executerule2));
                            break;

                        case 3:
                            broker.ExecuteRule(new CommandData(new Argument(job.JobId, Convert.ToInt32(job.ContractId), rule.RuleId), executerule3));
                            break;
                    }
                }
               

                
            }
            var results = await broker.ExecuteCommandAsync();
            Console.WriteLine("The application ended at {0:HH:mm:ss.fff}", DateTime.Now);
            foreach (var result in results)
            {
                foreach (var step in result.Results.StepDescription)
                {
                    Console.Write(result.JobId + "\t");
                    Console.Write(result.ContractId + "\t");
                    Console.Write(result.RuleId + "\t");
                    Console.Write(step.Description + "\t");
                    Console.WriteLine(step.Status + "\t");
                }
                Console.Write(result.Results.Status);
                Console.WriteLine();

            }

        }
    }

    
      
}
