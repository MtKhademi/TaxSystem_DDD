using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Infra.Invoker
{
    public class DataCommandInvoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            this._command = command;
            Console.WriteLine($"Command {command.GetType().Name}");
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
