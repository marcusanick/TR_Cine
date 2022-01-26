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
                    <h2>Tu compra</h2>
                    <h4>Pelicula</h4>
                    <h4>Sucursal</h4>
                    <h4>Detalle del boleto</h4>
                    <h4>Valor Total</h4>
                </div>
                <div class="infoPersonal">
                    <h3>Datos Personales</h3>
                    <div class="input-container">
                        <input class="inputFinal" placeholder="Cédula" type="text">
                        <input class="inputFinal" placeholder="Nombre" type="text">
                    </div>
                    <div class="input-container">
                        <input class="inputFinal" placeholder="Correo electrónico" type="text">
                        <input class="inputFinal" placeholder="Telefono" type="text">
                    </div>
                    <input class="inputFinal" placeholder="No. Tarjeta" type="text">
                </div>
            </div>
            <div class="aside-bottom">
                <button class="button-step"><a href="SnackC.aspx">Anterior</a></button>
                <button class="button-step"><a href="Index.aspx">Finalizar</a></button>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_footer" runat="server">
</asp:Content>
