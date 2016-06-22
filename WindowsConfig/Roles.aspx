<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="WindowsConfig.Roles" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="top-wizzard">
        <p id="prog"><strong>PROGRESS</strong></p>
        <div class="progress">
            <div class="progress-bar" role="progressbar" aria-valuenow="70" aria-valuemin="0" aria-valuemax="100" style="width:100%;background-color:#34495e;">
            </div>
        </div>
        <div class="shadow">
        </div>
    </div>
    <div class="wizzard-form">
        <div class="middle-wizzard">

        </div>

        <div class="bottom-wizzard">
            <asp:Button ID="btnBackward" runat="server" Text="&#10094; Backward" />
            <asp:Button ID="btnForward" runat="server" Text="Forward &#10095;" />
        </div>
    </div>
</asp:Content>