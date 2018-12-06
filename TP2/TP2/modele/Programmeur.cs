using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP2.modele{
    public class Programmeur {
        public string Courriel { get; set; }
        public string Nom { get; set; }
        public string MotDePasse { get; set; }
        public string Equipe { get; set; }

        public Programmeur() { }
        public Programmeur(string c, string n, string m){
            Courriel = c;
            Nom = n;
            MotDePasse = m;
            Equipe = "";
        }
        public Programmeur(string c, string n, string m, string e) {
            Courriel = c;
            Nom = n;
            MotDePasse = m;
            Equipe = e;
        }
    }
}