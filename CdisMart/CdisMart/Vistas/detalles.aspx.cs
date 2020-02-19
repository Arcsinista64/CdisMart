using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CdisMart_BLL;

namespace CdisMart.Vistas
{
    public partial class detalles : Tema, IAcceso
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
        protected void btnRealizarOferta_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region METODOS

        public void cargarSubasta(int IdSubasta)
        {
            UserBLL usuario = new UserBLL();
            DataTable dtSubasta = new DataTable();

            //dtSubasta = usuario.cargarSubasta(IdSubasta);

            lblIdSubasta.Text = dtSubasta.Rows[0]["AuctionId"].ToString();
            txtNombreProducto.Text = dtSubasta.Rows[0]["ProductName"].ToString();
            txtFechaInicio.Text = dtSubasta.Rows[0]["StartDate"].ToString().Substring(0, 16);
            txtFechaFinalizacion.Text = dtSubasta.Rows[0]["EndDate"].ToString().Substring(0, 16);
            txtDescripcion.Text = dtSubasta.Rows[0]["Description"].ToString();

            txtOfertaMasAlta.Text = dtSubasta.Rows[0]["HighestBid"].ToString();
            txtUsuariodeOfertaMasAlta.Text = dtSubasta.Rows[0]["NombreUsuarioSubasta"].ToString();

            //Traer de tabla AuctionRecord

        }



        #endregion

        
    }
}