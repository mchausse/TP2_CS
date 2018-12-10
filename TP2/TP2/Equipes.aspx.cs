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
            EquipeDAO equipeDAO = new EquipeDAO();
            foreach (Equipe equipe in equipeDAO.FindAll())
            {
                ListEquipes.Items.Add(equipe.Nom);
            }
        }
    }
}