using System;


namespace SaveTheOcean2.Models
{
    public class Persona
    {
        public string Name {  get; set; }
        public string? Rol {  get; set; }
        public int Xp { get; set; }
        
        public Persona(string name, string rol)
        {
            this.Name = name;
            this.Rol = rol;
            if (Rol == "Veterinari")
            {
                this.Xp = 80;
            }
            else
            {
                this.Xp = 45;
            }
            
        }
        

    }
}
