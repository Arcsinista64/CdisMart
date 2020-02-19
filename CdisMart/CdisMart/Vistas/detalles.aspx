<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="detalles.aspx.cs" Inherits="CdisMart.Vistas.detalles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12" >
            <asp:Label style="float:right;" ID="lblUsuarioActivo" runat="server" Text=""></asp:Label>
        </div>
    <hr />

     <table>
        <tr>
            <td># de Subasta: </td>
            <td>
                <asp:Label ID="lblIdSubasta" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Nombre del producto: </td>
            <td>
                <asp:TextBox ID="txtNombreProducto" runat ="server"  Enabled ="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Fecha de inicio: </td>
            <td>
                <asp:TextBox ID="txtFechaInicio" runat ="server" Enabled ="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Fecha de finalización: </td>
            <td>
                <asp:TextBox ID="txtFechaFinalizacion" runat ="server" Enabled ="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Descripción: </td>
            <td>
                <asp:TextBox ID="txtDescripcion" runat ="server" Enabled ="false"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Oferta actual más alta: </td>
            <td>
                <asp:TextBox ID="txtOfertaMasAlta" runat ="server" Enabled ="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Usuario que hizo tal oferta: </td>
            <td>
                <asp:TextBox ID="txtUsuariodeOfertaMasAlta" runat ="server" Enabled ="false"></asp:TextBox>

            </td>
        </tr>

        <tr>
            <td>Cantidad a ofertar:</td>
            <td>
                <asp:TextBox ID="txtNuevaOferta" runat ="server"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td> </td>
            <td>
                <asp:Button ID="btnRealizarOferta" runat ="server" Text="Ofertar" OnClick="btnRealizarOferta_Click"></asp:Button>
            </td>
        </tr>
    </table>

</asp:Content>
