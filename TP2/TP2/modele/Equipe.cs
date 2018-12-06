using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP2.modele
{
    public class Equipe
    {
        public string Nom { get; set; }
        public string Description { get; set; }

        public Equipe() { }
        public Equipe(string n, string d) {
            Nom = n;
            Description = d;
        }
    }
}