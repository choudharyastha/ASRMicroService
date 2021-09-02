using gateway.api.Models;
using Micro.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Command
{
    public class Broker
    {
       // private List<CommandData> commandsList = new List<CommandData>();
        List<Task<ASRJobTaskValue>> tasks = new List<Task<ASRJobTaskValue>>();
        public void ExecuteRule(CommandData command)
        {
            tasks.Add(command.command.execute(command.argument));
        }

        public async Task<ASRJobTaskValue[]> ExecuteCommandAsync()
        {
            var results = await Task.WhenAll(tasks);
            return results;
        }
    }
}
