<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 class="text-left">TryIt</h1>
        <p class="lead">Enter the URL of an XML file to view its contents.</p>
        <p>
            <asp:TextBox ID="urlTextBox" runat="server" Width="486px" Font-Size="Medium"></asp:TextBox>
            <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
        </p>
        <p>
            <asp:ListBox ID="ListBox1" runat="server" Font-Size="X-Small" Height="853px" Width="719px"></asp:ListBox>
        </p>
    </div>

    </asp:Content>
