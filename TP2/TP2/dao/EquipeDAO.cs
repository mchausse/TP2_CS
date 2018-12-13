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
            Connexion = new MySqlConnection("Server=localhost;Uid=root;Pwd=root;Database=equipes;"); 
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
                string requete = "SELECT * FROM equipe WHERE NOM = '" + nom + "'";
                MySqlCommand cmd = new MySqlCommand(requete);
                cmd.Connection = Connexion;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Equipe e = new Equipe();
                    e.Nom = dr.GetString("NOM");
                    e.Description = dr.GetString("DESCRIPTION");
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

        public List<Equipe> FindAll()
        {
            List<Equipe> equipes = new List<Equipe>();
            try
            {
                // Start la connexion
                Connexion.Open();

                //Requete
                string requete = "SELECT * FROM equipe";
                MySqlCommand cmd = new MySqlCommand(requete);
                cmd.Connection = Connexion;
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipe e = new Equipe();
                    e.Nom = dr.GetString("NOM");
                    e.Description = dr.GetString("DESCRIPTION");
                    equipes.Add(e);
                }
                return equipes;
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
        public List<Equipe> FindAllBySearch(string search)
        {
            List<Equipe> equipes = new List<Equipe>();
            try
            {
                // Start la connexion
                Connexion.Open();

                //Requete
                string requete = "SELECT * FROM equipe where NOM LIKE '%"+search+"%'";
                MySqlCommand cmd = new MySqlCommand(requete);
                cmd.Connection = Connexion;
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipe e = new Equipe();
                    e.Nom = dr.GetString("NOM");
                    e.Description = dr.GetString("DESCRIPTION");
                    equipes.Add(e);
                }
                return equipes;
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
        public bool Create(Equipe eq)
        {
            try
            {
                Connexion.Open();
                string requete = "INSERT INTO `equipe` (`NOM`, `DESCRIPTION`) VALUES ('" + eq.Nom + "', '" + eq.Description + "')";
                Console.WriteLine("Requete" + requete);
                MySqlCommand cmd = new MySqlCommand(requete);
                cmd.Connection = Connexion;
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur" + e);
                return false;
            }
            finally
            {
                if (Connexion.State != ConnectionState.Closed)
                {
                    Connexion.Close();
                }
            }
        }

        public bool Update(Equipe eq)
        {
            try
            {
                Connexion.Open();
                string requete = "UPDATE `equipe` " +
                                 "SET `NOM`='" + eq.Nom + "',`DESCRIPTION`='" + eq.Description + "' "+
                                 "WHERE `NOM`='" + eq.Nom + "'";
                Console.WriteLine("Requete" + requete);
                MySqlCommand cmd = new MySqlCommand(requete);
                cmd.Connection = Connexion;
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur" + e);
                return false;
            }
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