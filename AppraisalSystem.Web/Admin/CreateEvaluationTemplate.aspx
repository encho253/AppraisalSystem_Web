﻿<%@ Page Title="CreateEvaluationTemplate"
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
    <p>
        <br />
    </p>
    <asp:Repeater ID="dataTable" runat="server">
        <HeaderTemplate>
            <table class="table table-hover">
                <tr>
                    <th class="thead-inverse"> Choose questions for your form
                    </th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr class="success">
                <td>
                    <asp:Label ID="lblQuestionContent" runat="server" Text='<%#Eval("Content")%>'></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox" runat="server" />
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>                
        </FooterTemplate>
    </asp:Repeater>
    <p>Enter template name:</p>
    <asp:TextBox ID="TemplateName" runat="server"></asp:TextBox>
    <p>
        <br />
    </p>
    <asp:Button ID="button" runat="server" Text="Create" OnClick="CreateEvalTemplate" />
</asp:Content>
