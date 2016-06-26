<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="WindowsConfig.Roles" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">  
    <style>
        .middle-wizzard #ContentPlaceHolder1_cblLeft{
            display:block;
            float:left;
        }

        .middle-wizzard #ContentPlaceHolder1_cblLeft input{
            width:25px;
            height:25px;
            position:relative;
            left:400px;
            top:120px;
        }

        .middle-wizzard #ContentPlaceHolder1_cblLeft label{
            font-size:20px;
            font-family:"Open Sans";
            position:relative;
            left:400px;
            top:115px;
            color:black;
            font-weight:300;
            margin-top:20px;
            padding-left:30px;
        }

         .middle-wizzard #ContentPlaceHolder1_cblRight{
            display:block;
            float:right;
         }

        .middle-wizzard #ContentPlaceHolder1_cblRight input{
            width:25px;
            height:25px;
            position:relative;
            right:400px;
            top:120px;
        }

        .middle-wizzard #ContentPlaceHolder1_cblRight label{
            font-size:20px;
            font-family:"Open Sans";
            position:relative;
            right:400px;
            top:115px;
            color:black;
            font-weight:300;
            margin-top:20px;
            padding-left:30px;
        }

        .middle-wizzard #ContentPlaceHolder1_cblMiddle{
            display:block;
            margin:0 auto;
         }

        .middle-wizzard #ContentPlaceHolder1_cblMiddle input{
            width:25px;
            height:25px;
            position:relative;
            top:295px;
            left:365px;
        }

        .middle-wizzard #ContentPlaceHolder1_cblMiddle label{
            font-size:20px;
            font-family:"Open Sans";
            position:relative;
            top:292px;
            color:black;
            font-weight:300;
            margin-top:20px;
            padding-left:30px;
            left:365px;
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
            <h1>What roles do you want to have installed on your server?</h1>
            <asp:CheckBoxList ID="cblLeft" runat="server">
                <asp:ListItem Value="WSUS;">WSUS</asp:ListItem>
                <asp:ListItem Value="DHCP;">DHCP</asp:ListItem>
                <asp:ListItem Value="DNS;">DNS</asp:ListItem>
            </asp:CheckBoxList>
            <asp:CheckBoxList ID="cblRight" runat="server">
                <asp:ListItem Value="DFS;">DFS</asp:ListItem>
                <asp:ListItem Value="IIS;">IIS</asp:ListItem>
                <asp:ListItem Value="WDS;">WDS</asp:ListItem>
            </asp:CheckBoxList>
            <asp:CheckBoxList ID="cblMiddle" runat="server">
                <asp:ListItem Value="AD;">Active Directory</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div class="bottom-wizzard">
            <asp:Button ID="btnBackward" runat="server" Text="&#10094; Backward" OnClick="btnBackward_Click" />
            <asp:Button ID="btnForward" runat="server" Text="Forward &#10095;" OnClick="btnForward_Click" />
        </div>
    </div>
</asp:Content>