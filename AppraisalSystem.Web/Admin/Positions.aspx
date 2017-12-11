<%@ Page Title="Positions"
    Language="C#"
    MasterPageFile="~/Admin/MasterPageAdmin.master"
    AutoEventWireup="true"
    CodeBehind="Positions.aspx.cs"
    Inherits="AppraisalSystem.Web.Admin.Positions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
    <asp:Repeater ID="dataTable" runat="server">
        <HeaderTemplate>
            <table class="table table-hover">
                <tr>
                    <th class="thead-inverse col-xs-10">
                        <asp:Label ID="LabelEvaluators" runat="server" Text="Position" />
                    </th>
                    <th class="thead-inverse col-xs-2">
                        <asp:Label ID="Options" runat="server" Text="Options" />
                    </th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:Label ID="lblEdit" runat="server" Text='<%#Eval("Name")%>'></asp:Label>
                    <asp:Label ID="lblId" runat="server" Text='<%#Eval("Id")%>' Visible="false"></asp:Label>
                    <asp:TextBox ID="txtEdit" runat="server" CssClass="text-field" TextMode="MultiLine" Rows="2" Width="100%" Text='<%# Eval("Name") %>' Visible="false" />
                </td>
                <td>
                    <asp:LinkButton ID="lnkEdit" class="btn btn-primary" Text="Edit" runat="server" OnClick="lnkEdit_Click" />
                    <asp:LinkButton ID="lnkDelete" class="btn btn-danger" Text="Delete" runat="server" OnClick="lnkDelete_Click" OnClientClick="return confirm('Do you want to delete this position? You will delete all questions for this position');" />
                    <asp:LinkButton ID="lnkSave" class="btn btn-success" Text="Save" runat="server" Visible="false" OnClick="lnkSave_Click" />
                    <asp:LinkButton ID="lnkCancel" class="btn btn-warning" Text="Cancel" runat="server" Visible="false" OnClick="lnkCancel_Click" />
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>             
        </FooterTemplate>
    </asp:Repeater>
    <div class="container">
        <div class="row">
            <asp:TextBox ID="txtAddPosition" Width="100%" class="form-control input-sm col-xs-10" runat="server" />
            <asp:Button ID="AddPosition" class="btn btn-success col-xs-2" Text="Add" OnClick="AddPosition_Click" runat="server" />
        </div>
    </div>
</asp:Content>
