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
    public partial class ProfilEquipe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ("".Equals(((Programmeur)Session["profil"]).Equipe)) {
                Response.Redirect("~/Equipes.aspx");
            }
            EquipeDAO eDao = new EquipeDAO();
            ProgrammeurDAO pDao = new ProgrammeurDAO();
            Equipe equipe = eDao.FindByNom(((Programmeur)Session["profil"]).Equipe);
            ListProgrammeur.Items.Clear();
            foreach (Programmeur p in pDao.FindByEquipe(((Programmeur)Session["profil"]).Equipe))
            {
                ListProgrammeur.Items.Add(p.Nom);
            }
            titreEquipe.Text = "Titre de l'équipe: " + equipe.Nom;
            description.Text = "Description: " + equipe.Description;
        }

        protected void bn_quitter_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Equipes.aspx");
        }

        protected void quitterEquipe_Click(object sender, EventArgs e)
        {
            ProgrammeurDAO pDao = new ProgrammeurDAO();
            ((Programmeur)Session["profil"]).Equipe = "";
            pDao.Update(((Programmeur)Session["profil"]));
            Response.Redirect("~/Equipes.aspx");
        }
    }
}