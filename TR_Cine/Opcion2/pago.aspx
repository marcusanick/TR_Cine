<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pago.aspx.cs" Inherits="TR_Cine.Opcion2.pago" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Cinema</title>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" >
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link href="css/estilos.css" rel="stylesheet">
    <link href="css/contenido.css" rel="stylesheet">
    <script src="https://kit.fontawesome.com/eb496ab1a0.js" crossorigin="anonymous"></script>
</head>
<body>
    <div class="container-body">
    <!-- Navbar  Bootstrap-->
    <nav class="navbar fixed-top navbar-expand-lg navbar-dark p-md-3">
        <div class="container">
            <a class="navbar-brand" href="index.html">Cinema</a>
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
                        <a class="nav-link text-white" href="login.html" background ><i class="fas fa-user icon2"></i>Iniciar Sesión</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <div class="container mt-2 container-movies">
        <div class="lastStep">
            <div class="datosFinales">
                <div class="infoCompra">
                    <h2>Tu compra</h2>
                    <h4>Pelicula</h4>
                    <h4>Sucursal</h4>
                    <h4>Detalle del boleto</h4>
                    <h4>Valor Total</h4>
                </div>
                <div class="infoPersonal">
                    <h3>Datos Personales</h3>
                    <div class="input-container">
                        <input class="inputFinal" placeholder="Cédula" type="text">
                        <input class="inputFinal" placeholder="Nombre" type="text">
                    </div>
                    <div class="input-container">
                        <input class="inputFinal" placeholder="Correo electrónico" type="text">
                        <input class="inputFinal" placeholder="Telefono" type="text">
                    </div>
                    <input class="inputFinal" placeholder="No. Tarjeta" type="text">
                </div>
            </div>
            <div class="aside-bottom">
                <button class="button-step"><a href="snack.aspx">Anterior</a></button>
                <button class="button-step"><a href="paginaPrincipal.aspx">Finalizar</a></button>
            </div>
        </div>
    </div>

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
    </div>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js"
        integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB"
        crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js"
        integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13"
        crossorigin="anonymous"></script>
</body>
</html>