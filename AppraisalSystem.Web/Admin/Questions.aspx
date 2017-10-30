﻿<%@ Page Title="Questions"
    Language="C#"
    MasterPageFile="~/Admin/MasterPageAdmin.master"
    AutoEventWireup="true"
    CodeBehind="Questions.aspx.cs"
    Inherits="AppraisalSystem.Web.Admin.Questions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderUsersArea" runat="server">
    <div>
        <h4>Questions</h4>
    </div>

    <div class="inlineEl">
        <p>Select Position</p>
        <asp:DropDownList ID="DropDownPositions" class="btn btn-default dropdown-toggle" runat="server" AutoPostBack="True"></asp:DropDownList>
    </div>
    <div>
        <p>
            <br />
        </p>
        <asp:Repeater ID="dataTable" runat="server">
            <HeaderTemplate>
                <table class="table table-hover">
                    <tr>
                        <th class="thead-inverse">Competence
                        </th>
                        <th class="thead-inverse">Content
                        </th>
                        <th class="thead-inverse">Options
                        </th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr class="success">
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("CompetenceId")%>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblEdit" runat="server" Text='<%#Eval("Content")%>'></asp:Label>
                        <asp:Label ID="lblId" runat="server" Text='<%#Eval("ID")%>' Visible="false"></asp:Label>
                        <asp:TextBox ID="txtEdit" runat="server" CssClass="text-field" TextMode="MultiLine" Rows="2" Width="100%" Text='<%# Eval("Content") %>' Visible="false" />
                    </td>
                    <td>
                        <asp:LinkButton ID="lnkEdit" class="btn btn-primary" Text="Edit" runat="server" OnClick="lnkEdit_Click" />
                        <asp:LinkButton ID="lnkDelete" class="btn btn-danger" Text="Delete" runat="server" OnClick="lnkDelete_Click" OnClientClick="return confirm('Do you want to delete this question?');" />
                        <asp:LinkButton ID="lnkSave" class="btn btn-success" Text="Save" runat="server" Visible="false" OnClick="lnkSave_Click" />
                        <asp:LinkButton ID="lnkCancel" class="btn btn-warning" Text="Cancel" runat="server" Visible="false" OnClick="lnkCancel_Click" />
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>                
            </FooterTemplate>
        </asp:Repeater>
        <asp:DropDownList ID="DropDownCompetences" class="btn btn-default dropdown-toggle" runat="server"></asp:DropDownList>
        <p>
            <br />
        </p>
        <asp:TextBox ID="txtAddQuestion" CssClass="text-field" TextMode="MultiLine" Rows="2" Width="100%" class="form-control input-sm addQuestion" runat="server" />
        <p>
            <br />
        </p>
        <asp:Button ID="SubmitQuestion" class="btn btn-success addQuestion" Text="Add Question" OnClick="Submit_Question" runat="server" />
    </div>
</asp:Content>