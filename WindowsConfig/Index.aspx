<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WindowsConfig.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .middle-wizzard input {
            font: 25px "Open Sans";
            font-weight: 300;
            letter-spacing: 0.1px;
            border-radius: 0px;
            height: 60px;
            width: 700px;
            background-color: #34495e;
            color: white;
            border: none;
            padding: 0px;
            text-transform: uppercase;
            position: relative;
            margin-top: 60px;
            top: 75px;
            left: 235px;
            box-shadow: 0 0 5px #777;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="top-wizzard">
        <p id="prog"><strong>PROGRESS</strong></p>
        <div class="progress">
            <div class="progress-bar" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" style="width: 0%; background-color: #34495e;">
            </div>
        </div>
        <div class="shadow">
        </div>
    </div>
    <div class="wizzard-form">
        <div class="middle-wizzard">
            <asp:Button ID="btnWizzard" runat="server" Text="Click here if this is a brand new server" OnClick="btnWizzard_Click" />
            <br />
            <asp:Button ID="btnCustom" runat="server" Text="Custom" />
        </div>

        <div class="bottom-wizzard">
        </div>
    </div>
</asp:Content>