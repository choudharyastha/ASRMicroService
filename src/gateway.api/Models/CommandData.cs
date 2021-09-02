using gateway.api.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Models
{
    public class CommandData
    {
        public CommandData(Argument argument, ICommand command)
        {
            this.argument = argument;
            this.command = command;
        }

        public Argument argument { get; set; }

        public ICommand command { get; set; }

    }
}
