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
    public partial class Inscription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCreeProgrammeur_Click(object sender, EventArgs e)
        {
            ProgrammeurDAO programmeurDAO = new ProgrammeurDAO();
            bool success = programmeurDAO.Create(new Programmeur(TxtbxCourriel.Text,TxtbxNom.Text,TxtbxMotDePasse.Text,""));
            if(success) Response.Redirect("~/index.aspx");
        }
    }
}