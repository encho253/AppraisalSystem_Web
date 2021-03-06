﻿<%@ Page Title="EvaluationTemplate"
    Language="C#"
    MasterPageFile="~/Admin/MasterPageAdmin.master"
    AutoEventWireup="true"
    CodeBehind="Evaluation.aspx.cs"
    Inherits="AppraisalSystem.Web.Admin.Evaluation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
    <h3>Evaluation</h3>
    <div>
        <p>Search User</p>
        <div class="container">
            <div class="row">
                <asp:TextBox ID="txtAddUser" class="form-control input-sm col-xs-10" runat="server" />
                <asp:Button ID="SearchUser" class="btn btn-success col-xs-2" Text="Search" OnClick="SearchUser_Click" runat="server" />
            </div>
        </div>
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
                    <a href="EvaluationInfo.aspx?Id=<%#Eval("Id")%>">
                        <asp:Label ID="lblUser" runat="server" Text='<%# String.Format("{0:MM/dd/yyyy}",Eval("EvalDate")) %> '></asp:Label></a>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="Label5" runat="server" Text="Evaluators"></asp:Label>
            </table>      
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
