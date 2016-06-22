<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Server.aspx.cs" Inherits="WindowsConfig.Server" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="top-wizzard">
        <p id="prog"><strong>PROGRESS</strong></p>
        <div class="progress">
            <div class="progress-bar" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" style="width:0%;background-color:#34495e;">
            </div>
        </div>
        <div class="shadow">
        </div>
    </div>
    <div class="wizzard-form">
        <div class="middle-wizzard">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="W8">Windows Server 2008</asp:ListItem>
                <asp:ListItem Value="W12"> Windows Server 2012</asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <div class="bottom-wizzard">
            <asp:Button ID="btnBackward" runat="server" Text="&#10094; Backward" OnClick="btnBackward_Click"/>
            <asp:Button ID="btnForward" runat="server" Text="Forward &#10095;" />
        </div>
    </div>
</asp:Content>