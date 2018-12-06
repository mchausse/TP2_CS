using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP2.modele;

namespace TP2
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConnexion_Click(object sender, EventArgs e){
            //Verifier les champs

            MySqlConnection Connexion = new MySqlConnection("Server=localhost;Uid=root;Pwd=;Database=equipes;");
            Programmeur programmeur = null;
            MySqlCommand cmd = new MySqlCommand();
            Connexion.Open();

            cmd.CommandText = "SELECT * " +
                "FROM programmeur "+
                "WHERE COURRIEL = '" + TxtbxCourriel.Text + "' AND MOTDEPASSE = '" + TxtbxMotDePasse.Text + "'";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = Connexion;

            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                programmeur = new Programmeur();
                programmeur.Courriel = dr.GetString("COURRIEL");
                programmeur.MotDePasse = dr.GetString("MOTDEPASSE");
                programmeur.Nom = dr.GetString("NOM");
                programmeur.Equipes = dr.GetString("EQUIPES");
                Session["profil"] = programmeur;
                Response.Redirect("~/Equipes.aspx", true);
            }
            Connexion.Close();

            // Renvoyer les informations a la page
            if (programmeur == null)
                Response.Redirect("~/index.aspx");
        }
    }
}