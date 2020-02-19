using System;
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
    public partial class creacion_subasta : Tema, IAcceso
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
        public string usuarioActivo()
        {
            return Session["Usuario"].ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (sesionIniciada())
                {
                    lblUsuarioActivo.Text = "Usuario activo: "+usuarioActivo();

                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }
        
        #endregion

        #region



        #endregion

        protected void btnAgregarSubasta_Click(object sender, EventArgs e)
        {
            //Session["Usuario"].ToString(); = TextBox1.Text;

            agregarSubasta();

            ScriptManager.RegisterStartupScript(this, typeof(Page), "Registro", "alert('Subasta registrada exitosamente.')", true);


        }

        public void agregarSubasta()
        {
            SubastaBLL subasta = new SubastaBLL();

            string nombreProducto = txtNombreProducto.Text;
            string descripcionProducto = txtDescripcionProducto.Text;
            DateTime fechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
            DateTime fechaFinal = Convert.ToDateTime(txtFechaFin.Text);
            //int usuariodeOferta = obtenerIdUsuario();


            //subasta.agregarSubasta(nombreProducto, descripcionProducto, fechaInicio, fechaFinal, usuariodeOferta);

        }

        //public bool usuarioValido()
        //{
        //    bool acceso = false;
        //    UsuarioBLL userBLL = new UsuarioBLL();
        //    DataTable dtUsuario = new DataTable();
        //    Userr usuario = new Userr();
        //    dtUsuario = userBLL.consultarUsuario(txtUsuario.Text, txtContraseña.Text);
        //    usuario = userBLL.consultarUsuario(txtUsuario.Text);
        //    if (dtUsuario.Rows.Count > 0)
        //    {
        //        int Id_Usuario = usuario.UserId;
        //        string nombreUsuario = usuario.Name;
        //        Session["Usuario"] = dtUsuario;
        //        Session["Id_Usuario"] = Id_Usuario;
        //        Session["nombreUsuario"] = nombreUsuario;
        //        acceso = true;
        //    }

        //    return acceso;

        //}

        
    
    }
}