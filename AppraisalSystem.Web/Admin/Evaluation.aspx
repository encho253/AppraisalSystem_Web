<%@ Page Title="EvaluationTemplate" 
    Language="C#" 
    MasterPageFile="~/Admin/MasterPageAdmin.master"
     AutoEventWireup="true" 
    CodeBehind="Evaluation.aspx.cs" 
    Inherits="AppraisalSystem.Web.Admin.Evaluation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
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
                        <asp:Label ID="LabelEvaluators" runat="server" Text="Date" />
                    </th>               
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <a href="EvaluationInfo.aspx"><asp:Label ID="lblUser" runat="server" Text='<%#Eval("EvalDate")%>'></asp:Label></a>
                </td>       
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="Label5" runat="server" Text="Evaluators"></asp:Label>
            </table>      
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>