<%@ Page Title="CreateEvaluationTemplate"
    Language="C#"
    MasterPageFile="~/Admin/MasterPageAdmin.master"
    AutoEventWireup="true"
    CodeBehind="CreateEvaluationTemplate.aspx.cs"
    Inherits="AppraisalSystem.Web.Admin.CreateEvaluationTemplate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
    <p>
        <br />
        Select Position
    </p>
    <asp:DropDownList ID="DropDownPositions" class="btn btn-default dropdown-toggle" runat="server" AutoPostBack="True"></asp:DropDownList>
    <asp:Repeater ID="dataTable" runat="server">
        <HeaderTemplate>
            <table class="table table-hover">
                <tr>
                    <th class="thead-inverse">Content
                    </th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr class="success">
                <td>
                    <asp:Label ID="lblEdit" runat="server" Text='<%#Eval("Content")%>'></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox" runat="server" OnCheckedChanged ="CheckBox_CheckedChanged" />
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>                
        </FooterTemplate>
    </asp:Repeater>
   <asp:Button ID="button" runat="server" Text="Submit" OnClick="button_Click"/>
</asp:Content>
