<%@ Page Title="" Language="C#" MasterPageFile="~/Opcion2/PagInicio.Master" AutoEventWireup="true" CodeBehind="ButacaC.aspx.cs" Inherits="TR_Cine.Opcion2.ButacaC" %>

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
            <h3 class="info">Precio Total:
                <asp:Label ID="lbl_precio" runat="server" Text=" "></asp:Label></h3>
            <h3 class="info">Butacas a comprar:
                <asp:Label ID="lbl_butco" runat="server" Text=" "></asp:Label></h3>
            <h3 class="info">Butacas escogidas:
                <asp:Label ID="lbl_contadorbut" runat="server" Text="0"></asp:Label></h3>
            <h3 class="info">Butacas Disponibles:
                <asp:Label ID="lbl_contador" runat="server" Text=" "></asp:Label>
            </h3>
        </div>
        <div class="aside">
            <h3 class="info">Elija su asiento:</h3>
            <div class="butacas-movie">
                <table class="auto-style1">
                    <tr class="pantalla">
                        <td>&nbsp;</td>
                        <td colspan="20">
                            <button class="screen">Pantalla</button></td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr id="butaca1">
                        <td class="auto-style3">A</td>
                        <td>&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_A1" runat="server" Text="1"></asp:Label><asp:Button ID="Btn_A1" runat="server" class="asiento" OnClick="Btn_A1_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_A2" runat="server" Text="2"></asp:Label><asp:Button ID="Btn_A2" runat="server" class="asiento" OnClick="Btn_A2_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_A3" runat="server" Text="3"></asp:Label><asp:Button ID="Btn_A3" runat="server" class="asiento" OnClick="Btn_A3_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_A4" runat="server" Text="4"></asp:Label><asp:Button ID="Btn_A4" runat="server" class="asiento" OnClick="Btn_A4_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_A5" runat="server" Text="5"></asp:Label><asp:Button ID="Btn_A5" runat="server" class="asiento" OnClick="Btn_A5_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_A6" runat="server" Text="6"></asp:Label><asp:Button ID="Btn_A6" runat="server" class="asiento" OnClick="Btn_A6_Click" /></td>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_A7" runat="server" Text="7"></asp:Label><asp:Button ID="Btn_A7" runat="server" class="asiento" OnClick="Btn_A7_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_A8" runat="server" Text="8"></asp:Label><asp:Button ID="Btn_A8" runat="server" class="asiento" OnClick="Btn_A8_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_A9" runat="server" Text="9"></asp:Label><asp:Button ID="Btn_A9" runat="server" class="asiento" OnClick="Btn_A9_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_A10" runat="server" Text="10"></asp:Label><asp:Button ID="Btn_A10" runat="server" class="asiento" OnClick="Btn_A10_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_A11" runat="server" Text="11"></asp:Label><asp:Button ID="Btn_A11" runat="server" class="asiento" OnClick="Btn_A11_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_A12" runat="server" Text="12"></asp:Label><asp:Button ID="Btn_A12" runat="server" class="asiento" OnClick="Btn_A12_Click" /></td>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style11"></td>
                        <td class="auto-style13"></td>
                        <td class="auto-style3">A</td>
                    </tr>
                    <tr id="butaca2">
                        <td class="auto-style3">B</td>
                        <td>&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B1" runat="server" Text="1"></asp:Label><asp:Button ID="Btn_B1" runat="server" class="asiento" OnClick="Btn_B1_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B2" runat="server" Text="2"></asp:Label><asp:Button ID="Btn_B2" runat="server" class="asiento" OnClick="Btn_B2_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B3" runat="server" Text="3"></asp:Label><asp:Button ID="Btn_B3" runat="server" class="asiento" OnClick="Btn_B3_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B4" runat="server" Text="4"></asp:Label><asp:Button ID="Btn_B4" runat="server" class="asiento" OnClick="Btn_B4_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B5" runat="server" Text="5"></asp:Label><asp:Button ID="Btn_B5" runat="server" class="asiento" OnClick="Btn_B5_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B6" runat="server" Text="6"></asp:Label><asp:Button ID="Btn_B6" runat="server" class="asiento" OnClick="Btn_B6_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B7" runat="server" Text="7"></asp:Label><asp:Button ID="Btn_B7" runat="server" class="asiento" OnClick="Btn_B7_Click" /></td>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B8" runat="server" Text="8"></asp:Label><asp:Button ID="Btn_B8" runat="server" class="asiento" OnClick="Btn_B8_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B9" runat="server" Text="9"></asp:Label><asp:Button ID="Btn_B9" runat="server" class="asiento" OnClick="Btn_B9_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B10" runat="server" Text="10"></asp:Label><asp:Button ID="Btn_B10" runat="server" class="asiento" OnClick="Btn_B10_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B11" runat="server" Text="11"></asp:Label><asp:Button ID="Btn_B11" runat="server" class="asiento" OnClick="Btn_B11_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B12" runat="server" Text="12"></asp:Label><asp:Button ID="Btn_B12" runat="server" class="asiento" OnClick="Btn_B12_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B13" runat="server" Text="13"></asp:Label><asp:Button ID="Btn_B13" runat="server" class="asiento" OnClick="Btn_B13_Click" /></td>
                        <td class="auto-style15">
                            <asp:Label ID="lbl_B14" runat="server" Text="14"></asp:Label><asp:Button ID="Btn_B14" runat="server" class="asiento" OnClick="Btn_B14_Click" /></td>
                        <td class="auto-style11"></td>
                        <td class="auto-style13"></td>
                        <td class="auto-style3">B</td>
                    </tr>
                    <%--<tr id="butaca">
                        <td class="auto-style3">C</td>
                        <td>&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style15">
                            1<button class="asiento"></button></td>
                        <td class="auto-style15">
                            2<button class="asiento"></button></td>
                        <td class="auto-style15">
                            3<button class="asiento"></button></td>
                        <td class="auto-style15">
                            4<button class="asiento"></button></td>
                        <td class="auto-style15">
                            5<button class="asiento"></button></td>
                        <td class="auto-style15">
                            6<button class="asiento"></button></td>
                        <td class="auto-style15">
                            7<button class="asiento"></button></td>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style15">
                            8<button class="asiento"></button></td>
                        <td class="auto-style15">
                            9<button class="asiento"></button></td>
                        <td class="auto-style15">
                            10<button class="asiento"></button></td>
                        <td class="auto-style15">
                            11<button class="asiento"></button></td>
                        <td class="auto-style15">
                            12<button class="asiento"></button></td>
                        <td class="auto-style15">
                            13<button class="asiento"></button></td>
                        <td class="auto-style15">
                            14<button class="asiento"></button></td>
                        <td class="auto-style11"></td>
                        <td class="auto-style13"></td>
                        <td class="auto-style3">C</td>
                    </tr>--%>
                </table>
                <div class="tipoButacas">
                    <p>Ocupado
                        <button class="ocupado"></button>
                    </p>
                    <p>Disponible
                        <button class="disponible"></button>
                    </p>
                    <p>Seleccionado
                        <button class="seleccionado"></button>
                    </p>
                </div>
            </div>
            <hr>
            <div class="infoPersonal">
                    <h3>Datos Personales</h3>
                    <div class="input-container">
                        <asp:TextBox ID="txtCedula" placeholder="Cédula" CssClass="inputFinal" runat="server"></asp:TextBox>
                        <asp:TextBox ID="txtNombre" placeholder="Nombre" CssClass="inputFinal" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-container">
                        <asp:TextBox ID="txtCorreo" CssClass="inputFinal" placeholder="Correo electrónico" runat="server"></asp:TextBox>
                        <asp:TextBox ID="txtTelefono" CssClass="inputFinal" placeholder="Telefono" runat="server"></asp:TextBox>
                    </div>
                    <asp:TextBox ID="txtTarjeta" CssClass="inputFinal" placeholder="No. Tarjeta" runat="server"></asp:TextBox>
                </div>          
            <div class="aside-bottom">
                <asp:Button ID="Btn_anterior" runat="server" CssClass="button-step" ForeColor="White" Text="Anterior" OnClick="Btn_anterior_Click" />
                <asp:Button ID="Btn_siguiente" runat="server" CssClass="button-step" ForeColor="White" Text="Siguiente" OnClick="Btn_siguiente_Click" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_footer" runat="server">
</asp:Content>
