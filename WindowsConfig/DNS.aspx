<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DNS.aspx.cs" Inherits="WindowsConfig.DNS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .Error {
            top: 120px;
        }

        .Zone, .Name, .Rec, .IP {
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
            <h1>What would you like your DNS settings to be?</h1>
            <p class="p">Zone Name :</p>
            <asp:TextBox ID="txtName" runat="server" CssClass="Name"></asp:TextBox>

            <p class="p">Look Up Zone :</p>
            <asp:TextBox ID="txtZone" runat="server" CssClass="Zone"></asp:TextBox>

            <p class="p">A-record Name :</p>
            <asp:TextBox ID="txtRec" runat="server" CssClass="Rec"></asp:TextBox>

            <p class="p">
                A-record IP :<asp:RegularExpressionValidator ID="revIP" runat="server" ControlToValidate="txtIP" ValidationExpression="^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"></asp:RegularExpressionValidator>
            </p>
            <asp:TextBox ID="txtIP" runat="server" CssClass="IP"></asp:TextBox>

            <asp:Label ID="lblError" runat="server" Text="" CssClass="Error"></asp:Label>
        </div>
        <div class="bottom-wizzard">
            <asp:Button ID="btnBackward" runat="server" Text="&#10094; Backward" OnClick="btnBackward_Click" />
            <asp:Button ID="btnForward" runat="server" Text="Forward &#10095;" OnClick="btnForward_Click" />
        </div>
    </div>
</asp:Content>