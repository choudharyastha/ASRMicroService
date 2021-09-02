using gateway.api.Command;
using Micro.Common.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
namespace gateway.api.NewServices
{
    public class Rule2Service: ICommand
    {
        private static readonly HttpClient client = new HttpClient();

        public Rule2Service()
        {
        }
        public async Task<ASRJobTaskValue> execute(Argument argument)
        {
            var request_rule_2 = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5051");
            var response = await client.SendAsync(request_rule_2);
            var result = JsonConvert.DeserializeObject<Result>(response.Content.ReadAsStringAsync().Result);
            var _datalogger = new ASRJobTaskValue(argument.JobId, argument.ContractId, argument.RuleId, result);
            return _datalogger;

        }
    }
}
