<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenimientos/Principal.Master" AutoEventWireup="true" CodeBehind="Listar_Usu.aspx.cs" Inherits="TR_Cine.Mantenimientos.Listar_Usu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_contenido" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
             <asp:Timer ID="Timer1" runat="server" Interval="3000" Enabled="False" OnTick="Timer1_Tick" ></asp:Timer>

            <table style="width:80% ">
                <tr>
                    <td align="center">Bienvenido al sistema:
                         <asp:Label ID="lbl_nombre" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="lbl_mensaje" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <h2> Usuarios </h2>
                    </td>
                </tr>
            </table>
                        <table style="width:100%">
            <tr>
                <td  align="center">
                    <asp:LinkButton ID="lnk_nuevo" runat="server" OnClick="lnk_nuevo_Click" >Nuevo Usuario</asp:LinkButton>
                </td>
                
            </tr>
            <tr>
                <td align="center">
                    <table >
                        <tr>
                            <td>Buscar por :</td>
                            <td>
                                <asp:DropDownList ID="ddl_criterio" runat="server" Width="150px" Height="25px">
                                     <asp:ListItem Text="Seleccione" Value="S"></asp:ListItem>
                                    <asp:ListItem Text="Nombre" Value="N"></asp:ListItem>
                                </asp:DropDownList>                        
                            </td>
                            <td>
                                <asp:TextBox ID="txt_buscar" runat="server" Width="350px" Height="20px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:ImageButton ID="img_lupa" runat="server" ImageUrl="~/Mantenimientos/img/search.png" OnClick="img_lupa_Click"/>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" align="center">
                                <asp:GridView ID="grv_pro" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowCommand="grv_pro_RowCommand">
                                    <Columns>
                                        <asp:TemplateField HeaderText="▒">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="img_editar" runat="server" ImageUrl="~/Mantenimientos/img/editar10.gif"
                                                    CommandArgument='<%#Eval("usu_id")%>' CommandName="Editar"/>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="▒">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="img_eliminar" runat="server" ImageUrl="~/Mantenimientos/img/eliminar.gif"
                                                    CommandArgument='<%#Eval("usu_id")%>' CommandName="Eliminar" OnClientClick="return confirm('Esta seguro de eliminar el registro..')"/>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Rol">
                                            <ItemTemplate>
                                                <asp:Label ID="rol_id" runat="server" Text='<%#Eval("rol_id")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Usuario">
                                            <ItemTemplate>
                                                <asp:Label ID="usu_login" runat="server" Text='<%#Eval("usu_nombre")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Contrasenia">
                                            <ItemTemplate>
                                                <asp:Label ID="usu_password" runat="server" Text='<%#Eval("usu_pass")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        
                                        <asp:TemplateField HeaderText="Correo">
                                            <ItemTemplate>
                                                <asp:Label ID="usu_email" runat="server" Text='<%#Eval("usu_email")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        
                                        <asp:TemplateField HeaderText="Estado">
                                            <ItemTemplate>
                                                <asp:Label ID="usu_estado" runat="server" Text='<%#Eval("usu_estado")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Direccion">
                                            <ItemTemplate>
                                                <asp:Label ID="per_id" runat="server" Text='<%#Eval("usu_direccion")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        
                                    </Columns>
                                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                                    <RowStyle BackColor="White" ForeColor="#003399" />
                                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                                    <SortedDescendingHeaderStyle BackColor="#002876" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" align="center">

                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" align="center">
                                <asp:Label ID="lbl_mensajes" runat="server" Text="" Visible="false"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>

        </table>
            </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
