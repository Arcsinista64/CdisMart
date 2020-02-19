using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CdisMart_DAL;
using System.Data;
using System.Data.SqlClient;



namespace CdisMart_BLL
{
    public class SubastaBLL
    {
        public List<object> cargarSubastas()
        {
            SubastaDAL subasta = new SubastaDAL();
            return subasta.cargarSubastas();
        }

        public Auction cargarSubastas(int IdSubasta)
        {
            SubastaDAL subasta = new SubastaDAL();
            return subasta.cargarSubastas(IdSubasta);
        }




        //public void agregarSubasta(string nombreProducto, string descripcionProducto, DateTime fechaInicio, DateTime fechaFinal, int usuariodeOferta)
        //{
        //    SubastaDAL subasta = new SubastaDAL();
        //    subasta.agregarSubasta(nombreProducto, descripcionProducto, fechaInicio, fechaFinal, usuariodeOferta);
        //}



        //public DataTable cargarSubasta(int IdSubasta)
        //{
        //    UserDAL usuario = new UserDAL();
        //    return usuario.cargarSubasta(IdSubasta);
        //}



    }
}
