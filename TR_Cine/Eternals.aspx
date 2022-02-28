<%@ Page Title="" Language="C#" MasterPageFile="~/Opcion2/PagInicio.Master" AutoEventWireup="true" CodeBehind="Eternals.aspx.cs" Inherits="TR_Cine.Eternals" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_contenido" runat="server">
    <link href="Opcion2/css/estilos.css" rel="stylesheet">
    <link href="Opcion2/css/contenido.css" rel="stylesheet">
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
            <div class="steps-movie">
                <div class="video">
                </div>
                <p>
                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </p>
                <p>
                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </p>
            </div>
            <div class="funciones">
                <div class="filtro">
                    <asp:DropDownList ID="ddl_Ciudad" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddl_Ciudad_SelectedIndexChanged"></asp:DropDownList>
                    <asp:DropDownList ID="ddl_sucursal" AutoPostBack="true" runat="server"></asp:DropDownList>                    
                </div>
                <h3 class="info">Horarios:</h3>
                <p>
                    <asp:DropDownList ID="ddl_hora" runat="server"></asp:DropDownList>
                </p>
            </div>
            <div class="aside-bottom">
                <button class="button-step"><a href="BoletosC.aspx">Siguiente</a></button>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_footer" runat="server">
</asp:Content>
