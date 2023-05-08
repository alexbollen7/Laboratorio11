<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Actualiza.aspx.cs" Inherits="Laboratorio11.Actualiza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="ACTUALIZAR NOMBRE UNIVERSIDAD"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Nombre de universidad a actualizar:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxNombreUniversidad" runat="server" Width="169px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="BUSCAR" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre actual: &nbsp;<asp:Label ID="LabelUniversidad" runat="server" Text="Universidad"></asp:Label>
    </p>
    <p>
        &nbsp;
        <asp:Label ID="Label3" runat="server" Text="Ingrese nuevo nombre:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxNuevoNombre" runat="server" Width="197px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonActualizar" runat="server" OnClick="ButtonActualizar_Click" Text="ACTUALIZAR" />
    </p>
</asp:Content>
