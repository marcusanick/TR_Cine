<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenimientos/Principal.Master" AutoEventWireup="true" CodeBehind="Nuevo_Usu.aspx.cs" Inherits="TR_Cine.Mantenimientos.Nuevo_Usu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .lnkAccion {
            text-decoration: none;
            font-size: 16px;
        }
        .auto-style1 {
            width: 100%;
            height: 277px;
        }
        .auto-style2 {
            width: 100%;
            height: 457px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_contenido" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" Interval="3000" Enabled="False" OnTick="Timer1_Tick"></asp:Timer>

            <div style="text-align: center">
                <h1>Panel de Administracion </h1>

            </div>
            <div>
                <table width="100%" align="center">
                    <tr>
                        <td align="center">Bienvenido al sistema:
                            <asp:Label ID="lblnsession" runat="server" Text=""></asp:Label>
                        </td>

                    </tr>
                    <tr>
                        <td align="center">
                            <asp:Label ID="lbl_mensaje" runat="server" Text="" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <h2>Usuarios Mantenimiento</h2>
                        </td>
                    </tr>
                </table>
                <table class="auto-style1">
                    <tr>
                        <td align="center">
                            <table style="width: 300px">
                                <tr>
                                    <td>
                                        <asp:LinkButton ID="lnk_nuevo" runat="server" CssClass="lnkAccion" OnClick="lnk_nuevo_Click">Nuevo</asp:LinkButton>
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="lnk_guardar" runat="server" CssClass="lnkAccion" OnClick="lnk_guardar_Click">Guardar</asp:LinkButton>
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="lnk_modificar" runat="server" CssClass="lnkAccion" Visible="false" OnClick="lnk_modificar_Click">Modificar</asp:LinkButton>
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="lnk_regresar" runat="server" CssClass="lnkAccion" OnClick="lnk_regresar_Click">Regresar</asp:LinkButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <table class="auto-style2">
                                <tr>
                                    <td>Usuario:</td>
                                    <td>
                                        <asp:TextBox ID="txt_usu" runat="server" CssClass="form-control"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Contraseña:</td>
                                    <td>
                                        <asp:TextBox ID="txt_pass" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Correo:</td>
                                    <td>
                                        <asp:TextBox ID="txt_correo" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Cedula:</td>
                                    <td>
                                        <asp:TextBox ID="txt_ced" runat="server" CssClass="form-control"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Rol:</td>
                                    <td>
                                        <asp:DropDownList ID="ddl_rol" runat="server" CssClass="form-select"></asp:DropDownList>
                                    </td>
                                </tr>

                                <tr>
                                    <td>Nombre:</td>
                                    <td>
                                        <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Apellido:</td>
                                    <td>
                                        <asp:TextBox ID="txt_apellido" runat="server" CssClass="form-control"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Direccion:</td>
                                    <td>
                                        <asp:TextBox ID="txt_direccion" runat="server" CssClass="form-control"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Telefono:</td>
                                    <td>
                                        <asp:TextBox ID="txt_cel" runat="server" CssClass="form-control"></asp:TextBox>
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
