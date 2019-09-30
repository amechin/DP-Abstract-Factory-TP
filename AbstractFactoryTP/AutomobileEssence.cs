﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTP
{
    public class AutomobileEssence : Automobile
    {
        public AutomobileEssence(string modele, string couleur,
          int puissance, double espace) : base(modele, couleur,
          puissance, espace)
        { }

        public override void afficheCaracteristiques()
        {
            Console.WriteLine("Automobile à essence de modèle : "
              + modele + " de couleur : " + couleur +
              " de puissance : " + puissance + " d’espace : " +
              espace);
        }
    }
}
