using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CdisMart_BLL;
using CdisMart_DAL;

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
            SubastaBLL usuario = new SubastaBLL();
            Auction subasta = new Auction();


            subasta = usuario.cargarSubastas(IdSubasta);

            lblIdSubasta.Text = subasta.AuctionId.ToString();
            txtNombreProducto.Text = subasta.ProductName.ToString();
            txtFechaInicio.Text = subasta.StartDate.ToString().Substring(0, 16);
            txtFechaFinalizacion.Text = subasta.EndDate.ToString().Substring(0, 16);
            txtDescripcion.Text = subasta.Description.ToString();

            txtOfertaMasAlta.Text = subasta.HighestBid.ToString();
            txtUsuariodeOfertaMasAlta.Text = subasta.Winner.ToString();
        }



        #endregion

        
    }
}