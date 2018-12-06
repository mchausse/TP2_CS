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
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConnexion_Click(object sender, EventArgs e){
            //Verifier les champs
            ProgrammeurDAO pDAO = new ProgrammeurDAO();
            Programmeur p = pDAO.FindByCourriel(TxtbxCourriel.Text);
            if (p != null)
            {
                if (p.MotDePasse.Equals(TxtbxMotDePasse.Text))
                {
                    Session["profil"] = p;
                    Response.Redirect("~/Equipes.aspx", true);
                }
                else
                {
                    Response.Redirect("~/index.aspx");
                }
            }
            // Renvoyer les informations a la page
        }
    }
}