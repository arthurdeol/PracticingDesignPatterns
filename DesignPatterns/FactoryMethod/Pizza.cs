using System.Collections;
using System.Text;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected string Name { get; set; }
        protected string pasta;
        protected string sauce;
        protected ArrayList ingredients = new ArrayList();

        public string Preparar()
        {
            var sb = new StringBuilder();
            sb.Append($"Preparing {Name}\n");
            sb.Append($"{pasta}\n");
            sb.Append($"{sauce}\n");
            sb.Append("Ingredients :\n");
            foreach(var ingredient in ingredients)
            {
                sb.Append($"\t{ingredient}\n");
            }
            sb.Append(Bake());
            sb.Append(Slice());
            sb.Append(Pack());
            return sb.ToString();
        }
        public virtual string Bake()
        {
            return "Bake for 25 minutes at 350 degrees\n";
        }
        public virtual string Slice()
        {
            return "Slice the pizza into 8 pieces\n";
        }
        public virtual string Pack()
        {
            return "Pack with official packaging\n";
        }

    }
}
