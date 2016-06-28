<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Name.aspx.cs" Inherits="WindowsConfig.Name" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <style>
        .txtName {
            position: relative;
            top: 195px;
            display: block;
            margin: auto;
            width: 40%;
            height: 30px;
            text-align: center;
            font-family: "Open Sans";
            font-weight: 400;
            font-size: 16px;
        }

        .Error {
            top: 330px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="top-wizzard">
        <p id="prog"><strong>PROGRESS</strong></p>

        <div class="progress">
            <div class="progress-bar" role="progressbar" aria-valuenow="70" aria-valuemin="0" aria-valuemax="100" style="width: 100%; background-color: #34495e;"></div>
        </div>

        <div class="shadow"></div>
    </div>

    <div class="wizzard-form" aria-grabbed="true" aria-invalid="spelling">
        <div class="middle-wizzard">
            <h1>What name would you like your server to have?</h1>
            <asp:TextBox ID="txtName" runat="server" CssClass="txtName"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" Text="" CssClass="Error"></asp:Label>
        </div>

        <div class="bottom-wizzard">
            <asp:Button ID="btnBackward" runat="server" Text="&#10094; Backward" OnClick="btnBackward_Click" />
            <asp:Button ID="btnForward" runat="server" Text="Forward &#10095;" OnClick="btnForward_Click" />
        </div>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtName" ValidationExpression="^[a-zA-Z0-9_/s]{1,15}$" ValidateRequestMode="Enabled" ValidationGroup="ServerName"></asp:RegularExpressionValidator>
    </div>
</asp:Content>