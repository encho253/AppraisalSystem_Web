<%@ Page Title="Evaluation"
    Language="C#"
    MasterPageFile="~/Admin/MasterPageAdmin.master"
    AutoEventWireup="true"
    CodeBehind="Evaluation.aspx.cs"
    Inherits="AppraisalSystem.Web.Admin.Evaluation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
    <h4>Create evaluation template</h4>
    <div>
        <p>Add User</p>
        <asp:TextBox ID="txtAddQuestion" Width="100%" class="form-control input-sm" runat="server" />
    </div>
    <br />
    <div>
        <p>Add Evaluator</p>
        <asp:TextBox ID="txtAddEvaluator" Width="100%" class="form-control input-sm" runat="server" />
    </div>
    <br />
    <asp:Button ID="CreateEvent" class="btn btn-success" Text="Create" OnClick="CreateEvent_Click" runat="server" />
</asp:Content>
