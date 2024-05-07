using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean2.Models
{
    public abstract class AAnimal
    {
        public string? SuperFamily { get; set; }
        public string? Name { get; set; }
        public string? Breed { get; set; }
        public float? Weight { get; set; }
        public AAnimal(string? name, string? breed, float? weight)
        {
            Name = name;
            Breed = breed;
            Weight = weight;
        }
        /// <summary>
        /// Mètode que retorna el grau d'afectació després del tractament
        /// </summary>
        /// <param name="GA">S'utilitza per a la formula</param>
        /// <param name="x">S'utilitza per a la formula</param>
        /// <returns>Retorna el nou GA</returns>
        public abstract int CalcGA(double GA, int x) ;
    }
}
