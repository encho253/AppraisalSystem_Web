<%@ Page Title="EvaluationInfo"
    Language="C#"
    MasterPageFile="~/Admin/MasterPageAdmin.master"
    AutoEventWireup="true"
    CodeBehind="EvaluationTemplateInfo.aspx.cs"
    Inherits="AppraisalSystem.Web.Admin.EvaluationTemplateInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
    <asp:Repeater ID="dataTable" runat="server">
        <HeaderTemplate>
            <table class="table table-hover">
                <tr>
                    <th class="thead-inverse">Id
                    </th>
                     <th class="thead-inverse">Content
                    </th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr class="success">
                <td>
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("CompetenceId")%>'></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblEdit" runat="server" Text='<%#Eval("Content")%>'></asp:Label>
                </td>
                <td></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>                
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>