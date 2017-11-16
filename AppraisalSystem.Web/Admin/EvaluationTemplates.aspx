<%@ Page Title="EvaluationTemplates"
    Language="C#"
    MasterPageFile="~/Admin/MasterPageAdmin.master"
    AutoEventWireup="true"
    CodeBehind="EvaluationTemplates.aspx.cs"
    Inherits="AppraisalSystem.Web.Admin.EvaluationTemplates" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
    <asp:Repeater ID="dataTable" runat="server">
        <HeaderTemplate>
            <table class="table table-hover">
                <tr>
                    <th class="thead-inverse">
                        <asp:Label ID="LabelEvaluators" runat="server" Text="Templates" />
                    </th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <a href="EvaluationTemplateInfo.aspx?Id=<%#Eval("Id")%>"><%#Eval("Name")%></a>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table> 
        </FooterTemplate>
    </asp:Repeater>
    <asp:LinkButton ID="CreateTemplate" class="btn btn-success" Text="Create New" runat="server" OnClick="CreateTemplate_Click" />
</asp:Content>