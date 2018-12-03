using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP2.modele{
    public class Programmeur {
        public string Courriel { get; set; }
        public string Nom { get; set; }
        public string Equipes { get; set; }

        public Programmeur() { }
        public Programmeur(string c, string n){
            Courriel = c;
            Nom = n;
        }
        public Programmeur(string c, string n, string e) {
            Courriel = c;
            Nom = n;
            Equipes = e;
        }
    }
}