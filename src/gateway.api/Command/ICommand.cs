using Micro.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Command
{
    public interface ICommand
    {
        Task<ASRJobTaskValue> execute(Argument argument);
    }
}
