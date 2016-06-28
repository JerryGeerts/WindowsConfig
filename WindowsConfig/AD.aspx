<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AD.aspx.cs" Inherits="WindowsConfig.AD" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .Domain, .Pass, .Confirm {
            top: 110px;
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
            top: 150px;
            position: relative;
            font-family: "Open Sans";
            font-weight: 300;
            font-size: 16px;
            left: 30%;
        }

        .Error {
            top: 180px;
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
            <h1>How would you like your AD Role to be configured?</h1>

            <p class="p">Domain Name :</p>
            <asp:TextBox ID="txtDomain" runat="server" CssClass="Domain"></asp:TextBox>

            <p class="p">Recovery pass :</p>
            <asp:TextBox ID="txtPass" runat="server" CssClass="Pass" TextMode="Password"></asp:TextBox>

            <p class="p">Confirm Recovery pass :</p>
            <asp:TextBox ID="txtConfirm" runat="server" CssClass="Confirm" TextMode="Password"></asp:TextBox>

            <asp:Label ID="lblError" runat="server" Text="" CssClass="Error"></asp:Label>
        </div>
        <div class="bottom-wizzard">
            <asp:Button ID="btnBackward" runat="server" Text="&#10094; Backward" CssClass="auto-style1" OnClick="btnBackward_Click" />
            <asp:Button ID="btnForward" runat="server" Text="Forward &#10095;" OnClick="btnForward_Click" />
        </div>
    </div>
</asp:Content>