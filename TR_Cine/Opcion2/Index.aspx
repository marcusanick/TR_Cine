<%@ Page Title="" Language="C#" MasterPageFile="~/Opcion2/PagInicio.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TR_Cine.Opcion2.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_contenido" runat="server">

    

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
                        <a href="FuncionesC.aspx">
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_footer" runat="server">
</asp:Content>
