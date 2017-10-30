<%@ Page Title="MainPage" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="MainPage.aspx.cs" 
    Inherits="AppraisalSystem.Web.MainPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 id="welcome-text">Welcome to our web site</h1>
    <asp:HyperLink runat="server" NavigateUrl="~/Users/UsersHome.aspx" 
        Text="Users Area" CssClass="users-icon"/>
    <asp:HyperLink runat="server" NavigateUrl="~/Admin/Questions.aspx"
         Text="Admin Area" CssClass="administrators-icon"/>
</asp:Content>
