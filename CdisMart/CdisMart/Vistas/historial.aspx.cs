﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CdisMart_BLL;
using System.Data;
using System.Data.SqlClient;

namespace CdisMart.Vistas
{
    public partial class historial : Tema, IAcceso
    {
        #region EVENTOS
        public bool sesionIniciada()
        {
            {
                if (Session["Usuario"] != null)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (sesionIniciada())
                {
                    lblUsuarioActivo.Text = "Usuario activo: " + usuarioActivo();

                    int IdSubasta = int.Parse(Request.QueryString["pIdSubasta"]);
                    cargarSubasta(IdSubasta);
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }
        public string usuarioActivo()
        {
            return Session["Usuario"].ToString();
        }
        #endregion

        #region METODOS

        public void cargarSubasta(int IdSubasta)
        {
            UserBLL usuario = new UserBLL();
            DataTable dtSubasta = new DataTable();

            //dtSubasta = usuario.cargarSubasta(IdSubasta);

            lblDescripcion.Text = dtSubasta.Rows[0]["Description"].ToString();
            lblNombreProducto.Text = dtSubasta.Rows[0]["ProductName"].ToString();

            txtUsuario.Text = dtSubasta.Rows[0]["NombreUsuarioSubasta"].ToString();
            txtFechaRealizaciondeOferta.Text = dtSubasta.Rows[0]["StartDate"].ToString().Substring(0, 16);
            txtMontoOferta.Text = dtSubasta.Rows[0]["HighestBid"].ToString();

        }


        #endregion
    }
}