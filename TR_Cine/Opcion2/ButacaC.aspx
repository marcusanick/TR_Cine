﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Opcion2/PagInicio.Master" AutoEventWireup="true" CodeBehind="ButacaC.aspx.cs" Inherits="TR_Cine.Opcion2.ButacaC" %>
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
            <h3 class="info">Elija su asiento:</h3>
            <div class="butacas-movie">
                <table class="auto-style1">
                    <tr class="pantalla">
                        <td>&nbsp;</td>
                        <td colspan="20"><button class="screen">Pantalla</button></td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr id="butaca">
                        <td class="auto-style3">A</td>
                        <td>&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style15">&nbsp;</td>
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
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style15">
                            7<button class="asiento"></button></td>
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
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style11"></td>
                        <td class="auto-style13"></td>
                        <td class="auto-style3">A</td>
                    </tr>
                    <tr id="butaca">
                        <td class="auto-style3">B</td>
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
                        <td class="auto-style3">B</td>
                    </tr>
                    <tr id="butaca">
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
                    </tr>
                    <tr id="butaca">
                        <td class="auto-style3">D</td>
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
                        <td class="auto-style3">D</td>
                    </tr>
            </table>
            <div class="tipoButacas">
                <p>Ocupado <button class="ocupado"></button></p>
                <p>Disponible <button class="disponible"></button></p>
                <p>Seleccionado <button class="seleccionado"></button></p>
            </div>
            </div>
            <hr>
            <div class="aside-bottom">
                <button class="button-step"><a href="BoletosC.aspx">Anterior</a></button>
                <button class="button-step"><a href="SnackC.aspx">Siguiente</a></button>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_footer" runat="server">
</asp:Content>