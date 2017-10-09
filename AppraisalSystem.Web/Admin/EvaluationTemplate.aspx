<%@ Page Title="EvaluationTemplate"
     Language="C#" 
    MasterPageFile="~/Admin/MasterPageAdmin.master" 
    AutoEventWireup="true" 
    CodeBehind="EvaluationTemplate.aspx.cs" 
    Inherits="AppraisalSystem.Web.Admin.EvaluationTemplate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
    <div>
        <p>
            Evaluation Form
        </p>
    </div>
        <h3>Navigation Menu</h3>
        <asp:BulletedList ID="BulletedListMenu" runat="server" DisplayMode="HyperLink"
            DataTextField="Text" DataValueField="Url"></asp:BulletedList>

        <h3>List Controls</h3>
        <table id="layoutTable">
            <tr>
                <td>Choose town from the ListBox:</td>
                <td><asp:ListBox ID="ListBoxTowns" runat="server"></asp:ListBox></td>
            </tr>
            <tr>
                <td>Select your gender from the DropDownList:</td>
                <td><asp:DropDownList ID="DropDownListGender" runat="server"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>Select your favourite food from the CheckBoxList:</td>
                <td><asp:CheckBoxList ID="CheckBoxListFood" runat="server"
                    DataTextField="Text" DataValueField="ID"></asp:CheckBoxList></td>
            </tr>
            <tr>
                <td>Select how you will pay from the RadioButtonList:</td>
                <td><asp:RadioButtonList ID="RadioButtonListPayment" runat="server"
                    DataTextField="Text" DataValueField="ID"></asp:RadioButtonList></td>
            </tr>
            <tr>
                <td colspan="2" id="submitButtonCell">
                    <asp:Button ID="ButtonSubmit" runat="server"
                        Text="Process Form Data" onclick="ButtonSubmit_Click" />
                </td>
            </tr>
            <tr id="ResultsRow" runat="server" visible="false">
                <td colspan="2">
                    <asp:Literal ID="LiteralResult" runat="server"></asp:Literal>
                </td>
            </tr>
        </table>
    </>
</asp:Content>