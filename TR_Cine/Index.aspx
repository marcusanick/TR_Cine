<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TR_Cine.Index" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>CinePlanet</title>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link href="css/estilosp.css" rel="stylesheet">
    <link href="css/estiloh.css" rel="stylesheet">
    <script src="https://kit.fontawesome.com/eb496ab1a0.js" crossorigin="anonymous"></script>
    <style>
        /*Esto lo hice yo :D no te creas 28/11/2021 Jose Quiña*/
        .button {            
            width: 87%;
            font-size: 20px;
            background: transparent;
            padding: 15px 10px;
            border-radius: 5px;
            cursor: pointer;
            border: 4px solid #26595c;
        }

            .button:hover {
                background: cadetblue;
            }

        /*----Tabs style-------------*/

        .icon2 {
            min-width: 50px;
            text-align: center;
            color: rgb(255, 255, 255);
        }

        .dimension {
            width: 300px;
            height: 500px;
        }

        .nav-tabs .nav-link.active {
            background-color: #322523;
            color: #fff;
            border: 4px solid #322523;
        }

        .nav-tabs .nav-link {
            background-color: #fff;
            color: #322523;
            border: 5px solid #322523;
            margin-right: 1rem;
            padding-left: 1rem;
            padding-right: 1rem;
        }

            .nav-tabs .nav-link:hover {
                border: 3px solid #322523;
            }

        .nav-tabs {
            border-bottom: 3px solid #322523;
        }

        .tab-content {
            border: 1px solid #322523;
            padding: 50px;
        }

        /*----Peliculas style-------*/
        .box {
            width: 175px;
            height: 263px;
            display: flex;
            text-align: flex-start;
            overflow: hidden;
            position: relative;
            margin: 1.5%;
            border-radius: 10px;
        }
        .box2 {
            width: 200px;
            height: 55px;
            display: flex;
            text-align: flex-start;
            overflow: hidden;
            position: relative;
            margin: 1.5%;
            border-radius: 10px;
        }

            .box .hover {
                width: 0%;
                height: 50vh;
                background-color: rgba(100, 189, 100, 0);
                position: absolute;
                top: 0;
                display: flex;
                justify-content: center;
                align-items: center;
                overflow: hidden;
                transition: .4s all;
            }

        .hover h1 {
            color: aliceblue;
            text-shadow: 1px 1px 1px black;
            font-size: 2.5em;
            text-transform: lowercase;
        }

        .box:hover .hover {
            width: 100%;
        }

        img {
            width: 100%;
        }

        /*-----------Diseño para telefono-----------------------------------------------*/

        @media all and (max-width:480px) {

            .button {
                display: none;
            }

                .button:hover {
                    background: cadetblue;
                }

            /*----Tabs style-------------*/

            .dimension {
                width: 300px;
                height: 300px;
            }

            .nav-tabs .nav-link.active {
                display: none;
            }

            .nav-tabs .nav-link {
                display: none;
            }

                .nav-tabs .nav-link:hover {
                    display: none;
                }

            .nav-tabs {
                display: none;
            }

            .tab-content {
                border: 0 solid #9400d3;
                padding: 0;
            }
        }

        @media all and (max-width:1200px) {

            .button {
                border: none;
                width: 77%;
                color: white;
                font-size: 20px;
                background: #1a2537;
                padding: 15px 10px;
                border-radius: 5px;
                cursor: pointer;
            }

                .button:hover {
                    background: cadetblue;
                }
        }

        @media all and (max-width:760px) {

            .button {
                border: none;
                width: 50%;
                color: white;
                font-size: 20px;
                background: #1a2537;
                padding: 15px 10px;
                border-radius: 5px;
                cursor: pointer;
            }

                .button:hover {
                    background: cadetblue;
                }
        }

        @media all and (max-width:650px) {

            .button {
                border: none;
                width: 50%;
                color: white;
                font-size: 20px;
                background: #1a2537;
                padding: 15px 10px;
                border-radius: 5px;
                cursor: pointer;
            }

                .button:hover {
                    background: cadetblue;
                }
        }
    </style>
</head>

<body>
    
    <form runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <!-- Navbar  Bootstrap-->
    <section>
        <nav class="navbar fixed-top navbar-expand-lg navbar-dark p-md-3">
        <div class="container">
            <asp:LinkButton ID="lnk_Home" runat="server" class="navbar-brand" >Cineplanet</asp:LinkButton>
            
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarNav">
                <div class="mx-auto"></div>
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <asp:LinkButton ID="lnk_login" runat="server" class="nav-link text-white" OnClick="lnk_login_Click"><i class="fas fa-user icon2"> Iniciar Sesión</i></asp:LinkButton>
                       
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    </section>
    
    

    <br></br>

    <!-- Carrusel de Imagenes Bootstrap -->
        <section>
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
        </section>
    

    <br></br>

    <!-- Peliculas style-->
        <section>

       
    
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
                <a class="nav-link" data-bs-toggle="tab" href="#profile">
                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-person-bounding-box" viewBox="0 0 16 16">
                        <path d="M1.5 1a.5.5 0 0 0-.5.5v3a.5.5 0 0 1-1 0v-3A1.5 1.5 0 0 1 1.5 0h3a.5.5 0 0 1 0 1h-3zM11 .5a.5.5 0 0 1 .5-.5h3A1.5 1.5 0 0 1 16 1.5v3a.5.5 0 0 1-1 0v-3a.5.5 0 0 0-.5-.5h-3a.5.5 0 0 1-.5-.5zM.5 11a.5.5 0 0 1 .5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 1 0 1h-3A1.5 1.5 0 0 1 0 14.5v-3a.5.5 0 0 1 .5-.5zm15 0a.5.5 0 0 1 .5.5v3a1.5 1.5 0 0 1-1.5 1.5h-3a.5.5 0 0 1 0-1h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 1 .5-.5z" />
                        <path d="M3 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H3zm8-9a3 3 0 1 1-6 0 3 3 0 0 1 6 0z" />
                    </svg>
                    Snacks</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" data-bs-toggle="tab" href="#contact">
                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-telephone-fill" viewBox="0 0 16 16">
                        <path fill-rule="evenodd" d="M1.885.511a1.745 1.745 0 0 1 2.61.163L6.29 2.98c.329.423.445.974.315 1.494l-.547 2.19a.678.678 0 0 0 .178.643l2.457 2.457a.678.678 0 0 0 .644.178l2.189-.547a1.745 1.745 0 0 1 1.494.315l2.306 1.794c.829.645.905 1.87.163 2.611l-1.034 1.034c-.74.74-1.846 1.065-2.877.702a18.634 18.634 0 0 1-7.01-4.42 18.634 18.634 0 0 1-4.42-7.009c-.362-1.03-.037-2.137.703-2.877L1.885.511z" />
                    </svg>
                    Proximos Estrenos</a>
            </li>
        </ul>
        <div class="tab-content">
            <div class="tab-pane active" id="home">
                <div class="row border g-0 rounded shadow-sm">
                    <!-- Aqui el Repeater-->
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div class="col p-4">
                                <a href="<%#DataBinder.Eval(Container.DataItem,"pel_url") %>">
                                    <div class="box">
                                        <img src="data:image/jpg;base64,<%#Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"pel_img")) %>">
                                        <div class="hover">
                                            <h1><%# DataBinder.Eval(Container.DataItem,"pel_Titulo") %></h1>
                                        </div>                                       
                                    </div>
                                    <div class="box2">
                                         <asp:Button ID="btn_comprar" runat="server" class="button" Text="Comprar" />
                                    </div>
                                </a>                                                                 
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <!-------FinRepeater---->
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
     </section>
            </form>
    <br></br>
    <br></br>
    <br></br>
    <br></br>

    <!--::::Pie de Pagina estilosp.css::::::-->
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
    <script type="text/javascript">
        var nav = document.querySelector('nav');
        nav.classList.add('bg-dark', 'shadow');
    </script>
</body>
</html>
