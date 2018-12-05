using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using TP2.modele;

namespace TP2.dao
{
    public class ProgrammeurDAO{
        public MySqlConnection Connexion { get; set; }

        public ProgrammeurDAO() { Connexion = new MySqlConnection("Server=localhost;Uid=root;Database=equipes;"); }
        public ProgrammeurDAO(String cnx){
            Connexion.ConnectionString = cnx;
        }

        public Programmeur FindByCourriel(String courriel) {
            modele.Programmeur programmeur = new Programmeur();
            
            Connexion.Open();
            string query = "SELECT col0,col1 FROM YourTable";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = Connexion;
            MySqlDataReader reader = cmd.ExecuteReader();

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()){
                programmeur.Courriel = dr.GetString("COURRIEL");
                programmeur.MotDePasse = dr.GetString("MOTDEPASSE");
                programmeur.Nom = dr.GetString("NOM");
                programmeur.Equipes = dr.GetString("EQUIPES");
            }
            Connexion.Close();
            return programmeur;
        }
    }
}