﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenimientos/Principal.Master" AutoEventWireup="true" CodeBehind="Nuevo_GenPel.aspx.cs" Inherits="TR_Cine.Mantenimientos.Nuevo_GenPel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_contenido" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
         <asp:Timer ID="Timer1" runat="server" Interval="3000" Enabled="False" OnTick="Timer1_Tick"></asp:Timer>
        <div style="text-align:center">
         <h1>Panel de Administracion</h1>       
    </div>    
            <div>
        <table width="80%">
            <tr>
                <td align="center">Bienvenido al sistema: <asp:Label ID="lblnsession" runat="server" Text=""></asp:Label>
                </td>
                                
            </tr>
            <tr>
                    <td align="center">
                        <asp:Label ID="lbl_mensaje" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <h2> Generos  Mantenimiento</h2>
                    </td>
                </tr>
            </table>
            <table style="width:80%">
                <tr>
                    <td align="center">
                        <table style="width:300px">
                            <tr>
                                <td>
                                    <asp:LinkButton ID="lnk_nuevo" runat="server" OnClick="lnk_nuevo_Click" >Nuevo</asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lnk_guardar" runat="server" OnClick="lnk_guardar_Click"  >Guardar</asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lnk_modificar" runat="server" Visible="false" OnClick="lnk_modificar_Click"  >Modificar</asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lnk_regresar" runat="server" OnClick="lnk_regresar_Click"  >Regresar</asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                                    <table style="width:100%">
                                        <tr>
                                            <td>Descripcion:</td>
                                            <td>
                                                <asp:TextBox ID="txt_gen" runat="server" Height="20px" Width="180px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        
                                        
                                    </table>
                                </td>
                </tr>
        </table>
    </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
