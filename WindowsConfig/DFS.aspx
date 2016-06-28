<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DFS.aspx.cs" Inherits="WindowsConfig.DFS" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .NameSpace, .Server {
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
            <h1>How would you like your DFS Role to be configured?</h1>

            <p class="p">Name space :</p>
            <asp:TextBox ID="txtNameSpace" runat="server" CssClass="NameSpace"></asp:TextBox>

            <p class="p">Server :</p>
            <asp:TextBox ID="txtServer" runat="server" CssClass="Server"></asp:TextBox>

            <asp:Label ID="lblError" runat="server" Text="" CssClass="Error"></asp:Label>
        </div>
        <div class="bottom-wizzard">
            <asp:Button ID="btnBackward" runat="server" Text="&#10094; Backward" CssClass="auto-style1" OnClick="btnBackward_Click" />
            <asp:Button ID="btnForward" runat="server" Text="Forward &#10095;" OnClick="btnForward_Click" />
        </div>
    </div>
</asp:Content>