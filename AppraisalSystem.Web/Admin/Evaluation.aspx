<%@ Page Title="Evaluation"
    Language="C#"
    MasterPageFile="~/Admin/MasterPageAdmin.master"
    AutoEventWireup="true"
    CodeBehind="Evaluation.aspx.cs"
    Inherits="AppraisalSystem.Web.Admin.Evaluation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
    <h4>Create evaluation template</h4>
    <div>
        <p>Search User</p>
        <asp:TextBox ID="txtAddUser" Width="100%" class="form-control input-sm" runat="server" />
        <asp:Button ID="SearchUser" class="btn btn-success" Text="Search" OnClick="SearchUser_Click" runat="server" />
    </div>
    <br />
    <asp:Repeater ID="dataTable" runat="server">
        <HeaderTemplate>
            <table class="table table-hover">
                <tr>
                    <th class="thead-inverse">
                        <asp:Label ID="LabelEvaluators" runat="server" Text="FirstName" />
                    </th>
                    <th class="thead-inverse">
                        <asp:Label ID="Label1" runat="server" Text="LastName" />
                    </th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:Label ID="lblUser" runat="server" Text='<%#Eval("FirstName")%>'></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("LastName")%>'></asp:Label>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>                
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
