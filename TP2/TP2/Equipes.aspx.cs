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
            LblErreurEquipe.Text = "";
            // Aller chercher le nom de lutilisateur
            HttpContext context = HttpContext.Current;
            Programmeur profil =(Programmeur)context.Session["profil"];
            LblProgrammeur.Text = "Profil de :"+profil.Nom;
            LblMembre.Text = "Membre de : " + profil.Equipe;

            // Aller chercher toutes les equipes
            EquipeDAO equipeDAO = new EquipeDAO();
            ListEquipes.Items.Clear();
            foreach (Equipe equipe in equipeDAO.FindAll())
            {
                ListEquipes.Items.Add(equipe.Nom);
            }
        }

        protected void BtnRejoindreEquipe_Click(object sender, EventArgs e)
        {
            EquipeDAO equipeDAO = new EquipeDAO();
            bool equipeTrouve = false;
            foreach (Equipe equipe in equipeDAO.FindAll())
            {
                if (equipe.Nom.Equals(TxtbxEquipe.Text))
                {
                    equipeTrouve = true;
                    // Cree le dao
                    ProgrammeurDAO programmeurDAO = new ProgrammeurDAO();
                    //  Aller chercher le programmeur connecer
                    HttpContext context = HttpContext.Current;
                    Programmeur profil = (Programmeur)context.Session["profil"];
                    // Changer l<equipe du programmeur
                    profil.Equipe = TxtbxEquipe.Text;
                    // Changer les donne dans la session
                    Session["profil"] = profil;
                    // Update la base de donne avec la nouvelle equipe
                    programmeurDAO.Update(profil);
                }
            }
            if (!equipeTrouve) {
                LblErreurEquipe.Text = "Le nom de l'equipe entrer n'est pas valide!";
            }
        }
    }
}