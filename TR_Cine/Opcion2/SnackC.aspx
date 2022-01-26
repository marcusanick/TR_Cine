<%@ Page Title="" Language="C#" MasterPageFile="~/Opcion2/PagInicio.Master" AutoEventWireup="true" CodeBehind="SnackC.aspx.cs" Inherits="TR_Cine.Opcion2.SnackC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_contenido" runat="server">
    <link href="css/estilos.css" rel="stylesheet">
    <link href="css/contenido.css" rel="stylesheet">
    <div class="container mt-2 container-movies">
        <div class="info-movie">
            <div class="img-movie">
                <img src="img/portadaeternasl.png">
            </div>
            <h3 class="info">Pelicula:</h3>
            <h3 class="info">Director:</h3>
            <h3 class="info">Duración:</h3>
            <h3 class="info">Calificación:</h3>
        </div>
        <div class="aside">
            <h3>Desea agregar algún snack o combo a su compra:</h3>
            <div class="snack">
                <div class="tab-pane active" id="home">
                    <div class="row g-0 rounded shadow-sm">
                        <div class="col p-3">
                            <div class="box">
                                <img src="img/combo2.jpg">
                            </div>
                        </div>
                        <div class="col p-3">
                            <div class="box">
                                <img src="img/combo3.jpg">
                            </div>
                        </div>
                        <div class="col p-3">
                            <div class="box">
                                <img src="img/combo2.jpg">
                            </div>
                        </div>
                        <div class="col p-3">
                            <div class="box">
                                <img src="img/combo3.jpg">
                            </div>
                        </div>
                        <div class="col p-3">
                            <div class="box">
                                <img src="img/combo2.jpg">
                            </div>
                        </div>
                        <div class="col p-3">
                            <div class="box ">
                                <img src="img/combo3.jpg">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        <div class="aside-bottom">
            <button class="button-step"><a href="ButacaC.aspx">Anterior</a></button>
            <button class="button-step"><a href="PagosC.aspx">Siguiente</a></button>
        </div>
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_footer" runat="server">
</asp:Content>
