using AssetsSystem.Interfaces;

namespace AssetsSystem.Infra
{
    public class Composit : ICustomComponent
    {

        List<ICustomComponent> _children = new List<ICustomComponent>();
        public string Name { get; set; }

        public Composit(string name)
        {
            Name = name;
        }

        public void AddComponent(ICustomComponent component)
        {
            _children.Add(component);
        }

        public decimal CalculatePrice()
        {
            decimal price = 0;
            foreach (var child in _children)
            {
                price += child.CalculatePrice();
            }

            return price;
        }
    }
}
