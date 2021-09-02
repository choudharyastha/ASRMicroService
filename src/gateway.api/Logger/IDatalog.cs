using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Logger
{
    interface IDatalog
    {
        public Task<ActionResult> AddToLog();
    }
}
