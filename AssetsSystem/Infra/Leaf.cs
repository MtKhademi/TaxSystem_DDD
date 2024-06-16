using AssetsSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsSystem.Infra
{
    public class Leaf : ICustomComponent
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Leaf(string name,decimal price)
        {
            Name = name;
            Price = price;
        }
        public void AddComponent(ICustomComponent component)
        {
            throw new NotImplementedException();
        }

        public decimal CalculatePrice()
        {
            return Price;
        }
    }
}
