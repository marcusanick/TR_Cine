<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="TR_Cine.Registrar" %>

<!DOCTYPE html>
<html>
<head>
    <!-- Meta-->
    <meta charset="UTF-8">
    <title>Registrate</title>
    <meta name="viewport" content="width=device-width, user-scalable=yes, initial-scale=1.0, maximum-scale=3.0, minimum-scale=1.0">

    <!-- Iconos  -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css">
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <!-- Estilos -->
    <%--<link rel="stylesheet" href="css/estilos.css">
    <link rel="stylesheet" href="css/estilosp.css">--%>
    <link rel="stylesheet" href="Opcion2/css/estilos.css">
    <!-- Iconos -->
    <script src="https://kit.fontawesome.com/eb496ab1a0.js" crossorigin="anonymous"></script>
</head>
<body>
    <form class="formulario" id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="3000" OnTick="Timer1_Tick"></asp:Timer>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <section>
                    <nav class="navbar fixed-top navbar-expand-lg navbar-dark p-md-3">
                        <div class="container">
                            <asp:LinkButton ID="lnk_home" class="navbar-brand" runat="server" OnClick="lnk_home_Click">Cinema</asp:LinkButton>
                            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                                aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                                <span class="navbar-toggler-icon"></span>
                            </button>
                        </div>
                    </nav>
                </section>
                
                <section class="sec">
                    <h1>Registrate</h1>
                    <div class="contenedor">
                        <asp:Label ID="Label1" runat="server" Text=" Nombre: " Font-Size="1.15em" ForeColor="White"></asp:Label>
                        <div class="input-contenedor">
                            <asp:TextBox ID="txt_nombre"  placeholder="Ingrese su Nombre: " runat="server" Width="100%"></asp:TextBox>
                        </div>

                        <asp:Label ID="Label2" runat="server" Text=" Apellido: " Font-Size="1.15em" ForeColor="White"></asp:Label>
                        <div class="input-contenedor">                    
                            <asp:TextBox ID="txt_apellido"   placeholder="Ingrese su Apellido" runat="server" Width="100%"></asp:TextBox>
                        </div>

                        <asp:Label ID="Label3" runat="server" Text=" Usuario: " Font-Size="1.15em" ForeColor="White"></asp:Label>
                        <div class="input-contenedor">                    
                            <asp:TextBox ID="txt_user"   placeholder="Ingrese su Usuario" runat="server" Width="100%"></asp:TextBox>
                        </div>

                        <asp:Label ID="Label4" runat="server" Text=" Contraseña: " Font-Size="1.15em" ForeColor="White"></asp:Label>
                        <div class="input-contenedor">                    
                            <asp:TextBox ID="txt_pass"   placeholder="Ingrese su Contraseña" runat="server" Width="100%" TextMode="Password"></asp:TextBox>
                        </div>

                        <asp:Label ID="Label5" runat="server" Text=" Email: " Font-Size="1.15em" ForeColor="White"></asp:Label>
                        <div class="input-contenedor">                    
                            <asp:TextBox ID="txt_mail"   placeholder="Ingrese su Email" runat="server" Width="100%" TextMode="Email"></asp:TextBox>
                        </div>

                        <asp:Label ID="Label6" runat="server" Text=" Cedula: " Font-Size="1.15em" ForeColor="White"></asp:Label>
                        <div class="input-contenedor">                    
                            <asp:TextBox ID="txt_cedula"   placeholder="Ingrese su Cedula" runat="server" Width="100%" ></asp:TextBox>
                        </div>

                        <asp:Label ID="Label7" runat="server" Text=" Direccion: " Font-Size="1.15em" ForeColor="White"></asp:Label>
                        <div class="input-contenedor">                    
                            <asp:TextBox ID="txtdireccion"   placeholder="Ingrese su Direccion" runat="server" Width="100%"></asp:TextBox>
                        </div>

                        <asp:Label ID="Label8" runat="server" Text=" Celular: " Font-Size="1.15em" ForeColor="White"></asp:Label>
                        <div class="input-contenedor">                    
                            <asp:TextBox ID="txt_cel"   placeholder="Ingrese su Celular" runat="server" Width="100%" TextMode="Phone"></asp:TextBox>
                        </div>

                   
                        <div class="control">
                            <asp:Button ID="btn_registrar" class="button" runat="server" Text="Registrar" OnClick="btn_registrar_Click" />
                        </div>
                        <div class="control">
                            <center>
                                <br />
                                <asp:LinkButton ID="lnk_regresar" class="link" runat="server" OnClick="lnk_regresar_Click">Regresar</asp:LinkButton>
                            </center>
                        </div>
                    </div>
                    <br />
                    <br />
                    <center>
                        <asp:Label ID="lbl_mensaje" runat="server" Text=""></asp:Label>
                    </center>
            </ContentTemplate>
        </asp:UpdatePanel>
        </section>
    </form>
    
    <br />
    <br />
    <section>
        <footer class="pie-pagina">
            <div class="grupo-1">
                <div class="caja">
                    <figure>
                        <a href="#">
                            <img src="img/logotipo-sleedw.svg" alt="Logo de SLee Dw">
                        </a>
                    </figure>
                </div>
                <div class="caja">
                    <h2>SOBRE NOSOTROS</h2>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Odio, ipsa?</p>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Odio, ipsa?</p>
                </div>
                <div class="caja">
                    <h2>SIGUENOS</h2>
                    <div class="red-social">
                        <a href="#" class="fa fa-facebook"></a>
                        <a href="#" class="fa fa-instagram"></a>
                        <a href="#" class="fa fa-twitter"></a>
                        <a href="#" class="fa fa-youtube"></a>
                    </div>
                </div>
            </div>
            <div class="grupo-2">
                <small>&copy; 2021 <b>CinePlanet</b> - Todos los Derechos Reservados.</small>
            </div>
        </footer>
    </section>

    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js"
        integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB"
        crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js"
        integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13"
        crossorigin="anonymous"></script>
</body>

</html>
