using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean2.Models
{
    public class Au : AAnimal
    {
        public Au(string name, string breed, float weight): base(name,breed,weight) { this.SuperFamily = "Au Marina"; }
        public override int CalcGA(double GA, int x)
        {
            return Convert.ToInt32((GA - x) / 5);
        }
        public override string ToString()
        {
            return $"{Breed}";
        }
    }
}
