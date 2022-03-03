<%@ Page Title="" Language="C#" MasterPageFile="~/Opcion2/PagInicio.Master" AutoEventWireup="true" CodeBehind="PagosC.aspx.cs" Inherits="TR_Cine.Opcion2.PagosC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_contenido" runat="server">
    <link href="css/estilos.css" rel="stylesheet">
    <link href="css/contenido.css" rel="stylesheet">
    <div class="container mt-2 container-movies">
        <div class="lastStep">
            <div class="datosFinales">
                <div class="infoCompra">
                    <h2>Escanea tu QR aquí:</h2>
                    <center>
                        <asp:Image ID="ImagePreview" Width="200" ImageUrl="https://cdn-icons-png.flaticon.com/512/16/16410.png" runat="server" />
                        <h4 style="margin: 45px 0">Gracias por elegirnos</h4>
                    </center>
                </div>
            </div>
        </div>
        <div class="aside-bottom">
            <asp:Button ID="Btn_Siguiente" runat="server" CssClass="button-step" ForeColor="White" Text="Volver al inicio" OnClick="Btn_Siguiente_Click" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_footer" runat="server">
</asp:Content>
