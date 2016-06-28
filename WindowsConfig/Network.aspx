<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Network.aspx.cs" Inherits="WindowsConfig.Network" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <style>
        .Error {
            top: 120px;
        }

        .IP4, .DNS, .Sub, .Gate {
            top: 95px;
            position: relative;
            display: block;
            margin: auto;
            width: 25%;
            height: 30px;
            font-family: "Open Sans";
            font-weight: 400;
            font-size: 16px;
            left: 10%;
        }

        .p {
            top: 130px;
            position: relative;
            font-family: "Open Sans";
            font-weight: 300;
            font-size: 16px;
            left: 30%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
            <h1>What would you like your network settings to be?</h1>
            <p class="p">
                IP4 :<asp:RegularExpressionValidator ID="revIP4" runat="server" ControlToValidate="txtIP4" ValidationExpression="^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"></asp:RegularExpressionValidator>
            </p>
            <asp:TextBox ID="txtIP4" runat="server" CssClass="IP4"></asp:TextBox>
            <p class="p">
                Subnet mask :<asp:RegularExpressionValidator ID="revSubnet" runat="server" ControlToValidate="txtSub" ValidationExpression="^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"></asp:RegularExpressionValidator>
            </p>
            <asp:TextBox ID="txtSub" runat="server" CssClass="Sub"></asp:TextBox>
            <p class="p">
                Gateway :<asp:RegularExpressionValidator ID="revGate" runat="server" ControlToValidate="txtGate" ValidationExpression="^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"></asp:RegularExpressionValidator>
            </p>
            <asp:TextBox ID="txtGate" runat="server" CssClass="Gate"></asp:TextBox>
            <p class="p">
                DNS :<asp:RegularExpressionValidator ID="revDNS" runat="server" ControlToValidate="txtDNS" ValidationExpression="^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"></asp:RegularExpressionValidator>
            </p>
            <asp:TextBox ID="txtDNS" runat="server" CssClass="DNS"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" Text="" CssClass="Error"></asp:Label>
        </div>
        <div class="bottom-wizzard">
            <asp:Button ID="btnBackward" runat="server" Text="&#10094; Backward" OnClick="btnBackward_Click" />
            <asp:Button ID="btnForward" runat="server" Text="Forward &#10095;" OnClick="btnForward_Click" />
        </div>
    </div>
</asp:Content>