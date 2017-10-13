<%@ Page Title="QuestionsPage"
    Language="C#"
    MasterPageFile="~/Admin/MasterPageAdmin.master"
    AutoEventWireup="true"
    CodeBehind="Questions.aspx.cs"
    Inherits="AppraisalSystem.Web.Admin.Questions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
    <div>
        <h4>Questions</h4>
    </div>
    <div>
        <p>Select Competence</p>
        <asp:DropDownList ID="DropDownListCompetences" runat="server" AutoPostBack="True"></asp:DropDownList>
        <p><br /></p>
        <asp:Repeater ID="dataTable" runat="server">
            <HeaderTemplate>
                <table class="table table-bordered">
                    <tr>
                        <th>
                            <asp:Label ID="LabelSelectedValue" runat="server"
                                Text="<%#: this.DropDownListCompetences.SelectedItem.Text %>" />
                            competences
                        </th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="lblEdit" runat="server" Text='<%#Eval("Content")%>'></asp:Label>
                        <asp:Label ID="lblId" runat="server" Text='<%#Eval("ID")%>' Visible="false"></asp:Label>
                        <asp:TextBox ID="txtEdit" runat="server" Width="100%" Text='<%# Eval("Content") %>' Visible="false" />
                    </td>
                    <td>
                        <asp:LinkButton ID="lnkEdit" Text="Edit" runat="server" OnClick="lnkEdit_Click" />
                        <asp:LinkButton ID="lnkDelete" Text="Delete" runat="server" OnClick="lnkDelete_Click" OnClientClick="return confirm('Do you want to delete this question?');" />
                        <asp:LinkButton ID="lnkSave" Text="Save" runat="server" Visible="false" OnClick="lnkSave_Click" />
                        <asp:LinkButton ID="lnkCancel" Text="Cancel" runat="server" Visible="false" OnClick="lnkCancel_Click" />
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>

        <h4>Add Question</h4>
        <asp:DropDownList ID="DropDownAddQuestion" runat="server"></asp:DropDownList>
        <asp:TextBox ID="txtAddQuestion" runat="server" Width="100%" />
        <asp:Button ID="SubmitQuestion" Text="Add" OnClick="Submit_Question" runat="server" />
    </div>
</asp:Content>
