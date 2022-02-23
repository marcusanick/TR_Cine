<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TR_Cine.Login" %>

<!DOCTYPE html>
<html>
<head>
    <!-- Meta-->
    <meta charset="UTF-8">
    <title>Login</title>
    <meta name="viewport" content="width=device-width, user-scalable=yes, initial-scale=1.0, maximum-scale=3.0, minimum-scale=1.0">

    <!-- Iconos  -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css">
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <!-- Estilos -->
    <%--<link rel="stylesheet" href="css/estilos.css">--%>
    <%--<link rel="stylesheet" href="css/estilosp.css">--%>
    <link rel="stylesheet" href="Opcion2/css/estilos.css">
    <!-- Iconos -->
    <script src="https://kit.fontawesome.com/eb496ab1a0.js" crossorigin="anonymous"></script>

</head>
<body>
    <form class="formulario" id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
    <section>
        <nav class="navbar fixed-top navbar-expand-lg navbar-dark p-md-3">
            <div class="container">
                <asp:LinkButton ID="lnk_home" class="navbar-brand"  runat="server" OnClick="lnk_home_Click">Cinema</asp:LinkButton>        
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                    aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
            </div>
        </nav>
    </section>
    <section class="my-5">
        
                    <h1>Login</h1>
                    <div class="contenedor">
                        <div class="input-contenedor">
                            <i class="fas fa-envelope icon"></i>
                            <asp:TextBox ID="txt_correo" type="text" placeholder="Correo Electronico" runat="server"></asp:TextBox>
                        </div>
                        <div class="input-contenedor">
                            <i class="fas fa-key icon"></i>
                            <asp:TextBox ID="txt_password" type="password" placeholder="Contraseña" runat="server"></asp:TextBox>
                        </div>
                        <div class="link">
                            <asp:LinkButton ID="lnk_olvido" runat="server" OnClick="lnk_olvido_Click" class="link">Olvidaste tu Contraseña</asp:LinkButton>
                        </div>
                        <div class="control">
                            <asp:Button ID="btn_ingresar" CssClass="button" runat="server" Text="Ingresar" OnClick="btn_ingresar_Click" />
                            <asp:Button ID="btn_desbloquear" class="button" Visible="false" runat="server" Text="Desbloquear Contraseña" OnClick="btn_desbloquear_Click" />
                        </div>
                        <p>¿No tienes una cuenta?
                            <asp:LinkButton ID="lnk_registrar" class="link" runat="server" OnClick="lnk_registrar_Click">Registrate</asp:LinkButton></p>
                        <asp:LinkButton ID="lnk_regresar" visible="false" runat="server" OnClick="lnk_regresar_Click">Regresar</asp:LinkButton>

                    </div>                                   
                    <center>
                        <asp:Label ID="lbl_intentos" runat="server" Text="Intentos " Visible="false"></asp:Label>
                        <asp:Label ID="lbl_conteo" runat="server" Text="0" ForeColor="Red" Visible="false"></asp:Label>
                        <br />
                        <asp:Label ID="lbl_mensaje" runat="server" Text=""></asp:Label>

                    </center>
        </section>
                </ContentTemplate>
            </asp:UpdatePanel>
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
