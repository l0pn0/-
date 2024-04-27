using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пицца
{
    internal class PizzaAdd : MainWindow
    {
        public string Name { get; set; } = "";
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}  Price: {Price}";
        }
    }
}
