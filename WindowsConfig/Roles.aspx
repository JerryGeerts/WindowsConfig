<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="WindowsConfig.Roles" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
        <style>

    </style>
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
            <h1>What roles do you want to have installed on your server?</h1>
            <asp:CheckBoxList ID="cblLeft" runat="server">
                <asp:ListItem Value="WSUS;">WSUS</asp:ListItem>
                <asp:ListItem Value="DHCP;">DHCP</asp:ListItem>
                <asp:ListItem Value="DNS;">DNS</asp:ListItem>
            </asp:CheckBoxList>
            <asp:CheckBoxList ID="cblRight" runat="server">
                <asp:ListItem Value="DFS;">DFS</asp:ListItem>
                <asp:ListItem Value="IIS;">IIS</asp:ListItem>
                <asp:ListItem Value="WDS;">WDS</asp:ListItem>
            </asp:CheckBoxList>
            <asp:CheckBoxList ID="cblMiddle" runat="server">
                <asp:ListItem Value="AD;">Active Directory</asp:ListItem>
            </asp:CheckBoxList>
             <asp:Label ID="lblError" runat="server" Text="" CssClass="Error"></asp:Label>
        </div>
        <div class="bottom-wizzard">
            <asp:Button ID="btnBackward" runat="server" Text="&#10094; Backward" OnClick="btnBackward_Click" />
            <asp:Button ID="btnForward" runat="server" Text="Forward &#10095;" OnClick="btnForward_Click" />
        </div>
    </div>
</asp:Content>