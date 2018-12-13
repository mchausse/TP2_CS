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
    public partial class AjoutEquipe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            EquipeDAO equipeDAO = new EquipeDAO();
            bool equipeTrouve = false;
            foreach (Equipe equipe in equipeDAO.FindAll())
            {
                if (equipe.Nom.Equals(txtNom.Text))
                {
                    equipeTrouve = true;
                }
            }
            if (!equipeTrouve)
            {
                EquipeDAO eDao = new EquipeDAO();
                Equipe eq = new Equipe();
                eq.Nom = txtNom.Text;
                eq.Description = txtDesc.Text;
                eDao.Create(eq);
            }
            Response.Redirect("~/Equipes.aspx");
        }

    }
}