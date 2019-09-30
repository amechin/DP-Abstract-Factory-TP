﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTP
{
    interface IFabriqueVehicule
    {
        Automobile creeAutomobile(string modele, string couleur,
          int puissance, double espace);

        Scooter creeScooter(string modele, string couleur, int
          puissance);

        Scooter creeAvion(string modele, string couleur, int
          puissance, double capacite);
    }
}
