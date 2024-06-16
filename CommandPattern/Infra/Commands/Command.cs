using CommandPattern.Data;
using CommandPattern.Interfaces;

namespace CommandPattern.Infra.Commands
{
    public abstract class Command : ICommand
    {
        protected DataReceiver _receiver;
        public Command(DataReceiver dataReceiver)
        {
            _receiver = dataReceiver;
        }
        public abstract void Execute();
    }
}
