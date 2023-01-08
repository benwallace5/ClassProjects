<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SearchTryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Search Service TryIt</h1>
        <p class="lead">Enter a URL of an XML file and a Name of a person to search for.</p>
        <p>XML File URL:<asp:TextBox ID="urlTextBox" runat="server" Width="632px"></asp:TextBox>
        </p>
        <p>First Name:<asp:TextBox ID="fNameTextBox" runat="server" Width="304px"></asp:TextBox>
        </p>
        <p>Last Name:<asp:TextBox ID="lNameTextBox" runat="server" Width="312px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="searchButton" runat="server" OnClick="searchButton_Click" Text="Search" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
