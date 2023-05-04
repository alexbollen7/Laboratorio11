<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio11._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>INGRESO DE NOTAS</h1>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Universidad:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="212px">
                <asp:ListItem>Mesoamericana</asp:ListItem>
                <asp:ListItem>Landívar</asp:ListItem>
                <asp:ListItem>Del Valle</asp:ListItem>
                <asp:ListItem>San Carlos</asp:ListItem>
                <asp:ListItem>Galileo</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p class="lead">
            <asp:Label ID="Label2" runat="server" Text="DATOS ALUMNO:"></asp:Label>
        </p>
        <p class="lead">
            <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxNombreAlumno" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Carne:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxCarne" runat="server" Width="189px"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Label ID="Label5" runat="server" Text="Fecha Nacimiento:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxFechaNacimiento" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Dirección:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Label ID="Label7" runat="server" Text="DATOS CURSO:"></asp:Label>
        </p>
        <p class="lead">
            Curso:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxNombreCurso" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="Nota:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxNota" runat="server"></asp:TextBox>
        </p>
        <p><asp:Button ID="ButtonRegistroAlumno" runat="server" class="btn btn-primary btn-lg" OnClick="ButtonRegistroAlumno_Click" Text="Registrar Alumno" />
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>
