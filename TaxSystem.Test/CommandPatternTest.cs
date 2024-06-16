using CommandPattern.Data;
using CommandPattern.Infra.Commands;
using CommandPattern.Infra.Invoker;
using FluentAssertions;

namespace TaxSystem.Test
{
    public class CommandPatternTest
    {
        [Fact]
        public void Should_create_UpsertCommand_Expect_doing_well()
        {

            var dataReceiver = new DataReceiver();
            var invoker = new DataCommandInvoker();
            invoker.SetCommand(new UpsertCommand("mt.khademi", "name", dataReceiver));

            invoker.ExecuteCommand();

            dataReceiver.GetCount().Should().Be(1);
        }
    }
}
