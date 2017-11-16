<%@ Page Title="EvaluationInfo"
     Language="C#" 
    MasterPageFile="~/Admin/MasterPageAdmin.master" 
    AutoEventWireup="true" 
    CodeBehind="EvaluationInfo.aspx.cs" 
    Inherits="AppraisalSystem.Web.Admin.EvaluationInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
     <asp:Label ID="LabelName" runat="server"></asp:Label>
    <asp:Repeater ID="QuestionsRepeater" runat="server">
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
                    <asp:Label ID="LabelId" runat="server" Text='<%#Eval("CompetenceId")%>'></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelContent" runat="server" Text='<%#Eval("Content")%>'></asp:Label>
                </td>
                <td></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>                
        </FooterTemplate>
    </asp:Repeater>

    <asp:Repeater ID="EvaluatorsRepeater" runat="server">
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
              <%--<asp:TextBox ID="txtAddEvaluator" Width="100%" class="form-control input-sm" runat="server" />--%>
           <%-- <asp:LinkButton ID="AddEvaluator" class="btn btn-success" Text="Add Evaluator" OnClick="AddEvaluator_Click" runat="server" />--%>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>