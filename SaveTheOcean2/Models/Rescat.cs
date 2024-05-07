
using SaveTheOcean2;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean2.Models
{
    public class Rescue
    {
        public string IdRescue {  get; set; }
        public DateTime Date { get; set;}
        public string Location { get; set; }
        public int GA {  get; set; }
        public AAnimal Animal { get; set; }

        public Rescue()
        {
            this.IdRescue = "RES" + Helper.Random(0, 999);
            this.Date = DateTime.Now;
            this.Location = "Barcelona";
            this.GA = Helper.Random(1,99);
            int animalRandom = Helper.Random(1, 3);
            if ( animalRandom== 1)
            {
                this.Animal = new Au("Kaka ", "Caulonectris Leucomelas", 10.2f);
            }
            else if ( animalRandom== 2)
            {
                this.Animal = new Tortuga("Omola", "Chelonioidea", 20.5f);
            }
            else
            {
                this.Animal = new Cetaci("Patri",  "Tursiops truncatus", 58.3f);
            }
            
        }
        /// <summary>
        /// Mètode que escriu en pantalla la informació del rescat
        /// </summary>
        public void GetRescat()
        {
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("|                            RESCAT                             |");
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("| #Rescat | Data Rescat | Superfamília   | GA | Localització    |");
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine($"|  {this.IdRescue} | {this.Date}\t| {this.Animal.SuperFamily} | {this.GA} | {this.Location}       |");
            Console.WriteLine("+---------------------------------------------------------------+");
        }
        /// <summary>
        /// Mètode que escriu en pantalla la fitxa de l'animal
        /// </summary>
        public void GetFitxa()
        {
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("|                             FITXA                             |");
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("| #Nom   | Superfamília   | Espècie                 | Pes Aprox |");
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine($"| {this.Animal.Name}  | {this.Animal.SuperFamily} | {this.Animal.Breed} | {this.Animal.Weight}      |");
            Console.WriteLine("+---------------------------------------------------------------+");
        }
        /// <summary>
        /// Mètode que retorna si el resultat de la cura ha estat positiu o no
        /// </summary>
        /// <param name="option">Parametre que marca si el tractament s'ha fet al lloc del rescat o al centre CRAM</param>
        /// <returns>Retorna una string dient els resultats del tractament</returns>
        public string Cura(int option)
        {
            int x;
            if (this.Animal.SuperFamily== "Cetaci        ")
            {
                if (option == 1) { x = 25; }
                else { x = 0; }
                GA=Animal.CalcGA(this.GA, x);
            }
            else if (this.Animal.SuperFamily == "Au Marina     ")
            {
                if (option == 1) { x = 5; }
                else { x = 0; }
                GA=Animal.CalcGA(this.GA, x);
            }
            else if (this.Animal.SuperFamily == "Tortuga marina")
            {
                x = 5;
                GA=Animal.CalcGA(this.GA, x);
            }
            
            if (option == 1)
            {
                return GA < 5 ? $"El tractament aplicat ha reduït el GA fins al {GA}. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP." : $"El tractament aplicat ha reduït el GA fins al {GA}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.";
            }
            else
            {
                return GA < 5 ? $"El tractament aplicat ha reduït el GA fins al {GA}. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP." : $"El tractament aplicat ha reduït el GA fins al {GA}%. No ha estat prou efectiu. La teva experiència s’ha reduït en -20XP.";
            }
            
        }
    }
}
