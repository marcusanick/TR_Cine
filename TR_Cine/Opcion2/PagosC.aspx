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
                    <h3>Pelicula:
                        <asp:Label ID="lbl_pelicula" runat="server" Text=" "></asp:Label></h3>
                    <h3 class="info">Ciudad:
                        <asp:Label ID="lbl_ddlc" runat="server" Text=" "></asp:Label></h3>
                    <h3 class="info">Sucursal:
                        <asp:Label ID="lbl_ddls" runat="server" Text=" "></asp:Label>
                    </h3>
                    <h3 class="info">Función:
                        <asp:Label ID="lbl_ddlh" runat="server" Text=" "></asp:Label></h3>
                    <h3>Detalle del boleto: </h3>
                    <h3 class="info">Butacas escogidas:
                        <asp:Label ID="lbl_contadorbut" runat="server" Text="0"></asp:Label></h3>
                    <h3 class="info">Precio Total:
                        <asp:Label ID="lbl_precio" runat="server" Text=" "></asp:Label></h3>
                </div>
                <div class="infoPersonal">
                    <h3>Datos Personales</h3>
                    <div class="input-container">
                        <asp:TextBox ID="txtCedula" placeholder="Cédula" CssClass="inputFinal" runat="server"></asp:TextBox>
                        <asp:TextBox ID="txtNombre" placeholder="Nombre Completo" CssClass="inputFinal" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-container">
                        <asp:TextBox ID="txtCorreo" CssClass="inputFinal" placeholder="Correo electrónico" runat="server"></asp:TextBox>
                        <asp:TextBox ID="txtTelefono" CssClass="inputFinal" placeholder="Telefono" runat="server"></asp:TextBox>
                    </div>
                    <asp:TextBox ID="txtTarjeta" CssClass="inputFinal" placeholder="No. Tarjeta" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="aside-bottom">
                <asp:Button ID="Btn_Anterior" runat="server" CssClass="button-step" ForeColor="White" Text="Anterior" OnClick="Btn_Anterior_Click" />
                <asp:Button ID="Btn_Siguiente" runat="server" CssClass="button-step" ForeColor="White" Text="Finalizar" OnClick="Btn_Siguiente_Click" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_footer" runat="server">
</asp:Content>
