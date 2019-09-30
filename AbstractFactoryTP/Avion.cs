using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTP
{
    public abstract class Avion
    {
        protected string modele;
        protected string couleur;
        protected int puissance;
        protected double capacite;

        public Avion(string modele, string couleur, int puissance, double capacite)
        {
            this.modele = modele;
            this.couleur = couleur;
            this.puissance = puissance;
            this.capacite = capacite;
        }

        public abstract void afficheCaracteristiques();
    }
}
