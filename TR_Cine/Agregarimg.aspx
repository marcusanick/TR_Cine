<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregarimg.aspx.cs" Inherits="TR_Cine.Agregarimg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    Imagen Agregada:
                    <br />
                    <asp:Image ID="img_preview" width="200" ImageUrl="https://cdn-icons-png.flaticon.com/512/16/16410.png" runat="server" />
                    <br />
                    <br />
                    Archivo:
                    <asp:FileUpload ID="FuploadImage" accept=".jpg" runat="server" CssClass="form-control"/>
                    <br />
                    <br />
                    Titulo:
                    <asp:TextBox ID="txt_titulo" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                    sinopsis:
                    <asp:TextBox ID="txt_sinopsis" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                    url:
                    <asp:TextBox ID="txt_url" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:Button ID="btn_subir" runat="server" Text="Adjuntar" CssClass="btn btn-success" OnClick="btn_subir_Click"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
