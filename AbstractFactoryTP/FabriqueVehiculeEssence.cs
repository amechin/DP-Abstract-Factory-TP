using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTP
{
    public class FabriqueVehiculeEssence : IFabriqueVehicule
    {
        public Automobile creeAutomobile(string modele, string
          couleur, int puissance, double espace)
        {
            return new AutomobileEssence(modele, couleur,
              puissance, espace);
        }

        public Scooter creeScooter(string modele, string
          couleur, int puissance)
        {
            return new ScooterEssence(modele, couleur, puissance);
        }

        public Avion creeAvion(string modele, string
        couleur, int puissance, double capacite)
        {
            return new AvionEssence(modele, couleur,
              puissance, capacite);
        }
    }
}
