using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CdisMart_DAL;

namespace CdisMart_BLL
{
    public class UserBLL
    {
        public DataTable consultarUsuario(string nombre, string contraseña)
        {
            UserDAL usuario = new UserDAL();

            return usuario.consultarUsuario(nombre, contraseña);
        }

        public DataTable consultarUsuario(string nombre)
        {
            UserDAL usuario = new UserDAL();

            return usuario.consultarUsuario(nombre);
        }

        public void altaUsuario(string  nombreCompleto, string correoElectronico, string nombreUsuario, string contraseña)
        {
            UserDAL usuario = new UserDAL();




            usuario.altaUsuario(nombreCompleto, correoElectronico, nombreUsuario, contraseña);
        }

        //public List<object> obtenerUsuarios()
        //{
        //    UserDAL subasta = new UserDAL();
        //    CdisMartEntities1 IdUsuario = new CdisMartEntities1();


        //    return subasta.obtenerUsuarios();
        //}

        //public DataTable consultarUsuario(string usuario, string contraseña)
        //{
        //    SubastaDAL user = new SubastaDAL();
        //    return user.consultarUsuario(usuario, contraseña);
        //}

        //public Userr consultarUsuario(string usuario)
        //{
        //    UsuarioDAL usuarioDAL = new UsuarioDAL();
        //    return usuarioDAL.cosnultarUsuario(usuario);
        //}
    }
}
