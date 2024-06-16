using AssetsSystem.Infra;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxSystem.Test
{
    public class AssetSystemTest
    {
        [Fact]
        public void Should_composite_object_Expect_get_currect_price_it()
        {

            //ARRANGE
            var cpu = new Leaf("CPU", 10);
            var harddisk = new Leaf("Hard Disk", 10);
            var computer = new Composit("computer");
            computer.AddComponent(cpu);
            computer.AddComponent(harddisk);

            //ACT
            var resultPrice = computer.CalculatePrice();

            //ASSERT
            resultPrice.Should().Be(20);

        }
    }
}
