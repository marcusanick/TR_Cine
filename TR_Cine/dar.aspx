<%@ Page Title="" Language="C#" MasterPageFile="~/Login_Pagina.Master" AutoEventWireup="true" CodeBehind="dar.aspx.cs" Inherits="TR_Cine.dar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cartelera" runat="server">
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
                    Contactenos</a>
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
                                            <h1><%# DataBinder.Eval(Container.DataItem,"pel_titulo") %></h1>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DebajodeCartelera" runat="server">
</asp:Content>
