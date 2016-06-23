<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Server.aspx.cs" Inherits="WindowsConfig.Server" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .middle-wizzard input{
            width:30px;
            height:30px;
            position:relative;
            left:445px;
            top:140px;
            background-color:green;
        }

        .middle-wizzard label{
            font-size:20px;
            font-family:"Open Sans";
            position:relative;
            left:450px;
            top:133px;
            color:black;
            font-weight:300;
            margin-top:30px;
            padding-left:30px;
        }
    </style>
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
            <h1>What type of server are you trying to configure?</h1>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="W8">Windows Server 2008</asp:ListItem>
                <asp:ListItem Value="W12"> Windows Server 2012</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="lblError" runat="server" Text="" CssClass="Error"></asp:Label>
        </div>

        <div class="bottom-wizzard">
            <asp:Button ID="btnBackward" runat="server" Text="&#10094; Backward" OnClick="btnBackward_Click"/>
            <asp:Button ID="btnForward" runat="server" Text="Forward &#10095;" OnClick="btnForward_Click" />
        </div>
    </div>
</asp:Content>