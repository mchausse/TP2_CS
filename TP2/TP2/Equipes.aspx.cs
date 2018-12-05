using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP2.dao;
using TP2.modele;

namespace TP2
{
    public partial class Equipes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ProgrammeurDAO programmeurDAO = new ProgrammeurDAO();
            //LblProgrammeur.Text = programmeurDAO.FindByCourriel("mchausse@crosemont.qc.ca").Nom;
            MySqlConnection Connexion = new MySqlConnection("Server=localhost;Uid=root;Database=equipes;");

            Programmeur programmeur = new Programmeur();

            string query = "SELECT * FROM programmeur";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = Connexion;
            Connexion.Open();

            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                programmeur.Courriel = dr.GetString("COURRIEL");
                programmeur.MotDePasse = dr.GetString("MOTDEPASSE");
                programmeur.Nom = dr.GetString("NOM");
                programmeur.Equipes = dr.GetString("EQUIPES");
            }
            Connexion.Close();
            LblProgrammeur.Text = programmeur.Nom;
        }
    }
}