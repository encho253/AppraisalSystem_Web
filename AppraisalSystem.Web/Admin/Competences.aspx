<%@ Page Title="Competences" 
    Language="C#"
     MasterPageFile="~/Admin/MasterPageAdmin.master" 
    AutoEventWireup="true" 
    CodeBehind="Competences.aspx.cs" 
    Inherits="AppraisalSystem.Web.Admin.Competences" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
    <div>
        <p>Select Position:</p>
        <asp:DropDownList ID="DropDownPositions" class="btn btn-default dropdown-toggle" runat="server" AutoPostBack="True"></asp:DropDownList>
    </div>
</asp:Content>