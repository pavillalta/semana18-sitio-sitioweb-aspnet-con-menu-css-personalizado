<%@ Page Title="" Language="VB" MasterPageFile="~/ugbsig.master" AutoEventWireup="false" CodeFile="f_cerrarsesion.aspx.vb" Inherits="f_cerrarsesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style34
        {
            width: 60%;
            border: 2px solid #3D84CC;
            background-color: #FFFFFF;
        }
        
        .style35
        {
            text-align: left;
            font-weight: bold;
            color: #0000CC;
            background-color: #99CCFF;
            height: 20px;
                    font-size: small;
        }
        
            .style65
        {
            text-align: center;
        }
        .style66
        {
            width: 811px;
        }
        .style67
        {
            width: 44px;
        }


        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <table cellpadding="1" cellspacing="1" class="style34" align="center" 
        bgcolor="White">
        <tr>
            <td class="style35" colspan="3">
                CERRAR SESION</td>
        </tr>
        <tr>
            <td class="style41" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style65" colspan="3">
                    <asp:Label ID="lblsesionmensaje" runat="server" Text="Usuario" 
                    style="font-size: large" Font-Size="Medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style65" colspan="3">
                    <asp:Label ID="lblsesionname" runat="server" Text="Usuario" 
                    style="font-size: large; color: #0033CC;" Font-Size="Medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style67">
                &nbsp;</td>
            <td class="style66">
                &nbsp;</td>
            <td class="style40">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style67">
                &nbsp;</td>
            <td class="style66" align ="center">
                <asp:ImageButton ID="SESION" runat="server" Height="70px"
                        ImageUrl="~/Imagenes/seguridad.png" ToolTip="Cerrar la sesion" Width="80px"/>
                <br />
              </td>
            <td></td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

