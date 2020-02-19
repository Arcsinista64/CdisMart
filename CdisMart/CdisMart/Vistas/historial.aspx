<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="historial.aspx.cs" Inherits="CdisMart.Vistas.historial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12" >
            <asp:Label style="float:right;" ID="lblUsuarioActivo" runat="server" Text=""></asp:Label>
        </div>
    <hr />
    
    <div class="container">

        <asp:Label ID="lblNombreProducto" runat="server" Text=""></asp:Label>

        <asp:Label ID="lblDescripcion" runat="server" Text=""></asp:Label>


    </div>

    <hr />
    <table>
        <tr>
            <td>Usuario que realizó la oferta: </td>
            <td>
                <asp:TextBox ID="txtUsuario" runat="server" Enabled ="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Monto de oferta: </td>
            <td>
                <asp:TextBox ID="txtMontoOferta" runat ="server"  Enabled ="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Fecha de realización de la oferta: </td>
            <td>
                <asp:TextBox ID="txtFechaRealizaciondeOferta" runat ="server" Enabled ="false"></asp:TextBox>
            </td>
        </tr>
    </table>

</asp:Content>
