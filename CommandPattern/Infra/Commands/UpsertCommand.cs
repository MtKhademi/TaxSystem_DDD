using CommandPattern.Data;

namespace CommandPattern.Infra.Commands
{
    public class UpsertCommand : Command
    {
        private string key;
        private string value;

        public UpsertCommand(string value, string key, DataReceiver dataReceiver) : base(dataReceiver)
        {
            this.value = value;
            this.key = key;
        }

        public override void Execute()
        {
            _receiver.Upsert(key, value);
        }
    }
}
