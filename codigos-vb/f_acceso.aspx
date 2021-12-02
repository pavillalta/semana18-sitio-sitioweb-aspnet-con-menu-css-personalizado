<%@ Page Title="" Language="VB" MasterPageFile="~/ugbsig.master" AutoEventWireup="
false" CodeFile="f_acceso.aspx.vb" Inherits="f_acceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        
        .style34
        {
            width: 50%;
            border: 2px solid #3D84CC;
            background-color: #FFFFFF;
        }
        
        .style37
        {
       font-family: "Arial Unicode MS";
       font-size: medium;
       margin-bottom: 0px;
       border: 1px solid #3D84CC;

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
        
            .style49
        {
            text-align: left;
            font-weight: bold;
            color: #0000FF;
            background-color: #FFFFFF;
            width: 160px;
        }
        
   .style52
    {
        text-align: left;
        font-size: small;
        font-weight: bold;
        color: #0000CC;
        background-color: #99CCFF;
        height: 19px;
    }
     
    .style53
    {
        color: #000000;
        font-weight: normal;
        font-size: medium;
    }


        .style56
        {
            height: 16px;
        }



        .style58
    {
        text-align: left;
        font-size: 10pt;
        font-weight: bold;
        color: #0000CC;
        background-color: #99CCFF;
        height: 19px;
    }

        .style48
        {
        font-size: 10pt;
    }

        .style61
    {
        font-size: medium;
    }



        .style64
    {
        text-align: left;
        font-weight: bold;
        color: #0000CC;
        background-color: #99CCFF;
        height: 19px;
                font-size: small;
    }
        </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <table cellpadding="1" cellspacing="1" class="style34" align="center" 
        bgcolor="White">
        <tr>
            <td class="style35" colspan="2">
                CONTROL DE ACCESO</td>
        </tr>
        <tr>
            <td class="style44">
                </td>
            <td class="style45">
                </td>
        </tr>
        <tr>
            <td class="style41">
                Usuario</td>
            <td class="style42">
                <asp:TextBox ID="txtusuario" runat="server" Width="250px" CssClass="style37" 
                    BorderColor="#3333CC" BorderStyle="Solid" BorderWidth="1px" Height="20px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Ingrese su nombre de usuario" ControlToValidate="txtusuario" 
                    Font-Size="10pt" style="text-align: left" Font-Bold="False"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style36">
                Clave</td>
            <td class="style38">
                    <asp:TextBox ID="txtclave" runat="server" TextMode="Password" 
                    CssClass="style37" Width="250px" BorderColor="#3333CC" BorderStyle="Solid" 
                        BorderWidth="1px" Height="20px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="Ingrese su clave" ControlToValidate="txtclave" 
                    Font-Size="10pt" style="text-align: left" Font-Bold="False"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style36">
                &nbsp;</td>
            <td class="style39">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style36" colspan="2" align="center">
                <asp:ImageButton ID="ENTRAR" runat="server" Height="70px"
                        ImageUrl="~/Imagenes/entrar.png" ToolTip="Entrar a sigugb" Width="80px" />
              </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

