<%@ Page Title="Create new account"
    Language="C#"
    MasterPageFile="~/Admin/MasterPageAdmin.master"
    AutoEventWireup="true"
    CodeBehind="Register.aspx.cs"
    Inherits="AppraisalSystem.Web.Admin.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
    <h4><%: Title %></h4>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <asp:ValidationSummary runat="server" CssClass="text-danger" />

        <asp:Label runat="server" AssociatedControlID="FirstName">First Name</asp:Label>
        <div class="form-group">
            <div class="col-md-12">
                <asp:TextBox runat="server" ID="FirstName" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstName"
                    CssClass="text-danger" ErrorMessage="The first name field is required." />
            </div>
        </div>

        <asp:Label runat="server" AssociatedControlID="LastName">Last Name</asp:Label>
        <div class="form-group">
            <div class="col-md-12">
                <asp:TextBox runat="server" ID="LastName"  CssClass="form-control" TextMode="SingleLine"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                    CssClass="text-danger" ErrorMessage="The last name field is required." />
            </div>
        </div>

        <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
        <div class="form-group">
            <div class="col-md-12">
                <asp:TextBox runat="server" ID="Password" CssClass="form-control" TextMode="Password" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
        </div>

        <asp:Label runat="server" AssociatedControlID="Email">Email</asp:Label>
        <div class="form-group">
            <div class="col-md-12">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>

        <asp:Label runat="server" AssociatedControlID="Position">Position</asp:Label>
        <div class="form-group">
            <div class="col-md-12">
                <asp:TextBox runat="server" ID="Position" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Position"
                    CssClass="text-danger" ErrorMessage="The position field is required." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-12">
                <asp:Button runat="server" OnClick="Click" Text="Register" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
