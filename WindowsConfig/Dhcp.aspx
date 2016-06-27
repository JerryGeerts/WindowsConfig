<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Dhcp.aspx.cs" Inherits="WindowsConfig.Dhcp" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .Scope,.Start,.End,.Subnet{
        top:95px;
        position:relative;
        display:block;
        margin:auto;
        width:25%;
        height:30px;
        font-family: "Open Sans";
        font-weight:400;
        font-size:16px;
        left:10%;
    }

    .p{
        top:130px;
        position:relative;
        font-family: "Open Sans";
        font-weight:300;
        font-size:16px;
        left:30%;
    }
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
            <h1>How would you like your DHCP server to be configured?</h1>

            <p class="p">Scope Name :</p>
            <asp:RegularExpressionValidator ID="revScope" runat="server" ControlToValidate="txtScope"></asp:RegularExpressionValidator>
            <asp:TextBox ID="txtScope" runat="server" CssClass="Scope"></asp:TextBox>

            <p class="p">Starting IP :</p>
            <asp:RegularExpressionValidator ID="revStart" runat="server" ControlToValidate="txtStart" ValidationExpression="^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"></asp:RegularExpressionValidator>
            <asp:TextBox ID="txtStart" runat="server" CssClass="Start"></asp:TextBox>   
                 
            <p class="p">Ending IP :</p>
            <asp:RegularExpressionValidator ID="revEnd" runat="server" ControlToValidate="txtEnd" ValidationExpression="^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"></asp:RegularExpressionValidator>
            <asp:TextBox ID="txtEnd" runat="server" CssClass="End"></asp:TextBox>

            <p class="p">Subnet :</p>
            <asp:RegularExpressionValidator ID="revSubnet" runat="server" ControlToValidate="txtSubnet" ValidationExpression="^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"></asp:RegularExpressionValidator>
            <asp:TextBox ID="txtSubnet" runat="server" CssClass="Subnet"></asp:TextBox>     
               
            <asp:Label ID="lblError" runat="server" Text="" CssClass="Error"></asp:Label>
        </div>
        <div class="bottom-wizzard">
            <asp:Button ID="btnBackward" runat="server" Text="&#10094; Backward" CssClass="auto-style1" OnClick="btnBackward_Click" />
            <asp:Button ID="btnForward" runat="server" Text="Forward &#10095;" OnClick="btnForward_Click" />
        </div>
    </div>
</asp:Content>