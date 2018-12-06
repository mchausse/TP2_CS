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
            // Aller chercher le nom de lutilisateur
            HttpContext context = HttpContext.Current;
            Programmeur profil =(Programmeur)context.Session["profil"];
            LblProgrammeur.Text = "Profil de "+profil.Nom;

            // Aller chercher toutes les equipes
            MySqlConnection Connexion = new MySqlConnection("Server=localhost;Uid=root;Pwd=;Database=equipes;");
            MySqlCommand cmd = new MySqlCommand();
            Equipe equipe = null;
            int i = 0;
            Connexion.Open();

            cmd.CommandText = "SELECT * FROM equipe ";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = Connexion;

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                equipe = new Equipe();
                equipe.Nom = dr.GetString("NOM");
                equipe.Description = dr.GetString("DESCRIPTION");
                ListEquipes.Items.Insert(i++,equipe.Nom+"");
            }
            Connexion.Close();
        }
    }
}