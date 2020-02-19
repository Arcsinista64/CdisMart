﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CdisMart_BLL;
using System.Data;
using System.Data.SqlClient;


namespace CdisMart
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (usuarioValido())
            {
                Response.Redirect("~/Vistas/lista_subastas.aspx");

                //Poner UserName en Site.Master
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "UserName", "", true);

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Sesión", "alert('Usuario y/o contraseña incorrectos.')", true);
            }
        }

        public bool usuarioValido()
        {
            bool acceso = false;

            UserBLL userBLL = new UserBLL();
            DataTable dtUsuario = new DataTable();

            dtUsuario = userBLL.consultarUsuario(txtUsuario.Text, txtContraseña.Text);

            
            if (dtUsuario.Rows.Count > 0)
            {
                //dtUsuario = userBLL.consultarUsuario(txtUsuario.Text);

                Session["Usuario"] = txtUsuario.Text;
                acceso = true;
            }

            return acceso;
        }


    }
}