using gateway.api.Command;
using Micro.Common.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace gateway.api.NewServices
{
    public class Rule3Service : ICommand
    {
        private static readonly HttpClient client = new HttpClient();

        public Rule3Service ()
        {
        }
        public async Task<ASRJobTaskValue> execute(Argument argument)
        {
            var request_rule_3 = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5052");
            var response = await client.SendAsync(request_rule_3);
            var result = JsonConvert.DeserializeObject<Result>(response.Content.ReadAsStringAsync().Result);
            var _datalogger = new ASRJobTaskValue(argument.JobId, argument.ContractId, argument.RuleId, result);
            return _datalogger;

        }
    }
}
