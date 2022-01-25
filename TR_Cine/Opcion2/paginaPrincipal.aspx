<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paginaPrincipal.aspx.cs" Inherits="TR_Cine.Opcion2.paginaPrincipal" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Cinema</title>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" >
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link href="css/estilos.css" rel="stylesheet">
    <script src="https://kit.fontawesome.com/eb496ab1a0.js" crossorigin="anonymous"></script>
</head>
<body>
     <form runat="server">
          <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <!-- Navbar  Bootstrap-->
    <nav class="navbar fixed-top navbar-expand-lg navbar-dark p-md-3">
        <div class="container">
            <a class="navbar-brand" href="paginaPrincipal.aspx">Cinema</a>
             <asp:LinkButton ID="lnk_Home" runat="server" class="navbar-brand" >Cinema</asp:LinkButton>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarNav">
                <div class="mx-auto"></div>
                <ul class="navbar-nav">                        
                    <li class="nav-item">                               
                        <a class="nav-link text-white" href="#" background >Dulcería</a>
                    </li>
                    <li class="nav-item">                               
                        <a class="nav-link text-white" href="#" background >Promociones</a>
                    </li>
                    <li class="nav-item">    
                   <asp:LinkButton ID="lnk_login" runat="server" class="nav-link text-white" OnClick="lnk_login_Click"><i class="fas fa-user icon2"> Iniciar Sesión</i></asp:LinkButton>

                        
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <br></br><br>

    <!-- Carrusel de Imagenes Bootstrap -->
    <div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="img/ghost.jpg" class="d-block w-100" alt="banner 1">
            </div>
            <div class="carousel-item">
                <img src="img/banner2.png" class="d-block w-100" alt="banner 2">
            </div>
            <div class="carousel-item">
                <img src="img/banner3.png" class="d-block w-100" alt="banner 3">
            </div>
        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
        </button>
    </div>

    <br></br>

    <!-- Peliculas style-->
    <div class="container mt-2 flex-start">
        <ul class="nav nav-tabs">
            <li class="nav-item">
                <a class="nav-link active" data-bs-toggle="tab" href="#home">
                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-house-fill" viewBox="0 0 16 16">
                        <path fill-rule="evenodd" d="M8 3.293l6 6V13.5a1.5 1.5 0 0 1-1.5 1.5h-9A1.5 1.5 0 0 1 2 13.5V9.293l6-6zm5-.793V6l-2-2V2.5a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5z" />
                        <path fill-rule="evenodd" d="M7.293 1.5a1 1 0 0 1 1.414 0l6.647 6.646a.5.5 0 0 1-.708.708L8 2.207 1.354 8.854a.5.5 0 1 1-.708-.708L7.293 1.5z" />
                    </svg>
                    Cartelera</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" data-bs-toggle="tab" href="#contact">
                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-calendar3" viewBox="0 0 16 16">
                        <path d="M14 0H2a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2zM1 3.857C1 3.384 1.448 3 2 3h12c.552 0 1 .384 1 .857v10.286c0 .473-.448.857-1 .857H2c-.552 0-1-.384-1-.857V3.857z"/>
                        <path d="M6.5 7a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm-9 3a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm-9 3a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2z"/>
                    </svg>
                    Proximos Estrenos</a>
            </li>
        </ul>
        <div class="tab-content">
            <div class="tab-pane active" id="home">
                <div class="row border g-0 rounded shadow-sm">
                    <div class="col p-4">
                        <%--mateo--%>
                        <a href="funciones.aspx">
                        <div class="box">
                            <img src="img/portadaeternasl.png">
                            <div class="hover">
                                <h1>Eternals</h1>
                            </div>                            
                        </div>
                    </a>
                    </div>
                    <div class="col p-4">
                        <div class="box ">
                            <img src="img/portada.png">
                            <div class="hover">
                                <h1>Encanto bomb</h1>
                            </div>
                        </div>
                    </div>
                    <div class="col p-4">
                        <div class="box">
                            <img src="img/portadaghost.png">
                            <div class="hover">
                                <h1>hover</h1>
                            </div>
                        </div>
                    </div>
                    <div class="col p-4">
                        <div class="box">
                            <img src="img/portadasoho.png">
                            <div class="hover">
                                <h1>hover</h1>
                            </div>
                        </div>
                    </div>
                    <div class="col p-4">
                        <div class="box">
                            <img src="img/portada.png">
                            <div class="hover">
                                <h1>Encanto bomb</h1>
                            </div>
                        </div>
                    </div>
                    <div class="col p-4">
                        <div class="box ">
                            <img src="img/portadaeternasl.png">
                            <div class="hover">
                                <h1>hover</h1>
                            </div>
                        </div>
                    </div>
                    <div class="col p-4">
                        <div class="box">
                            <img src="img/portadaghost.png">
                            <div class="hover">
                                <h1>hover</h1>
                            </div>
                        </div>
                    </div>
                    <div class="col p-4">
                        <div class="box">
                            <img src="img/portadasoho.png">
                            <div class="hover">
                                <h1>hover</h1>
                            </div>
                        </div>
                    </div>
                    <div class="col p-4">
                        <div class="box">
                            <img src="img/portadasoho.png">
                            <div class="hover">
                                <h1>hover</h1>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="tab-pane" id="profile">
                <div class="row border g-0 rounded shadow-sm">
                    <div class="col p-4">
                        <h3>Profile</h3>
                        <p>
                            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                        </p>
                    </div>
                    <div class="col-auto">
                        <img src="images/profile.jpg" class="img-thumbnail dimension">
                    </div>
                </div>
            </div>
            <div class="tab-pane" id="contact">
                <div class="row border g-0 rounded shadow-sm">
                    <div class="col p-4">
                        <h3>Contact</h3>
                        <p>
                            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                        </p>
                    </div>
                    <div class="col-auto">
                        <img src="images/contact.jpg" class="img-thumbnail dimension">
                    </div>
                </div>
            </div>
        </div>
    </div>
          </form>
    <br></br>
    <br></br>
    <br></br>
    <br></br>
    <!--::::Pie de Pagina estilosp.css::::::-->
    <footer class="pie-pagina">
        <div class="grupo-1">
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
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js"
        integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB"
        crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js"
        integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13"
        crossorigin="anonymous"></script>
</body>
</html>