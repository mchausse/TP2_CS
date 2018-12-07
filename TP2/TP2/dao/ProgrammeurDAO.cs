using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using TP2.modele;
using System.Data;

namespace TP2.dao
{
    public class ProgrammeurDAO
    {
        public MySqlConnection Connexion { get; set; }

        public ProgrammeurDAO()
        {
            Connexion = new MySqlConnection("Server=localhost;Uid=root;Pwd=;Database=equipes;");
        }

        public ProgrammeurDAO(String cnx)
        {
            Connexion.ConnectionString = cnx;
        }

        public Programmeur FindByCourriel(String courriel)
        {
            try
            {
                Connexion.Open();
                string requete = "SELECT * FROM programmeur WHERE COURRIEL = '" + courriel + "'";
                MySqlCommand cmd = new MySqlCommand(requete);
                cmd.Connection = Connexion;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Programmeur p = new Programmeur();
                    p.Courriel = dr.GetString("COURRIEL");
                    p.MotDePasse = dr.GetString("MOTDEPASSE");
                    p.Nom = dr.GetString("NOM");
                    p.Equipe = dr.GetString("EQUIPE");
                    return p;
                }

                return null;
            }
            catch (Exception e) {return null;}
            finally {
                if (Connexion.State != ConnectionState.Closed)
                {
                    Connexion.Close();
                }
            }
        }

        public List<Programmeur> FindByEquipe(String equipe)
        {
            try
            {
                Connexion.Open();
                string requete = "SELECT * FROM programmeur WHERE EQUIPE = '" + equipe + "'";
                List<Programmeur> listeProgrammeur = new List<Programmeur>();
                MySqlCommand cmd = new MySqlCommand(requete);
                cmd.Connection = Connexion;
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Programmeur p = new Programmeur();
                    p.Courriel = dr.GetString("COURRIEL");
                    p.MotDePasse = dr.GetString("MOTDEPASSE");
                    p.Nom = dr.GetString("NOM");
                    p.Equipe = dr.GetString("EQUIPE");
                    listeProgrammeur.Add(p);
                }

                return listeProgrammeur;
            }
            catch (Exception e) { return null; }
            finally
            {
                if (Connexion.State != ConnectionState.Closed)
                {
                    Connexion.Close();
                }
            }
        }

        public bool Create(Programmeur p)
        {
            try
            {
                Connexion.Open();
                string requete = "INSERT INTO `programmeur` (`COURRIEL`, `NOM`, `MOTDEPASSE`, `EQUIPE`) VALUES ('"+p.Courriel+"', '"+p.Nom+"', '"+p.MotDePasse+"', '"+p.Equipe+"')";
                Console.WriteLine("Requete" + requete);
                MySqlCommand cmd = new MySqlCommand(requete);
                cmd.Connection = Connexion;
                return cmd.ExecuteNonQuery()>0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur"+e);
                return false; }
            finally
            {
                if (Connexion.State != ConnectionState.Closed)
                {
                    Connexion.Close();
                }
            }
        }
    }
}