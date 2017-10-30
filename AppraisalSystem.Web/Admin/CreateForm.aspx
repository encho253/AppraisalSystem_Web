<%@ Page Title="Evaluation"
    Language="C#"
    MasterPageFile="~/Admin/MasterPageAdmin.master"
    AutoEventWireup="true"
    CodeBehind="CreateForm.aspx.cs"
    Inherits="AppraisalSystem.Web.Admin.CreateForm" %>

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
                        <asp:Label ID="LabelEvaluators" runat="server" Text="First Name" />
                    </th>
                    <th class="thead-inverse">
                        <asp:Label ID="Label1" runat="server" Text="Last Name" />
                    </th>
                    <th class="thead-inverse">
                        <asp:Label ID="Label4" runat="server" Text="Email" />
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
                <td>
                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("Email")%>'></asp:Label>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="Label5" runat="server" Text="Evaluators"></asp:Label>
            </table>   
             <asp:TextBox ID="txtAddEvaluator" Width="100%" class="form-control input-sm" runat="server" />
             <asp:Button ID="AddEvaluator" class="btn btn-success" Text="Add Evaluator" OnClick="AddEvaluator_Click" runat="server" />             
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
