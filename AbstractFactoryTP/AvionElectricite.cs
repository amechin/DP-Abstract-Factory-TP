using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTP
{
    public class AvionElectricite : Avion
    { 
        public AvionElectricite(string modele, string
            couleur, int puissance, double capacite) : base(modele,
            couleur, puissance, capacite)
        { }

        public override void afficheCaracteristiques()
        {
            Console.WriteLine(
                "Avion électrique de modèle : " + modele +
                " de couleur : " + couleur + " de puissance : " +
                puissance + " de capacite : " + capacite);
        }
    }

}
