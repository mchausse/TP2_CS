using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TP2.modele;

namespace TP2.dao
{
    public class EquipeDAO
    {
        public MySqlConnection Connexion { get; set; }

        public EquipeDAO() { 
            Connexion = new MySqlConnection("Server=localhost;Uid=root;Pwd=;Database=equipes;"); 
        }

        public EquipeDAO(string cnx)
        {
            Connexion.ConnectionString = cnx;
        }
        public Equipe FindByNom(string nom)
        {
            try{
                // Start la connexion
                Connexion.Open();

                //Requete
                string requete = "SELECT * FROM programmeur WHERE NOM = '" + nom + "'";
                MySqlCommand cmd = new MySqlCommand(requete);
                cmd.Connection = Connexion;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Equipe e = new Equipe();
                    e.Nom = dr.GetString("NOM");
                    e.Description = dr.GetString("NOM");
                    return e;
                }
                return null;
            }
            catch (Exception e) { return null; }
            finally
            {
                if (Connexion.State != ConnectionState.Closed)
                {
                    // Ferme la connexion
                    Connexion.Close();
                }
            }
        }
    }
}