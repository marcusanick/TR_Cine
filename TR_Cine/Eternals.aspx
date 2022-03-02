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
            <h3 class="info">Pelicula: <asp:Label ID="lbl_pelicula" runat="server" Text=" "></asp:Label></h3>
            <h3 class="info">Idioma: <asp:Label ID="lbl_idioma" runat="server" Text=" "></asp:Label></h3>
            <h3 class="info">Genero: <asp:Label ID="lbl_genero" runat="server" Text=" "></asp:Label> </h3>
            <h3 class="info">Estado: <asp:Label ID="lbl_estado" runat="server" Text=" "></asp:Label></h3>
        </div>
        <div class="aside">
            <div class="steps-movie">                
                <p>
                    <iframe width="560" height="315" src="https://www.youtube.com/embed/v1EkoQV4g5c" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                </p>
                <p>
                    <asp:Label ID="lbl_sinopsis" runat="server" Text=" "></asp:Label>
                </p>
            </div>
            <div class="funciones">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
                <div class="filtro">
                    <asp:DropDownList ID="ddl_Ciudad" AutoPostBack="true" runat="server" CssClass="form-select" OnSelectedIndexChanged="ddl_Ciudad_SelectedIndexChanged"></asp:DropDownList>
                    <asp:DropDownList ID="ddl_sucursal" AutoPostBack="true" runat="server" CssClass="form-select" OnSelectedIndexChanged="ddl_sucursal_SelectedIndexChanged"></asp:DropDownList>                    
                </div>
                <h3 class="info">Horarios:</h3>
                <p>
                    <asp:DropDownList ID="ddl_hora" runat="server" CssClass="form-select"></asp:DropDownList>
                </p>
                </ContentTemplate></asp:UpdatePanel>
            </div>
            <div class="aside-bottom">
                <asp:Button ID="Btn_siguiente" runat="server" CssClass="button-step" ForeColor="White" Text="Siguiente" OnClick="Btn_siguiente_Click" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_footer" runat="server">
</asp:Content>
