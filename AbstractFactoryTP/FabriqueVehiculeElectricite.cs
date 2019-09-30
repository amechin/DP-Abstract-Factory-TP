using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTP
{
    public class FabriqueVehiculeElectricite : IFabriqueVehicule
    {
        public Automobile creeAutomobile(string modele, string
          couleur, int puissance, double espace)
        {
            return new AutomobileElectricite(modele, couleur,
              puissance, espace);
        }

        public Scooter creeScooter(string modele, string
          couleur, int puissance)
        {
            return new ScooterElectricite(modele, couleur,
              puissance);
        }

        public Avion creeAvion(string modele, string
        couleur, int puissance, double capacite)
        {
            return new AvionElectricite(modele, couleur,
              puissance, capacite);
        }
    }
}
