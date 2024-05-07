using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean2.Models
{
    public class Tortuga : AAnimal
    {
        public Tortuga(string name, string breed, float weight) : base(name, breed, weight) { this.SuperFamily = "Tortuga marina"; }
        public override int CalcGA(double GA, int x)
        {
            return Convert.ToInt32((2*GA + 3) - ((GA - 20)*2) -x);
        }
        public override string ToString()
        {
            return $"{Breed}";
        }
    }
}
