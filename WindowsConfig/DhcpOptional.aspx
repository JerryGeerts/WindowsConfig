<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DhcpOptional.aspx.cs" Inherits="WindowsConfig.DhcpOptional" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" DefaultButton="btnForward">

    <div class="top-wizzard">
        <p id="prog"><strong>PROGRESS</strong></p>
        <div class="progress">
            <div class="progress-bar" role="progressbar" aria-valuenow="70" aria-valuemin="0" aria-valuemax="100" style="width: 100%; background-color: #34495e;">
            </div>
        </div>
        <div class="shadow">
        </div>
    </div>
    <div class="wizzard-form">
        <div class="middle-wizzard">
            <h1>Would you like to add a Default Gateway and a DNS server? (Optional)</h1>

            <p class="p">Router IP :</p>
            <asp:TextBox ID="txtRouter" runat="server" CssClass="Router"></asp:TextBox>

            <p class="p">DNS Domain name :</p>
            <asp:TextBox ID="txtName" runat="server" CssClass="DNSName"></asp:TextBox>

            <p class="p">DNS server IP :</p>
            <asp:RegularExpressionValidator ID="revDNSIP" runat="server" ControlToValidate="txtDNSIP" ValidationExpression="^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"></asp:RegularExpressionValidator>
            <asp:TextBox ID="txtDNSIP" runat="server" CssClass="DNSIP"></asp:TextBox>

            <asp:Label ID="lblError" runat="server" Text="" CssClass="Error"></asp:Label>
        </div>
        <div class="bottom-wizzard">
            <asp:Button ID="btnBackward" runat="server" Text="&#10094; Backward" CssClass="auto-style1" OnClick="btnBackward_Click" />
            <asp:Button ID="btnForward" runat="server" Text="Forward &#10095;" OnClick="btnForward_Click" />
        </div>
    </div>
</asp:Content>