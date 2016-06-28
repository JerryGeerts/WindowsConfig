<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="WindowsConfig.Result" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="top-wizzard">
        <p id="prog"><strong>FINISHED</strong></p>
        <div class="progress">
            <div class="progress-bar" role="progressbar" aria-valuenow="70" aria-valuemin="0" aria-valuemax="100" style="width: 100%; background-color: #34495e;">
            </div>
        </div>
        <div class="shadow">
        </div>
    </div>
    <div class="wizzard-form">
        <div class="middle-wizzard">
            <asp:TextBox ID="txtBox" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div class="bottom-wizzard">
            <asp:Button ID="btnTxt" runat="server" Text=".Txt" />
            <asp:Button ID="btnScript" runat="server" Text=".PS1" />
        </div>
    </div>
</asp:Content>