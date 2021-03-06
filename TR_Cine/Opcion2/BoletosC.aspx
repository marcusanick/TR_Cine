<%@ Page Title="" Language="C#" MasterPageFile="~/Opcion2/PagInicio.Master" AutoEventWireup="true" CodeBehind="BoletosC.aspx.cs" Inherits="TR_Cine.Opcion2.BoletosC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_contenido" runat="server">
    <div class="container mt-2 container-movies">
        <link href="css/estilos.css" rel="stylesheet">
        <link href="css/contenido.css" rel="stylesheet">
        <div class="info-movie">
            <div class="img-movie">
                <img src="img/portadaeternasl.png">
            </div>
            <h3 class="info">Datos Pelicula</h3>
            <h3 class="info">Pelicula:
                <asp:Label ID="lbl_pelicula" runat="server" Text=" "></asp:Label></h3>
            <h3 class="info">Idioma: 
                <asp:Label ID="lbl_idioma" runat="server" Text=" "></asp:Label></h3>
            <h3 class="info">Genero:
                <asp:Label ID="lbl_genero" runat="server" Text=" "></asp:Label>
            </h3>
            <h3 class="info">Estado:
                <asp:Label ID="lbl_estado" runat="server" Text=" "></asp:Label></h3>
            <h3 class="info">Datos de Compra</h3>
            <h3 class="info">Ciudad:
                <asp:Label ID="lbl_ddlc" runat="server" Text=" "></asp:Label></h3>
            <h3 class="info">Sucursal:
                <asp:Label ID="lbl_ddls" runat="server" Text=" "></asp:Label>
            </h3>
            <h3 class="info">Función:
                <asp:Label ID="lbl_ddlh" runat="server" Text=" "></asp:Label></h3>
        </div>
        <div class="aside">
            <div class="boletosCompra">
                <h3 class="info">Compra de boletos:</h3>
                <div class="infoBoleto">
                    <div class="generalBoleto">
                        <p>General 2D:</p>
                        <p>Valor 5.00</p>
                    </div>
                    <div class="cantidadBoleto">
                        <asp:TextBox ID="txt_adult" type="number" max="10" min="0" class="input-num" CssClass="form-control" runat="server" Text="0"></asp:TextBox>
                    </div>
                </div>
                <div class="infoBoleto">
                    <div class="generalBoleto">
                        <p>Menores de 12 años:</p>
                        <p>Valor 4.00</p>
                    </div>
                    <div class="cantidadBoleto">
                        <asp:TextBox ID="txt_menores" type="number" CssClass="form-control" max="10" min="0" class="input-num" runat="server" Text="0"></asp:TextBox>
                    </div>
                </div>
                <div class="infoBoleto">
                    <div class="generalBoleto">
                        <p>Adultos mayores de edad:</p>
                        <p>Valor 2.50</p>
                    </div>
                    <div class="cantidadBoleto">
                        <asp:TextBox ID="txt_mayedad" type="number" max="10" min="0" CssClass="form-control" class="input-num" runat="server" Text="0"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="aside-bottom">
                <asp:Button ID="Btn_Anterior" runat="server" CssClass="button-step" ForeColor="White" Text="Anterior" OnClick="Btn_Anterior_Click" />
                <asp:Button ID="Btn_Siguiente" runat="server" CssClass="button-step" ForeColor="White" Text="Siguiente" OnClick="Btn_Siguiente_Click" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_footer" runat="server">
</asp:Content>
